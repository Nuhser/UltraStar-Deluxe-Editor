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
        private const string DEFAULT_IMAGE_LOCATION = "Assets/DefaultCover.jpg";

        private readonly SongListViewSorter _songListViewSorter;

        private UltraStarSong _selectedSong;

        public MainForm() {
            InitializeComponent();

            _songListViewSorter = new SongListViewSorter();
            songListView.ListViewItemSorter = _songListViewSorter;

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

        /// <summary>
        ///     Checks if any of the songs from the song list view ist dirty.
        /// </summary>
        /// <returns><c>true</c> if at least one song is dirty and <c>false</c> otherwise.</returns>
        private bool IsDirty() {
            return songListView.Items.Cast<SongListViewItem>()
                .Any(songListViewItem => songListViewItem.UltraStarSong.IsDirty);
        }

        /// <summary>
        ///     Initializes the song list view by first restoring any existing media backups and then clearing the list view and
        ///     populating it with all the .txt-files from the song directories. Refreshes the UI afterwards.<br />
        ///     Shows a message with the number of playable and unplayable songs found when done.<br />
        ///     <b>This deletes any unsaved changes from the songs.</b>
        /// </summary>
        /// <seealso cref="reloadSongsToolStripMenuItem_Click" />
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
                else {
                    songsFound++;
                }

                var songListViewItem = new SongListViewItem(song);
                songListViewItem.SubItems.Add(song.Artist);
                songListViewItem.SubItems.Add(song.IsValid() ? "\u2714" : "\u274C");
                songListViewItem.SubItems.Add(song.GetSongFileName());
                songListViewItem.ToolTipText = songFile;

                songListView.Items.Add(songListViewItem);
            }

            UpdateUi();

            MessageBox.Show(
                string.Format(Resources.songListInitializationDoneMessage, songsFound) + (invalidSongs.Any()
                    ? "\n" + string.Format(Resources.songListInitializationErrorsMessage, invalidSongs.Count)
                    : ""),
                Resources.songListInitializationDoneCaption,
                MessageBoxButtons.OK);
        }

        /// <summary>
        ///     This method adds a given <see cref="UltraStarSong" /> to the song list view, selects it and updates the UI.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> you want to add.</param>
        private void AddSongToSongListView(UltraStarSong song) {
            foreach (ListViewItem item in songListView.Items) {
                item.Selected = false;
            }

            var songListViewItem = new SongListViewItem(song);
            songListViewItem.SubItems.Add(song.Artist);
            songListViewItem.SubItems.Add(song.IsValid() ? "\u2714" : "\u274C");
            songListViewItem.SubItems.Add(song.GetSongFileName());
            songListViewItem.ToolTipText = song.FilePath;
            songListViewItem.Selected = true;

            songListView.Items.Add(songListViewItem);

            songListView.Select();
            songListViewItem.EnsureVisible();
            UpdateUi();
        }

        /// <summary>
        ///     This method removes a given item from the song list view.
        /// </summary>
        /// <param name="songListViewItem">The <see cref="ListViewItem" /> you want to remove.</param>
        private void RemoveSongFromSongListView(ListViewItem songListViewItem) {
            songListView.Items.Remove(songListViewItem);

            foreach (ListViewItem item in songListView.Items) {
                item.Selected = false;
            }

            songListView.Select();
            UpdateUi();
        }

        /// <summary>
        ///     Enables or disables the three <see cref="GroupBox" /> objects and the <see cref="TabControl" /> on the right side
        ///     of the <see cref="MainForm" />.
        /// </summary>
        /// <param name="enabled">Defines if the controls should be enabled or disabled.</param>
        private void SetSongDetailUiEnabled(bool enabled) {
            songInfoGroupBox.Enabled = enabled;
            songSettingsGroupBox.Enabled = enabled;
            songFilesGroupBox.Enabled = enabled;
            textTabControl.Enabled = enabled;
        }

        /// <summary>
        ///     This method either shows the properties of the currently selected song or resets the values of the controls on the
        ///     right side of the editor depending on if <see cref="_selectedSong" /> holds a value or is <c>null</c>. Furthermore,
        ///     it enables or disables multiple buttons and menu items depending on the same condition as well as the media files
        ///     assigned to the song.
        /// </summary>
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
            deleteSongToolStripMenuItem.Enabled = songSelected;
            coverToolStripMenuItem.Enabled = songSelected;
            openCoverToolStripMenuItem.Enabled = songSelected && _selectedSong.HasCover();
            chooseCoverImageToolStripMenuItem.Enabled = songSelected;
            downloadCoverFromURLToolStripMenuItem.Enabled = songSelected;
            deleteCoverToolStripMenuItem.Enabled = songSelected && _selectedSong.HasCover();
            mp3ToolStripMenuItem.Enabled = songSelected;
            openMp3ToolStripMenuItem.Enabled = songSelected && _selectedSong.HasMp3();
            chooseMp3FileToolStripMenuItem.Enabled = songSelected;
            deleteMp3ToolStripMenuItem.Enabled = songSelected && _selectedSong.HasMp3();
            videoToolStripMenuItem.Enabled = songSelected;
            openVideoToolStripMenuItem.Enabled = songSelected && _selectedSong.HasVideo();
            chooseVideoToolStripMenuItem.Enabled = songSelected;
            deleteVideoToolStripMenuItem.Enabled = songSelected && _selectedSong.HasVideo();
            webSearchToolStripMenuItem.Enabled = songSelected;
            exportSongTxtToolStripMenuItem.Enabled = songSelected;

            UpdateFormTitle();
            SetSongDetailUiEnabled(songSelected);
        }

        /// <summary>
        ///     This method adds a asterisk to the end end of the forms title and enables the menu item for saving all dirty songs
        ///     if at least one song is dirty. Otherwise it resets the title and disables the menu item.
        /// </summary>
        /// <seealso cref="IsDirty" />
        private void UpdateFormTitle() {
            var isDirty = IsDirty();
            Text = FORM_TITLE + (isDirty ? " *" : "");
            saveAllToolStripMenuItem.Enabled = isDirty;
        }

        /// <summary>
        ///     This method takes an <see cref="UltraStarSong" />, searches for its corresponding <see cref="SongListViewItem" />
        ///     and updates its
        ///     title, artist, playability and file name in the song list view. It will also change if the song is shown as dirty
        ///     or not.
        /// </summary>
        /// <param name="song">The song you want to update.</param>
        /// <param name="setDirty">Whether the song should be shown as dirty or not.</param>
        /// <seealso cref="UpdateSongListItem(UltraStarDeluxeEditor.Utility.SongListViewItem,bool)" />
        private void UpdateSongListItem(UltraStarSong song, bool setDirty) {
            foreach (SongListViewItem listViewItem in songListView.Items) {
                if (listViewItem.UltraStarSong == song) {
                    UpdateSongListItem(listViewItem, setDirty);
                    break;
                }
            }
        }

        /// <summary>
        ///     This method takes a <see cref="SongListViewItem" /> and updates its title, artist, playability and file name in the
        ///     song list view. It will also change if the song is shown as dirty or not.
        /// </summary>
        /// <param name="songListViewItem">The song list view item you want to update.</param>
        /// <param name="setDirty">Whether the song should be shown as dirty or not.</param>
        /// <seealso cref="UpdateSongListItem(UltraStarDeluxeEditor.UltraStar.UltraStarSong,bool)" />
        private void UpdateSongListItem(SongListViewItem songListViewItem, bool setDirty) {
            var song = songListViewItem.UltraStarSong;

            songListViewItem.Text = song.Title;
            songListViewItem.SubItems[1].Text = song.Artist;
            songListViewItem.SubItems[2].Text = song.IsValid() ? "\u2714" : "\u274C";
            songListViewItem.SubItems[3].Text = song.GetSongFileName();
            songListViewItem.ToolTipText = song.FilePath;

            songListViewItem.SetDirty(setDirty);
        }

        /// <summary>
        ///     This method takes the property values from the control objects and copies them to a given song.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> you want to update with the UI.</param>
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

        /// <summary>
        ///     This method takes a song, saves it.
        /// </summary>
        /// <param name="song">The <see cref="UltraStarSong" /> you want to save.</param>
        /// <seealso cref="UltraStarSongService.SaveSongToFile" />
        private void SaveSongFile(UltraStarSong song) {
            if (UltraStarSongService.SaveSongToFile(song)) {
                UpdateSongListItem(song, false);
            }
            else {
                MessageBox.Show(
                    string.Format(Resources.saveSongErrorMessage,
                        song != null && song.HasTitle() ? " \"" + song.Title + "\"" : ""),
                    Resources.errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Saves the selected song from the song list view and updates the UI afterwards.<br />
        ///     Shows a warning if the song isn't playable at the moment.
        /// </summary>
        /// <seealso cref="UltraStarSongService.SaveSongToFile" />
        private void SaveSelectedSongFile() {
            if (_selectedSong != null && !_selectedSong.IsValid() &&
                MessageBox.Show(Resources.songNotPlayableMessage, Resources.songNotPlayableCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                return;
            }

            SaveSongFile(_selectedSong);
            UpdateUi();
        }

        /// <summary>
        ///     Saves all dirty songs from the song list view and updates the UI afterwards.<br />
        ///     Shows a warning if at least one of the songs isn't playable.
        /// </summary>
        /// <seealso cref="UltraStarSongService.SaveSongToFile" />
        private void SaveAllSongFiles() {
            if (songListView.Items.Cast<SongListViewItem>().Any(item => !item.UltraStarSong.IsValid()) &&
                MessageBox.Show(
                    Resources.songsNotPlayableMessage, Resources.songNotPlayableCaption, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes) {
                return;
            }

            foreach (SongListViewItem listViewItem in songListView.Items) {
                if (listViewItem.UltraStarSong.IsDirty) {
                    SaveSongFile(listViewItem.UltraStarSong);
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

            songListView.ContextMenuStrip.Enabled = songListView.SelectedItems.Count > 0;

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
                            songListView.SelectedItems[0].SubItems[2].Text = song.IsValid() ? "\u2714" : "\u274C";
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
            openFileDialog.Filter = Resources.audioFileFilter;
            openFileDialog.Title = Resources.mp3SelectFileCaption;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                if (UltraStarSongService.ChangeMp3FromFile(_selectedSong, openFileDialog.FileName)) {
                    UpdateSongListItem(_selectedSong, true);
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
                    UpdateSongListItem(_selectedSong, true);
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
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog.Filter = Resources.textFileFilter;
            openFileDialog.Title = Resources.txtSelectFileCaption;

            if (openFileDialog.ShowDialog() != DialogResult.OK) {
                return;
            }

            var newSong = UltraStarSongService.LoadSongFromFile(openFileDialog.FileName);
            var newSongForm = new NewSongToolForm(newSong.Title, newSong.Artist);

            if (newSongForm.ShowDialog() != DialogResult.OK) {
                return;
            }

            newSong.Title = newSongForm.Title;
            newSong.Artist = newSongForm.Artist;
            newSong.FilePath = UltraStarSongService.FindFilePathForNewSong(newSongForm.Title,
                newSongForm.Artist, newSongForm.SongDirectory);

            if (!UltraStarSongService.SaveSongToFile(newSong)) {
                MessageBox.Show(
                    string.Format(Resources.newSongErrorWhileCreationMessage, newSongForm.Title,
                        newSongForm.Artist, newSongForm.SongDirectory), Resources.errorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            AddSongToSongListView(newSong);
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

        private void songListView_ColumnClick(object sender, ColumnClickEventArgs e) {
            if (e.Column == _songListViewSorter.ColumnToSort) {
                _songListViewSorter.SortOrder = _songListViewSorter.SortOrder == SortOrder.Ascending
                    ? SortOrder.Descending
                    : SortOrder.Ascending;
            }
            else {
                _songListViewSorter.ColumnToSort = e.Column;
                _songListViewSorter.SortOrder = SortOrder.Ascending;
            }

            songListView.Sort();
        }

        private void newSongToolStripMenuItem_Click(object sender, EventArgs e) {
            using (var newSongForm = new NewSongToolForm()) {
                if (newSongForm.ShowDialog() == DialogResult.OK) {
                    var title = newSongForm.Title;
                    var artist = newSongForm.Artist;
                    var songDirectory = newSongForm.SongDirectory;

                    var newSong = UltraStarSongService.CreateNewSong(title, artist, songDirectory);
                    if (newSong == null) {
                        MessageBox.Show(
                            string.Format(Resources.newSongErrorWhileCreationMessage, title, artist, songDirectory),
                            Resources.errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    AddSongToSongListView(newSong);
                }
            }
        }

        private void deleteSongToolStripMenuItem_Click(object sender, EventArgs e) {
            if (_selectedSong == null) {
                return;
            }

            if (MessageBox.Show(
                    string.Format(Resources.deleteSongMessage, _selectedSong.HasTitle() ? _selectedSong.Title : "---"),
                    Resources.deleteSongCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                return;
            }

            UltraStarSongService.DeleteSong(_selectedSong);
            RemoveSongFromSongListView(songListView.SelectedItems[0]);
        }

        private void songListView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Delete) {
                deleteSongToolStripMenuItem_Click(sender, e);
            }
        }

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(@"https://github.com/Nuhser/UltraStar-Deluxe-Editor/wiki");
        }

        private void forumToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(@"https://github.com/Nuhser/UltraStar-Deluxe-Editor/discussions");
        }

        private void releasesToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(@"https://github.com/Nuhser/UltraStar-Deluxe-Editor/releases");
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(@"https://github.com/Nuhser/UltraStar-Deluxe-Editor/issues");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(
                string.Format(Resources.aboutMessage, ConfigService.VERSION),
                Resources.aboutCaption, MessageBoxButtons.OK);
        }
    }
}