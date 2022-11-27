using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.Utility;

namespace UltraStarDeluxeEditor.Configuration {
    public static class ConfigService {
        private const string CONFIG_PATH = ".\\config.xml";
        public static readonly string VERSION = "22.01.1";

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
                    return (Config) serializer.Deserialize(fileStream);
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
            while (true) {
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;
                folderBrowserDialog.Description = Resources.findUsdFolderDescription;

                var result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK) {
                    var folderName = folderBrowserDialog.SelectedPath;
                    _config.UsdPath = folderName;
                    if (_config.IsValidUsdPath()) {
                        SerializeConfig();
                        return true;
                    }

                    if (MessageBox.Show(Resources.usdPathNotValidMessage, Resources.usdPathNotValidCaption,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                        continue;
                    }
                }

                return false;
            }
        }

        public static List<string> GetSongDirectories() {
            var songDirectories = new List<string>();
            songDirectories.Add(Path.Combine(_config.UsdPath, Config.USD_SONGS_DIRECTORY));

            var i = 1;
            while (IniUtil.KeyExists("Directories", "SongDir" + i,
                       Path.Combine(_config.UsdPath, Config.USD_CONFIG_NAME))) {
                songDirectories.Add(IniUtil.Read("Directories", "SongDir" + i,
                    Path.Combine(_config.UsdPath, Config.USD_CONFIG_NAME)));

                i++;
            }

            return songDirectories;
        }
    }
}