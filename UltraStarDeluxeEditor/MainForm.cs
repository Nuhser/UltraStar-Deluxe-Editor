using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UltraStarDeluxeEditor.Properties;

namespace UltraStarDeluxeEditor {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            songInfoGroupBox.Enabled = false;
            songSettingsGroupBox.Enabled = false;
            songFilesGroupBox.Enabled = false;
            textTabControl.Enabled = false;
            player2TextTab.Enabled = false;
        }

        private void InitSongListView() {
            songListView.Items.Clear();
            var songsFound = 0;

            var songDirectories = ConfigService.GetSongDirectories();
            foreach (var songFile in songDirectories.SelectMany(songDirectory =>
                         Directory.GetFiles(songDirectory, "*.txt"))) {
                UltraStarSong song;
                try {
                    song = UltraStarSong.ParseSongFile(songFile);
                }
                catch (UltraStarSongNotValidException ignore) {
                    continue;
                }

                var songListViewItem = new ListViewItem(song.Title);
                songListViewItem.SubItems.Add(song.Artist);
                songListView.Items.Add(songListViewItem);

                songsFound++;
            }

            MessageBox.Show(string.Format(Resources.songListInitializationDoneMessage, songsFound),
                Resources.songListInitializationDoneCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (string.IsNullOrEmpty(config.UsdPath)) {
                ConfigService.FindUsdFolder();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            ConfigService.SerializeConfig();
        }

        private void duetCheckBox_CheckedChanged(object sender, EventArgs e) {
            duetSinger1Label.Enabled = duetCheckBox.Checked;
            duetSinger1TextBox.Enabled = duetCheckBox.Checked;
            duetSinger2Label.Enabled = duetCheckBox.Checked;
            duetSinger2TextBox.Enabled = duetCheckBox.Checked;
            player2TextTab.Enabled = duetCheckBox.Checked;
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (!string.IsNullOrEmpty(config.UsdPath)) {
                InitSongListView();
            }
        }
    }
}