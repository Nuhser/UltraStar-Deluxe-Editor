using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.Utility;

namespace UltraStarDeluxeEditor {
    public static class ConfigService {
        private const string CONFIG_PATH = ".\\config.xml";
        private const string USD_CONFIG_PATH = "\\config.ini";
        private const string USD_SONGS_PATH = "\\songs";

        private static Config _config;
        public static Config Config => _config ?? (_config = DeserializeConfig());

        public static void SerializeConfig() {
            var serializer = new XmlSerializer(typeof(Config));

            using (Stream fileStream = new FileStream(CONFIG_PATH, FileMode.Create))
            using (XmlWriter xmlWriter = new XmlTextWriter(fileStream, Encoding.Unicode)) {
                serializer.Serialize(xmlWriter, _config);
            }
        }

        private static Config DeserializeConfig() {
            var serializer = new XmlSerializer(typeof(Config));

            try {
                using (Stream fileStream = new FileStream(CONFIG_PATH, FileMode.Open)) {
                    return (Config)serializer.Deserialize(fileStream);
                }
            }
            catch (Exception exception) {
                if (exception is FileNotFoundException || exception is DirectoryNotFoundException) {
                    return new Config();
                }

                throw;
            }
        }

        public static bool FindUsdFolder() {
            MessageBox.Show(
                Resources.noUSDPathConfiguredMessage,
                Resources.noUSDPathConfiguredCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            while (true) {
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;

                var result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK) {
                    var folderName = folderBrowserDialog.SelectedPath;
                    if (File.Exists(folderName + USD_CONFIG_PATH)) {
                        _config.UsdPath = folderName;
                        SerializeConfig();

                        return true;
                    }

                    if (MessageBox.Show(Resources.pathIsNoUSDPathMessage, Resources.pathIsNoUSDPathCaption,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                        continue;
                    }
                }

                return false;
            }
        }

        public static List<string> GetSongDirectories() {
            var songDirectories = new List<string>();
            songDirectories.Add(_config.UsdPath + USD_SONGS_PATH);

            var i = 1;
            while (IniUtil.KeyExists("Directories", "SongDir" + i, _config.UsdPath + USD_CONFIG_PATH)) {
                songDirectories.Add(IniUtil.Read("Directories", "SongDir" + i,
                    _config.UsdPath + USD_CONFIG_PATH));
                i++;
            }

            return songDirectories;
        }
    }
}