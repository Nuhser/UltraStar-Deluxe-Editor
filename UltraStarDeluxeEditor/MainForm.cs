using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UltraStarDeluxeEditor.Properties;

namespace UltraStarDeluxeEditor {
    public partial class MainForm : Form {
        private readonly Image _defaultCoverImage;
        private UltraStarSong _selectedSong;

        public MainForm() {
            InitializeComponent();
            
            // set ranges for NumericUpDowns
            bpmNumericUpDown.Minimum = decimal.One;
            bpmNumericUpDown.Maximum = decimal.MaxValue;
            gapNumericUpDown.Minimum = decimal.Zero;
            gapNumericUpDown.Maximum = decimal.MaxValue;
            videoGapNumericUpDown.Minimum = decimal.Zero;
            videoGapNumericUpDown.Maximum = decimal.MaxValue;

            _defaultCoverImage = new Bitmap("..\\..\\assets\\DefaultCover.jpg");

            SetSongDetailEnabled(false);
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
                catch (UltraStarSongNotValidException) {
                    continue;
                }

                var songListViewItem = new SongListViewItem(song);
                songListViewItem.ToolTipText = songFile;
                songListViewItem.SubItems.Add(song.Artist);
                songListView.Items.Add(songListViewItem);

                songsFound++;
            }

            MessageBox.Show(string.Format(Resources.songListInitializationDoneMessage, songsFound),
                Resources.songListInitializationDoneCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetSongDetailEnabled(bool enabled) {
            songInfoGroupBox.Enabled = enabled;
            songSettingsGroupBox.Enabled = enabled;
            songFilesGroupBox.Enabled = enabled;
            textTabControl.Enabled = enabled;
        }

        private void UpdateSongDetailUi(bool enableDetails = true) {
            titleTextBox.Text = _selectedSong.Title;
            artistTextBox.Text = _selectedSong.Artist;
            genreTextBox.Text = _selectedSong.Genre;
            yearTextBox.Text = _selectedSong.Year.ToString();
            languageTextBox.Text = _selectedSong.Language;
            editionTextBox.Text = _selectedSong.Edition;

            bpmNumericUpDown.Value = _selectedSong.BPM;
            gapNumericUpDown.Value = _selectedSong.Gap;
            videoGapNumericUpDown.Value = _selectedSong.VideoGap;
            duetCheckBox.Checked = _selectedSong.IsDuet;
            duetSinger1TextBox.Text = _selectedSong.DuetSingerP1;
            duetSinger2TextBox.Text = _selectedSong.DuetSingerP2;

            mp3TextBox.Text = _selectedSong.MP3;
            mp3PlayButton.Enabled = !string.IsNullOrEmpty(_selectedSong.MP3);
            videoTextBox.Text = _selectedSong.Video;
            videoPlayButton.Enabled = !string.IsNullOrEmpty(_selectedSong.Video);


            coverPictureBox.Image = _selectedSong.Cover != null
                ? new Bitmap(_selectedSong.GetCoverPath())
                : _defaultCoverImage;

            player1TextBox.Text = _selectedSong.SongText[0];
            player2TextBox.Text = _selectedSong.SongText[1];

            duetSinger1Label.Enabled = _selectedSong.IsDuet;
            duetSinger1TextBox.Enabled = _selectedSong.IsDuet;
            duetSinger2Label.Enabled = _selectedSong.IsDuet;
            duetSinger2TextBox.Enabled = _selectedSong.IsDuet;
            player2TextTab.Enabled = _selectedSong.IsDuet;

            SetSongDetailEnabled(enableDetails);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (string.IsNullOrEmpty(config.UsdPath)) {
                ConfigService.FindUsdFolder();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (!string.IsNullOrEmpty(config.UsdPath)) {
                InitSongListView();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            ConfigService.SerializeConfig();
        }

        private void songListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (songListView.SelectedItems.Count > 0) {
                _selectedSong = ((SongListViewItem) songListView.SelectedItems[0]).UltraStarSong;
                UpdateSongDetailUi();
            }
            else {
                SetSongDetailEnabled(false);
            }
        }

        private void duetCheckBox_CheckedChanged(object sender, EventArgs e) {
            _selectedSong.IsDuet = duetCheckBox.Checked;
            UpdateSongDetailUi();
        }

        private void mp3PlayButton_Click(object sender, EventArgs e) {
            if (_selectedSong != null) {
                Process.Start(_selectedSong.GetMP3Path());
            }
        }

        private void videoPlayButton_Click(object sender, EventArgs e) {
            if (_selectedSong != null) {
                Process.Start(_selectedSong.GetVideoPath());
            }
        }

        /**
         * Cancels the tab switching process if the tab is disabled.
         * Used for disabling the second players text tab if the song isn't a duet.
         */
        private void textTabControl_Selecting(object sender, TabControlCancelEventArgs e) {
            if (!e.TabPage.Enabled) {
                e.Cancel = true;
            }
        }
    }
}