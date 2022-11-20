using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using UltraStarDeluxeEditor.Configuration;
using UltraStarDeluxeEditor.Properties;
using UltraStarDeluxeEditor.UltraStar;
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
            gapNumericUpDown.Minimum = decimal.MinValue;
            gapNumericUpDown.Maximum = decimal.MaxValue;
            videoGapNumericUpDown.Minimum = decimal.MinValue;
            videoGapNumericUpDown.Maximum = decimal.MaxValue;

            songText1MissingPictureBox.BringToFront();
            songText2MissingPictureBox.BringToFront();

            // add tool tips
            toolTip.SetToolTip(coverDownloadButton, Resources.coverDownloadFromUrl);
            toolTip.SetToolTip(coverDeleteButton, Resources.fileDeleteCaption);
            toolTip.SetToolTip(titleMissingPictureBox, Resources.titleMissingWarningIcon);
            toolTip.SetToolTip(artistMissingPictureBox, Resources.artistMissingWarningIcon);
            toolTip.SetToolTip(mp3MissingPictureBox, Resources.mp3FileMissingWarningIcon);
            toolTip.SetToolTip(mp3NotFoundPictureBox, Resources.mp3FileNotExistsWarningIcon);
            toolTip.SetToolTip(videoNotFoundPictureBox, Resources.videoFileNotExistsWarningIcon);
            toolTip.SetToolTip(songText1MissingPictureBox, Resources.player1TextMissingWarningIcon);
            toolTip.SetToolTip(songText2MissingPictureBox, Resources.player2TextMissingWarningIcon);

            SetSongDetailUiEnabled(false);
        }

        private bool IsDirty() {
            return songListView.Items.Cast<SongListViewItem>()
                .Any(songListViewItem => songListViewItem.UltraStarSong.IsDirty);
        }

        private void InitSongListView() {
            // restore backups if there are dirty songs
            if (IsDirty()) {
                foreach (SongListViewItem listViewItem in songListView.Items) {
                    UltraStarSongService.RestoreAllBackups(listViewItem.UltraStarSong);
                }
            }

            songListView.Items.Clear();
            _selectedSong = null;

            var songsFound = 0;
            var invalidSongs = new List<string>();

            var songDirectories = ConfigService.GetSongDirectories();
            foreach (var songFile in songDirectories.Where(Directory.Exists)
                         .SelectMany(songDirectory => Directory.GetFiles(songDirectory, "*.txt"))) {
                var song = UltraStarSongService.LoadSongFromFile(songFile);

                if (!song.IsValid()) {
                    invalidSongs.Add(songFile);
                }

                var songListViewItem = new SongListViewItem(song);
                songListViewItem.SetInvalid(!song.IsValid());
                songListViewItem.SubItems.Add(song.Artist);
                songListViewItem.SubItems.Add(song.GetSongFileName());
                songListViewItem.ToolTipText = songFile;

                songListView.Items.Add(songListViewItem);

                songsFound++;
            }

            UpdateUi();

            MessageBox.Show(
                string.Format(Resources.songListInitializationDoneMessage, songsFound) + (invalidSongs.Any()
                    ? "\n" + string.Format(Resources.songListInitializationErrorsMessage, invalidSongs.Count)
                    : ""),
                Resources.songListInitializationDoneCaption,
                MessageBoxButtons.OK);
        }

        private void SetSongDetailUiEnabled(bool enabled) {
            songInfoGroupBox.Enabled = enabled;
            songSettingsGroupBox.Enabled = enabled;
            songFilesGroupBox.Enabled = enabled;
            textTabControl.Enabled = enabled;
        }

        private void UpdateUi() {
            var songSelected = _selectedSong != null;

            // fill/clear song details
            if (songSelected) {
                titleTextBox.Text = _selectedSong.Title;
                artistTextBox.Text = _selectedSong.Artist;
                genreTextBox.Text = _selectedSong.Genre;
                yearTextBox.Text = _selectedSong.Year;
                languageTextBox.Text = _selectedSong.Language;
                editionTextBox.Text = _selectedSong.Edition;

                bpmNumericUpDown.Value = _selectedSong.Bpm;
                gapNumericUpDown.Value = _selectedSong.Gap;
                videoGapNumericUpDown.Value = _selectedSong.VideoGap;
                duetCheckBox.Checked = _selectedSong.IsDuet;
                duetSinger1TextBox.Text = _selectedSong.DuetSingerP1;
                duetSinger2TextBox.Text = _selectedSong.DuetSingerP2;

                mp3TextBox.Text = _selectedSong.Mp3;
                videoTextBox.Text = _selectedSong.Video;

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
            }
            else {
                titleTextBox.Text = "";
                artistTextBox.Text = "";
                genreTextBox.Text = "";
                yearTextBox.Text = "";
                languageTextBox.Text = "";
                editionTextBox.Text = "";

                bpmNumericUpDown.Value = decimal.One;
                gapNumericUpDown.Value = decimal.Zero;
                videoGapNumericUpDown.Value = decimal.Zero;
                duetCheckBox.Checked = false;
                duetSinger1TextBox.Text = "";
                duetSinger2TextBox.Text = "";

                mp3TextBox.Text = "";
                videoTextBox.Text = "";
                coverPictureBox.ImageLocation = DEFAULT_IMAGE_LOCATION;
                toolTip.SetToolTip(coverPictureBox, null);

                player1TextBox.Text = "";
                player2TextBox.Text = "";
            }

            // show/hide error icons
            titleMissingPictureBox.Visible = songSelected && !_selectedSong.HasTitle();
            artistMissingPictureBox.Visible = songSelected && !_selectedSong.HasArtist();
            mp3MissingPictureBox.Visible = songSelected && !_selectedSong.HasMp3();
            mp3NotFoundPictureBox.Visible =
                songSelected && _selectedSong.HasMp3() && !File.Exists(_selectedSong.GetMp3Path());

            videoNotFoundPictureBox.Visible =
                songSelected && _selectedSong.HasVideo() && !File.Exists(_selectedSong.GetVideoPath());

            songText1MissingPictureBox.Visible = songSelected && !_selectedSong.HasPlayer1Text();
            songText2MissingPictureBox.Visible = songSelected && !_selectedSong.HasPlayer2Text();

            // enable/disable buttons
            coverDeleteButton.Enabled = songSelected && _selectedSong.HasCover();
            mp3PlayButton.Enabled = songSelected && _selectedSong.HasMp3() && File.Exists(_selectedSong.GetMp3Path());
            mp3EditButton.Enabled = songSelected;
            videoEditButton.Enabled = songSelected;
            videoDeleteButton.Enabled = songSelected && _selectedSong.HasVideo();
            videoPlayButton.Enabled =
                songSelected && _selectedSong.HasVideo() && File.Exists(_selectedSong.GetVideoPath());

            // enable/disable menu items
            saveToolStripMenuItem.Enabled = songSelected && _selectedSong.IsDirty;
            openSongTxtToolStripMenuItem.Enabled = songSelected;
            openDirectoryToolStripMenuItem.Enabled = songSelected;
            reloadSongToolStripMenuItem.Enabled = songSelected;
            coverToolStripMenuItem.Enabled = songSelected;
            openCoverToolStripMenuItem.Enabled = songSelected && _selectedSong.HasCover();
            chooseCoverImageToolStripMenuItem.Enabled = songSelected;
            downloadCoverFromURLToolStripMenuItem.Enabled = songSelected;
            deleteCoverToolStripMenuItem.Enabled = songSelected && _selectedSong.HasCover();
            mp3ToolStripMenuItem.Enabled = songSelected;
            openMp3ToolStripMenuItem.Enabled = songSelected && _selectedSong.HasMp3();
            chooseMp3FileToolStripMenuItem.Enabled = songSelected;
            videoToolStripMenuItem.Enabled = songSelected;
            openVideoToolStripMenuItem.Enabled = songSelected && _selectedSong.HasVideo();
            chooseVideoToolStripMenuItem.Enabled = songSelected;
            deleteVideoToolStripMenuItem.Enabled = songSelected && _selectedSong.HasVideo();
            webSearchToolStripMenuItem.Enabled = songSelected;
            exportSongTxtToolStripMenuItem.Enabled = songSelected;

            UpdateFormTitle();
            SetSongDetailUiEnabled(songSelected);
        }

        private void UpdateFormTitle() {
            var isDirty = IsDirty();
            Text = FORM_TITLE + (isDirty ? " *" : "");
            saveAllToolStripMenuItem.Enabled = isDirty;
        }

        private void UpdateSongListItem(UltraStarSong song, bool setDirty) {
            foreach (SongListViewItem listViewItem in songListView.Items) {
                if (listViewItem.UltraStarSong == song) {
                    UpdateSongListItem(listViewItem, setDirty);
                    break;
                }
            }
        }

        private void UpdateSongListItem(SongListViewItem songListViewItem, bool setDirty) {
            var song = songListViewItem.UltraStarSong;

            songListViewItem.Text = song.Title;
            songListViewItem.SubItems[1].Text = song.Artist;
            songListViewItem.SubItems[2].Text = song.GetSongFileName();
            songListViewItem.ToolTipText = song.FilePath;

            songListViewItem.SetInvalid(!song.IsValid());
            songListViewItem.SetDirty(setDirty);
        }

        private void WriteDetailUiToSong(UltraStarSong song) {
            song.Title = titleTextBox.Text;
            song.Artist = artistTextBox.Text;
            song.Genre = genreTextBox.Text;
            song.Year = yearTextBox.Text;
            song.Language = languageTextBox.Text;
            song.Edition = editionTextBox.Text;

            song.Bpm = bpmNumericUpDown.Value;
            song.Gap = gapNumericUpDown.Value;
            song.VideoGap = videoGapNumericUpDown.Value;
            song.IsDuet = duetCheckBox.Checked;
            song.DuetSingerP1 = duetSinger1TextBox.Text;
            song.DuetSingerP2 = duetSinger2TextBox.Text;

            song.Mp3 = mp3TextBox.Text;
            song.Video = videoTextBox.Text;

            song.Cover = coverPictureBox.ImageLocation != DEFAULT_IMAGE_LOCATION
                ? Path.GetFileName(coverPictureBox.ImageLocation)
                : null;

            song.SongText = new Tuple<string, string>(player1TextBox.Text.Trim(), player2TextBox.Text.Trim());
        }

        private void SaveSongFile(UltraStarSong song, bool updateUi = true) {
            if (UltraStarSongService.SaveSongToFile(song)) {
                UpdateSongListItem(song, false);

                if (updateUi) {
                    UpdateUi();
                }
            }
            else {
                MessageBox.Show(
                    string.Format(Resources.saveSongErrorMessage,
                        song != null && song.HasTitle() ? " \"" + song.Title + "\"" : ""),
                    Resources.errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSelectedSongFile() {
            if (_selectedSong != null && !_selectedSong.IsValid() &&
                MessageBox.Show(Resources.songNotPlayableMessage, Resources.songNotPlayableCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                return;
            }

            SaveSongFile(_selectedSong);
        }

        private void SaveAllSongFiles() {
            if (songListView.Items.Cast<SongListViewItem>().Any(item => !item.UltraStarSong.IsValid()) &&
                MessageBox.Show(
                    Resources.songsNotPlayableMessage, Resources.songNotPlayableCaption, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes) {
                return;
            }

            foreach (SongListViewItem listViewItem in songListView.Items) {
                if (listViewItem.UltraStarSong.IsDirty) {
                    SaveSongFile(listViewItem.UltraStarSong, false);
                }
            }

            UpdateUi();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (!config.IsValidUsdPath()) {
                if (config.HasUsdPath()) {
                    MessageBox.Show(Resources.usdPathNotValidMessage, Resources.usdPathNotValidCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show(Resources.usdPathNotConfiguredMessage, Resources.usdPathNotConfiguredCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ConfigService.FindUsdFolder();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            var config = ConfigService.Config;

            if (config.IsValidUsdPath()) {
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

                // restore backups for all songs
                foreach (SongListViewItem listViewItem in songListView.Items) {
                    UltraStarSongService.RestoreAllBackups(listViewItem.UltraStarSong);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        ///     Marks a song as dirty if there were changes done to it by the user, saves the changes to the currently selected
        ///     <see cref="UltraStarSong" /> and updates this forms title if necessary.
        /// </summary>
        /// <seealso cref="WriteDetailUiToSong" />
        /// <seealso cref="UpdateFormTitle" />
        private void detailControl_ValueChanged(object sender, EventArgs e) {
            // check if changes were made by user and return if not
            if ((sender is TextBox textBox && !textBox.ContainsFocus) ||
                (sender is NumericUpDown numericUpDown && !numericUpDown.ContainsFocus) ||
                (sender is CheckBox checkBox && !checkBox.ContainsFocus)) {
                return;
            }

            if (_selectedSong != null) {
                if (!_selectedSong.IsDirty) {
                    saveToolStripMenuItem.Enabled = true;
                }

                // save values before change to reduce UI updates
                var oldDirtyValue = _selectedSong.IsDirty;
                var oldValidValue = _selectedSong.IsValid();
                var oldTitle = _selectedSong.Title;
                var oldArtist = _selectedSong.Artist;

                WriteDetailUiToSong(_selectedSong);

                if (oldDirtyValue != true || oldValidValue != _selectedSong.IsValid() ||
                    oldTitle != _selectedSong.Title || oldArtist != _selectedSong.Artist) {
                    UpdateSongListItem(_selectedSong, true);
                }

                if (oldDirtyValue != true) {
                    UpdateFormTitle();
                }

                // show/hide error icons
                titleMissingPictureBox.Visible = !_selectedSong.HasTitle();
                artistMissingPictureBox.Visible = !_selectedSong.HasArtist();
                mp3MissingPictureBox.Visible = !_selectedSong.HasMp3();
                mp3NotFoundPictureBox.Visible = _selectedSong.HasMp3() && !File.Exists(_selectedSong.GetMp3Path());
                videoNotFoundPictureBox.Visible =
                    _selectedSong.HasVideo() && !File.Exists(_selectedSong.GetVideoPath());

                songText1MissingPictureBox.Visible = !_selectedSong.HasPlayer1Text();
                songText2MissingPictureBox.Visible = !_selectedSong.HasPlayer2Text();
            }
        }

        private void duetCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (_selectedSong != null) {
                _selectedSong.IsDuet = duetCheckBox.Checked;
            }

            detailControl_ValueChanged(sender, e);
            UpdateUi();
        }

        /// <summary>
        ///     Cancels the tab switching process if the tab is disabled.<br />
        ///     Used for disabling the second players text tab if the song isn't a duet.
        /// </summary>
        private void textTabControl_Selecting(object sender, TabControlCancelEventArgs e) {
            if (!e.TabPage.Enabled) {
                e.Cancel = true;
            }
        }

        private void songListView_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedSong = songListView.SelectedItems.Count > 0
                ? ((SongListViewItem) songListView.SelectedItems[0]).UltraStarSong
                : null;

            UpdateUi();
        }

        private void mp3PlayButton_Click(object sender, EventArgs e) {
            UltraStarSongService.OpenMp3(_selectedSong);
        }

        private void videoPlayButton_Click(object sender, EventArgs e) {
            UltraStarSongService.OpenVideo(_selectedSong);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveSelectedSongFile();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e) {
            if (IsDirty()) {
                SaveAllSongFiles();
            }
        }

        private void reloadSongToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(
                    Resources.reloadSongMessage,
                    Resources.reloadSongCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                // restore backups
                UltraStarSongService.RestoreAllBackups(_selectedSong);

                bool loop;
                do {
                    try {
                        UltraStarSong song;
                        if ((song = UltraStarSongService.LoadSongFromFile(_selectedSong)) != null) {
                            _selectedSong = song;
                            ((SongListViewItem) songListView.SelectedItems[0]).UltraStarSong = _selectedSong;
                            ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(false);
                            ((SongListViewItem) songListView.SelectedItems[0]).SetInvalid(!_selectedSong.IsValid());
                            saveToolStripMenuItem.Enabled = false;
                            UpdateFormTitle();
                            UpdateUi();

                            MessageBox.Show(string.Format(Resources.reloadSongSuccessMessage, _selectedSong.Title),
                                Resources.successCaption);

                            break;
                        }

                        loop = MessageBox.Show(
                                   string.Format(Resources.reloadSongErrorMessage,
                                       _selectedSong != null && _selectedSong.HasTitle()
                                           ? " \"" + _selectedSong.Title + "\""
                                           : ""),
                                   Resources.errorCaption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) ==
                               DialogResult.Retry;
                    }
                    catch (FileNotFoundException) {
                        loop = MessageBox.Show(
                                   string.Format(Resources.reloadSongFileNotFoundErrorMessage,
                                       _selectedSong.HasFilePath() ? " (" + _selectedSong.FilePath + ")" : ""),
                                   Resources.errorCaption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) ==
                               DialogResult.Retry;
                    }
                } while (loop);
            }
        }

        private void reloadSongsToolStripMenuItem_Click(object sender, EventArgs e) {
            var config = ConfigService.Config;
            if (!config.IsValidUsdPath()) {
                if (config.HasUsdPath()) {
                    MessageBox.Show(Resources.usdPathNotValidMessage, Resources.usdPathNotValidCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show(Resources.usdPathNotConfiguredMessage, Resources.usdPathNotConfiguredCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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

                UpdateUi();
                MessageBox.Show(Resources.coverDownloadSuccessMessage, Resources.successCaption,
                    MessageBoxButtons.OK);
            }
        }

        private void coverEditButton_Click(object sender, EventArgs e) {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = Resources.imageFileFilter;
            openFileDialog.Title = Resources.coverSelectFileCaption;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                if (UltraStarSongService.ChangeCoverFromFile(_selectedSong, openFileDialog.FileName)) {
                    if (!_selectedSong.IsDirty) {
                        ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                    }

                    UpdateUi();
                }
            }
        }

        private void coverDeleteButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show(
                    Resources.coverDeleteMessage,
                    Resources.fileDeleteCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes) {
                if (UltraStarSongService.DeleteCoverImage(_selectedSong)) {
                    if (!_selectedSong.IsDirty) {
                        ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                    }

                    UpdateUi();
                }
                else {
                    MessageBox.Show(Resources.fileDeleteErrorMessage, Resources.fileDeleteErrorCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void coverPictureBox_DoubleClick(object sender, EventArgs e) {
            UltraStarSongService.OpenCoverImage(_selectedSong);
        }

        private void mp3EditButton_Click(object sender, EventArgs e) {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            openFileDialog.Filter = @"MP3|*.mp3";
            openFileDialog.Title = Resources.mp3SelectFileCaption;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                if (UltraStarSongService.ChangeMp3FromFile(_selectedSong, openFileDialog.FileName)) {
                    if (!_selectedSong.IsDirty) {
                        ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                    }

                    UpdateUi();
                }
            }
        }

        private void mp3DeleteButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show(
                    Resources.mp3DeleteMessage, Resources.fileDeleteCaption, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) ==
                DialogResult.Yes) {
                if (UltraStarSongService.DeleteMp3File(_selectedSong)) {
                    if (!_selectedSong.IsDirty) {
                        ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                    }

                    UpdateUi();
                }
                else {
                    MessageBox.Show(Resources.fileDeleteErrorMessage, Resources.fileDeleteErrorCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void videoEditButton_Click(object sender, EventArgs e) {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            openFileDialog.Filter = @"MP4|*.mp4";
            openFileDialog.Title = Resources.mp3SelectFileCaption;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                if (UltraStarSongService.ChangeVideoFromFile(_selectedSong, openFileDialog.FileName)) {
                    if (!_selectedSong.IsDirty) {
                        ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                    }

                    UpdateUi();
                }
            }
        }

        private void videoDeleteButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show(
                    Resources.videoDeleteMessage, Resources.fileDeleteCaption, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) ==
                DialogResult.Yes) {
                if (UltraStarSongService.DeleteVideoFile(_selectedSong)) {
                    if (!_selectedSong.IsDirty) {
                        ((SongListViewItem) songListView.SelectedItems[0]).SetDirty(true);
                    }

                    UpdateUi();
                }
                else {
                    MessageBox.Show(Resources.fileDeleteErrorMessage, Resources.fileDeleteErrorCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openSongTxtToolStripMenuItem_Click(object sender, EventArgs e) {
            UltraStarSongService.OpenTxt(_selectedSong);
        }

        private void googleSearchToolStripMenuItem_Click(object sender, EventArgs e) {
            UltraStarSongService.SearchWithGoogle(_selectedSong);
        }

        private void discogsSearchToolStripMenuItem_Click(object sender, EventArgs e) {
            UltraStarSongService.SearchOnDiscogs(_selectedSong);
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e) {
            UltraStarSongService.OpenSongDirectory(_selectedSong);
        }

        private void startUltraStarDeluxeToolStripMenuItem_Click(object sender, EventArgs e) {
            var config = ConfigService.Config;
            if (config.IsValidUsdPath()) {
                Process.Start(Path.Combine(config.UsdPath, Config.USD_EXE_NAME));
            }
        }

        private void importSongTxtToolStripMenuItem_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void exportSongTxtToolStripMenuItem_Click(object sender, EventArgs e) {
            // ask to save song if dirty
            if (_selectedSong != null && _selectedSong.IsDirty) {
                if (MessageBox.Show(Resources.exportSongSaveFirstMessage, Resources.saveSongCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    SaveSelectedSongFile();
                }
                else {
                    return;
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = Resources.textFileFilter;
            saveFileDialog.Title = Resources.exportSongTitle;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                UltraStarSongService.ExportSong(_selectedSong, saveFileDialog.FileName);
            }
        }

        private void openUsdbAnimuxDeToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(@"http://usdb.animux.de/");
        }
    }
}