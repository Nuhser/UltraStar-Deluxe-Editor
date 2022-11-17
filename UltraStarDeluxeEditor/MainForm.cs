using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using UltraStarDeluxeEditor.Config;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.UltraStarDeluxe;
using UltraStarDeluxeEditor.Utility;

namespace UltraStarDeluxeEditor {
    public partial class MainForm : Form {
        private const string FORM_TITLE = "UltraStar Deluxe Editor";
        private const string DEFAULT_IMAGE_LOCATION = "..\\..\\assets\\DefaultCover.jpg";

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

            // add tool tips
            toolTip.SetToolTip(coverDownloadButton, Resources.downloadCoverImageFromUrl);

            saveToolStripMenuItem.Enabled = false;
            saveAllToolStripMenuItem.Enabled = false;
            webSearchToolStripMenuItem.Enabled = false;

            SetSongDetailUiEnabled(false);
        }

        private bool IsDirty() {
            return songListView.Items.Cast<SongListViewItem>()
                .Any(songListViewItem => songListViewItem.UltraStarSong.IsDirty);
        }

        private void InitSongListView() {
            if (IsDirty()) {
                foreach (SongListViewItem listViewItem in songListView.Items) {
                    var song = listViewItem.UltraStarSong;
                    if (!string.IsNullOrWhiteSpace(song.OldCover)) {
                        File.Delete(song.GetCoverPath());
                        File.Move(song.OldCover + ".backup", song.OldCover);
                    }
                }
            }

            songListView.Items.Clear();
            _selectedSong = null;

            var songsFound = 0;

            var songDirectories = ConfigService.GetSongDirectories();
            foreach (var songFile in songDirectories.Where(songDirectory => Directory.Exists(songDirectory))
                         .SelectMany(songDirectory => Directory.GetFiles(songDirectory, "*.txt"))) {
                UltraStarSong song;


                try {
                    song = UltraStarSong.ParseSongFile(songFile);
                }
                catch (UltraStarSongNotValidException) {
                    continue;
                }

                var songListViewItem = new SongListViewItem(song);
                songListViewItem.SubItems.Add(song.Artist);
                songListViewItem.SubItems.Add(song.GetSongFileName());
                songListViewItem.ToolTipText = songFile;
                songListView.Items.Add(songListViewItem);

                songsFound++;
            }

            UpdateSongDetailUi();

            MessageBox.Show(string.Format(Resources.songListInitializationDoneMessage, songsFound),
                Resources.songListInitializationDoneCaption,
                MessageBoxButtons.OK);
        }

        private void SetSongDetailUiEnabled(bool enabled) {
            songInfoGroupBox.Enabled = enabled;
            songSettingsGroupBox.Enabled = enabled;
            songFilesGroupBox.Enabled = enabled;
            textTabControl.Enabled = enabled;
        }

        private void UpdateSongDetailUi() {
            if (_selectedSong != null) {
                titleTextBox.Text = _selectedSong.Title;
                artistTextBox.Text = _selectedSong.Artist;
                genreTextBox.Text = _selectedSong.Genre;
                yearTextBox.Text = _selectedSong.Year;
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

                coverPictureBox.ImageLocation = _selectedSong.Cover != null
                    ? _selectedSong.GetCoverPath()
                    : DEFAULT_IMAGE_LOCATION;

                toolTip.SetToolTip(coverPictureBox, _selectedSong.Cover);

                player1TextBox.Text = _selectedSong.SongText.Item1;
                player2TextBox.Text = _selectedSong.SongText.Item2;

                duetSinger1Label.Enabled = _selectedSong.IsDuet;
                duetSinger1TextBox.Enabled = _selectedSong.IsDuet;
                duetSinger2Label.Enabled = _selectedSong.IsDuet;
                duetSinger2TextBox.Enabled = _selectedSong.IsDuet;
                player2TextTab.Enabled = _selectedSong.IsDuet;

                if (_selectedSong.IsDirty) {
                    saveToolStripMenuItem.Enabled = true;
                }

                webSearchToolStripMenuItem.Enabled = true;
            }
            else {
                titleTextBox.Text = "";
                artistTextBox.Text = "";
                genreTextBox.Text = "";
                yearTextBox.Text = "";
                languageTextBox.Text = "";
                editionTextBox.Text = "";

                bpmNumericUpDown.Value = bpmNumericUpDown.Minimum;
                gapNumericUpDown.Value = gapNumericUpDown.Minimum;
                videoGapNumericUpDown.Value = videoGapNumericUpDown.Minimum;
                duetCheckBox.Checked = false;
                duetSinger1TextBox.Text = "";
                duetSinger2TextBox.Text = "";

                mp3TextBox.Text = "";
                videoTextBox.Text = "";
                coverPictureBox.ImageLocation = DEFAULT_IMAGE_LOCATION;

                player1TextBox.Text = "";
                player2TextBox.Text = "";

                saveToolStripMenuItem.Enabled = false;
                webSearchToolStripMenuItem.Enabled = false;
            }

            UpdateFormTitle();
            SetSongDetailUiEnabled(_selectedSong != null);
        }

        private void UpdateFormTitle() {
            var isDirty = IsDirty();
            Text = FORM_TITLE + (isDirty ? " *" : "");
            saveAllToolStripMenuItem.Enabled = isDirty;
        }

        public void WriteDetailUiToSong(UltraStarSong song) {
            song.Title = titleTextBox.Text;
            song.Artist = artistTextBox.Text;
            song.Genre = genreTextBox.Text;
            song.Year = yearTextBox.Text;
            song.Language = languageTextBox.Text;
            song.Edition = editionTextBox.Text;

            song.BPM = bpmNumericUpDown.Value;
            song.Gap = gapNumericUpDown.Value;
            song.VideoGap = videoGapNumericUpDown.Value;
            song.IsDuet = duetCheckBox.Checked;
            song.DuetSingerP1 = duetSinger1TextBox.Text;
            song.DuetSingerP2 = duetSinger2TextBox.Text;

            song.MP3 = mp3TextBox.Text;
            song.Video = videoTextBox.Text;

            song.Cover = coverPictureBox.ImageLocation != DEFAULT_IMAGE_LOCATION
                ? Path.GetFileName(coverPictureBox.ImageLocation)
                : null;

            song.SongText = new Tuple<string, string>(player1TextBox.Text.Trim(), player2TextBox.Text.Trim());
        }

        private void SaveSongFile(UltraStarSong song, bool updateUi = true) {
            song.SaveSongToFile();

            foreach (SongListViewItem listViewItem in songListView.Items) {
                if (listViewItem.UltraStarSong == song) {
                    listViewItem.SetDirty(false);
                    break;
                }
            }

            if (updateUi) {
                UpdateSongDetailUi();
            }
        }

        private void SaveSelectedSongFile() {
            if (_selectedSong != null) {
                SaveSongFile(_selectedSong);
            }
        }

        private void SaveAllSongFiles() {
            foreach (SongListViewItem listViewItem in songListView.Items) {
                if (listViewItem.UltraStarSong.IsDirty) {
                    SaveSongFile(listViewItem.UltraStarSong, false);
                }
            }

            UpdateSongDetailUi();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (string.IsNullOrEmpty(config.UsdPath) || !Directory.Exists(config.UsdPath)) {
                ConfigService.FindUsdFolder();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (!string.IsNullOrEmpty(config.UsdPath) && Directory.Exists(config.UsdPath)) {
                InitSongListView();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            ConfigService.SerializeConfig();

            if (IsDirty()) {
                var result =
                    MessageBox.Show(Resources.unsavedChangesMessage,
                        Resources.unsavedChangesCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result) {
                    case DialogResult.Yes:
                        SaveAllSongFiles();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }

                foreach (SongListViewItem listViewItem in songListView.Items) {
                    var song = listViewItem.UltraStarSong;
                    if (!string.IsNullOrWhiteSpace(song.OldCover)) {
                        File.Delete(song.GetCoverPath());
                        File.Move(song.OldCover + ".backup", song.OldCover);
                    }
                }
            }
        }

        /**
         * Marks a song as dirty if there were changes done to it by the user.
         */
        private void detailControl_ValueChanged(object sender, EventArgs e) {
            // check if changes were made by user and return if not
            if ((sender is TextBox textBox && !textBox.ContainsFocus) ||
                (sender is NumericUpDown numericUpDown && !numericUpDown.ContainsFocus) ||
                (sender is CheckBox checkBox && !checkBox.ContainsFocus)) {
                return;
            }

            if (_selectedSong != null) {
                WriteDetailUiToSong(_selectedSong);

                if (!_selectedSong.IsDirty) {
                    ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                    saveToolStripMenuItem.Enabled = true;
                    UpdateFormTitle();
                }
            }
        }

        private void songListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (songListView.SelectedItems.Count > 0) {
                _selectedSong = ((SongListViewItem) songListView.SelectedItems[0]).UltraStarSong;
                saveToolStripMenuItem.Enabled = _selectedSong.IsDirty;
                UpdateSongDetailUi();
            }
            else {
                SetSongDetailUiEnabled(false);
            }
        }

        private void duetCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (_selectedSong != null) {
                _selectedSong.IsDuet = duetCheckBox.Checked;
            }

            detailControl_ValueChanged(sender, e);
            UpdateSongDetailUi();
        }

        private void mp3PlayButton_Click(object sender, EventArgs e) {
            if (_selectedSong != null) {
                Process.Start(_selectedSong.GetMp3Path());
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveSelectedSongFile();
        }


        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e) {
            if (IsDirty()) {
                SaveAllSongFiles();
            }
        }

        private void reloadSongsToolStripMenuItem_Click(object sender, EventArgs e) {
            var config = ConfigService.Config;
            if (string.IsNullOrEmpty(config.UsdPath)) {
                ConfigService.FindUsdFolder();
            }

            if (MessageBox.Show(
                    Resources.reloadSongsMessage,
                    Resources.reloadSongsCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes) {
                InitSongListView();
            }
        }

        private void coverDownloadButton_Click(object sender, EventArgs e) {
            var newCoverUrl = Interaction.InputBox(Resources.coverDownloadUrlInputMessage, Resources.urlInputCaption);
            if (UltraStarSongService.ChangeCoverWithUrl(_selectedSong, newCoverUrl)) {
                if (!_selectedSong.IsDirty) {
                    ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                }

                UpdateSongDetailUi();
                MessageBox.Show(Resources.coverDownloadSuccessfulMessage, Resources.successCaption,
                    MessageBoxButtons.OK);
            }
        }

        private void coverPictureBox_DoubleClick(object sender, EventArgs e) {
            UltraStarSongService.OpenCoverImage(_selectedSong);
        }

        private void googleSearchToolStripMenuItem_Click(object sender, EventArgs e) {
            UltraStarSongService.SearchWithGoogle(_selectedSong);
        }

        private void discogsSearchToolStripMenuItem_Click(object sender, EventArgs e) {
            UltraStarSongService.SearchOnDiscogs(_selectedSong);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
    }
}