using System.ComponentModel;

namespace UltraStarDeluxeEditor {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSongTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.coverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseCoverImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadCoverFromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseMp3FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.webSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discogsSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startUltraStarDeluxeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openUsdbAnimuxDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSongTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSongTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songListView = new System.Windows.Forms.ListView();
            this.titleColumn = new System.Windows.Forms.ColumnHeader();
            this.artistColumn = new System.Windows.Forms.ColumnHeader();
            this.playableColumn = new System.Windows.Forms.ColumnHeader();
            this.fileColumn = new System.Windows.Forms.ColumnHeader();
            this.songListViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSongTxtContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadSongContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.webSearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSearchContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discogsSearchContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.coverDeleteButton = new System.Windows.Forms.Button();
            this.coverEditButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.editionTextBox = new System.Windows.Forms.TextBox();
            this.editionLabel = new System.Windows.Forms.Label();
            this.songInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.artistMissingPictureBox = new System.Windows.Forms.PictureBox();
            this.titleMissingPictureBox = new System.Windows.Forms.PictureBox();
            this.coverDownloadButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.songSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.duetCheckBox = new System.Windows.Forms.CheckBox();
            this.videoGapLabel = new System.Windows.Forms.Label();
            this.bpmLabel = new System.Windows.Forms.Label();
            this.gapLabel = new System.Windows.Forms.Label();
            this.duetSinger2TextBox = new System.Windows.Forms.TextBox();
            this.duetSinger1TextBox = new System.Windows.Forms.TextBox();
            this.videoGapNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bpmNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.duetSinger2Label = new System.Windows.Forms.Label();
            this.gapNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.duetSinger1Label = new System.Windows.Forms.Label();
            this.songFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.mp3MissingPictureBox = new System.Windows.Forms.PictureBox();
            this.videoNotFoundPictureBox = new System.Windows.Forms.PictureBox();
            this.mp3NotFoundPictureBox = new System.Windows.Forms.PictureBox();
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.mp3TextBox = new System.Windows.Forms.TextBox();
            this.videoEditButton = new System.Windows.Forms.Button();
            this.videoPlayButton = new System.Windows.Forms.Button();
            this.mp3PlayButton = new System.Windows.Forms.Button();
            this.mp3EditButton = new System.Windows.Forms.Button();
            this.mp3DeleteButton = new System.Windows.Forms.Button();
            this.videoDeleteButton = new System.Windows.Forms.Button();
            this.videoLabel = new System.Windows.Forms.Label();
            this.mp3Label = new System.Windows.Forms.Label();
            this.textTabControl = new System.Windows.Forms.TabControl();
            this.player1TextTab = new System.Windows.Forms.TabPage();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.songText1MissingPictureBox = new System.Windows.Forms.PictureBox();
            this.player2TextTab = new System.Windows.Forms.TabPage();
            this.songText2MissingPictureBox = new System.Windows.Forms.PictureBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteMp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.songListViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.coverPictureBox)).BeginInit();
            this.songInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.artistMissingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.titleMissingPictureBox)).BeginInit();
            this.songSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.videoGapNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bpmNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.gapNumericUpDown)).BeginInit();
            this.songFilesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.mp3MissingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.videoNotFoundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.mp3NotFoundPictureBox)).BeginInit();
            this.textTabControl.SuspendLayout();
            this.player1TextTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.songText1MissingPictureBox)).BeginInit();
            this.player2TextTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.songText2MissingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.songToolStripMenuItem, this.toolsToolStripMenuItem });
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newSongToolStripMenuItem, this.saveToolStripMenuItem, this.saveAllToolStripMenuItem, this.reloadSongsToolStripMenuItem, this.toolStripSeparator1, this.closeToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newSongToolStripMenuItem
            // 
            this.newSongToolStripMenuItem.Name = "newSongToolStripMenuItem";
            resources.ApplyResources(this.newSongToolStripMenuItem, "newSongToolStripMenuItem");
            this.newSongToolStripMenuItem.Click += new System.EventHandler(this.newSongToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAllToolStripMenuItem, "saveAllToolStripMenuItem");
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // reloadSongsToolStripMenuItem
            // 
            this.reloadSongsToolStripMenuItem.Name = "reloadSongsToolStripMenuItem";
            resources.ApplyResources(this.reloadSongsToolStripMenuItem, "reloadSongsToolStripMenuItem");
            this.reloadSongsToolStripMenuItem.Click += new System.EventHandler(this.reloadSongsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openSongTxtToolStripMenuItem, this.openDirectoryToolStripMenuItem, this.toolStripSeparator4, this.reloadSongToolStripMenuItem, this.deleteSongToolStripMenuItem, this.toolStripSeparator3, this.coverToolStripMenuItem, this.mp3ToolStripMenuItem, this.videoToolStripMenuItem, this.toolStripSeparator2, this.webSearchToolStripMenuItem });
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            resources.ApplyResources(this.songToolStripMenuItem, "songToolStripMenuItem");
            // 
            // openSongTxtToolStripMenuItem
            // 
            resources.ApplyResources(this.openSongTxtToolStripMenuItem, "openSongTxtToolStripMenuItem");
            this.openSongTxtToolStripMenuItem.Name = "openSongTxtToolStripMenuItem";
            this.openSongTxtToolStripMenuItem.Click += new System.EventHandler(this.openSongTxtToolStripMenuItem_Click);
            // 
            // openDirectoryToolStripMenuItem
            // 
            resources.ApplyResources(this.openDirectoryToolStripMenuItem, "openDirectoryToolStripMenuItem");
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // reloadSongToolStripMenuItem
            // 
            resources.ApplyResources(this.reloadSongToolStripMenuItem, "reloadSongToolStripMenuItem");
            this.reloadSongToolStripMenuItem.Name = "reloadSongToolStripMenuItem";
            this.reloadSongToolStripMenuItem.Click += new System.EventHandler(this.reloadSongToolStripMenuItem_Click);
            // 
            // deleteSongToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteSongToolStripMenuItem, "deleteSongToolStripMenuItem");
            this.deleteSongToolStripMenuItem.Name = "deleteSongToolStripMenuItem";
            this.deleteSongToolStripMenuItem.Click += new System.EventHandler(this.deleteSongToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // coverToolStripMenuItem
            // 
            this.coverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openCoverToolStripMenuItem, this.chooseCoverImageToolStripMenuItem, this.downloadCoverFromURLToolStripMenuItem, this.deleteCoverToolStripMenuItem });
            resources.ApplyResources(this.coverToolStripMenuItem, "coverToolStripMenuItem");
            this.coverToolStripMenuItem.Name = "coverToolStripMenuItem";
            // 
            // openCoverToolStripMenuItem
            // 
            resources.ApplyResources(this.openCoverToolStripMenuItem, "openCoverToolStripMenuItem");
            this.openCoverToolStripMenuItem.Name = "openCoverToolStripMenuItem";
            this.openCoverToolStripMenuItem.Click += new System.EventHandler(this.coverPictureBox_DoubleClick);
            // 
            // chooseCoverImageToolStripMenuItem
            // 
            resources.ApplyResources(this.chooseCoverImageToolStripMenuItem, "chooseCoverImageToolStripMenuItem");
            this.chooseCoverImageToolStripMenuItem.Name = "chooseCoverImageToolStripMenuItem";
            this.chooseCoverImageToolStripMenuItem.Click += new System.EventHandler(this.coverEditButton_Click);
            // 
            // downloadCoverFromURLToolStripMenuItem
            // 
            resources.ApplyResources(this.downloadCoverFromURLToolStripMenuItem, "downloadCoverFromURLToolStripMenuItem");
            this.downloadCoverFromURLToolStripMenuItem.Name = "downloadCoverFromURLToolStripMenuItem";
            this.downloadCoverFromURLToolStripMenuItem.Click += new System.EventHandler(this.coverDownloadButton_Click);
            // 
            // deleteCoverToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteCoverToolStripMenuItem, "deleteCoverToolStripMenuItem");
            this.deleteCoverToolStripMenuItem.Name = "deleteCoverToolStripMenuItem";
            this.deleteCoverToolStripMenuItem.Click += new System.EventHandler(this.coverDeleteButton_Click);
            // 
            // mp3ToolStripMenuItem
            // 
            this.mp3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openMp3ToolStripMenuItem, this.chooseMp3FileToolStripMenuItem, this.deleteMp3ToolStripMenuItem });
            resources.ApplyResources(this.mp3ToolStripMenuItem, "mp3ToolStripMenuItem");
            this.mp3ToolStripMenuItem.Name = "mp3ToolStripMenuItem";
            // 
            // openMp3ToolStripMenuItem
            // 
            resources.ApplyResources(this.openMp3ToolStripMenuItem, "openMp3ToolStripMenuItem");
            this.openMp3ToolStripMenuItem.Name = "openMp3ToolStripMenuItem";
            this.openMp3ToolStripMenuItem.Click += new System.EventHandler(this.mp3PlayButton_Click);
            // 
            // chooseMp3FileToolStripMenuItem
            // 
            resources.ApplyResources(this.chooseMp3FileToolStripMenuItem, "chooseMp3FileToolStripMenuItem");
            this.chooseMp3FileToolStripMenuItem.Name = "chooseMp3FileToolStripMenuItem";
            this.chooseMp3FileToolStripMenuItem.Click += new System.EventHandler(this.mp3EditButton_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openVideoToolStripMenuItem, this.chooseVideoToolStripMenuItem, this.deleteVideoToolStripMenuItem });
            resources.ApplyResources(this.videoToolStripMenuItem, "videoToolStripMenuItem");
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            // 
            // openVideoToolStripMenuItem
            // 
            resources.ApplyResources(this.openVideoToolStripMenuItem, "openVideoToolStripMenuItem");
            this.openVideoToolStripMenuItem.Name = "openVideoToolStripMenuItem";
            this.openVideoToolStripMenuItem.Click += new System.EventHandler(this.videoPlayButton_Click);
            // 
            // chooseVideoToolStripMenuItem
            // 
            resources.ApplyResources(this.chooseVideoToolStripMenuItem, "chooseVideoToolStripMenuItem");
            this.chooseVideoToolStripMenuItem.Name = "chooseVideoToolStripMenuItem";
            this.chooseVideoToolStripMenuItem.Click += new System.EventHandler(this.videoEditButton_Click);
            // 
            // deleteVideoToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteVideoToolStripMenuItem, "deleteVideoToolStripMenuItem");
            this.deleteVideoToolStripMenuItem.Name = "deleteVideoToolStripMenuItem";
            this.deleteVideoToolStripMenuItem.Click += new System.EventHandler(this.videoDeleteButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // webSearchToolStripMenuItem
            // 
            this.webSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.googleSearchToolStripMenuItem, this.discogsSearchToolStripMenuItem });
            resources.ApplyResources(this.webSearchToolStripMenuItem, "webSearchToolStripMenuItem");
            this.webSearchToolStripMenuItem.Name = "webSearchToolStripMenuItem";
            // 
            // googleSearchToolStripMenuItem
            // 
            this.googleSearchToolStripMenuItem.Name = "googleSearchToolStripMenuItem";
            resources.ApplyResources(this.googleSearchToolStripMenuItem, "googleSearchToolStripMenuItem");
            this.googleSearchToolStripMenuItem.Click += new System.EventHandler(this.googleSearchToolStripMenuItem_Click);
            // 
            // discogsSearchToolStripMenuItem
            // 
            this.discogsSearchToolStripMenuItem.Name = "discogsSearchToolStripMenuItem";
            resources.ApplyResources(this.discogsSearchToolStripMenuItem, "discogsSearchToolStripMenuItem");
            this.discogsSearchToolStripMenuItem.Click += new System.EventHandler(this.discogsSearchToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.startUltraStarDeluxeToolStripMenuItem, this.databasesToolStripMenuItem, this.importSongTxtToolStripMenuItem, this.exportSongTxtToolStripMenuItem });
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // startUltraStarDeluxeToolStripMenuItem
            // 
            this.startUltraStarDeluxeToolStripMenuItem.Name = "startUltraStarDeluxeToolStripMenuItem";
            resources.ApplyResources(this.startUltraStarDeluxeToolStripMenuItem, "startUltraStarDeluxeToolStripMenuItem");
            this.startUltraStarDeluxeToolStripMenuItem.Click += new System.EventHandler(this.startUltraStarDeluxeToolStripMenuItem_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openUsdbAnimuxDeToolStripMenuItem });
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            resources.ApplyResources(this.databasesToolStripMenuItem, "databasesToolStripMenuItem");
            // 
            // openUsdbAnimuxDeToolStripMenuItem
            // 
            this.openUsdbAnimuxDeToolStripMenuItem.Name = "openUsdbAnimuxDeToolStripMenuItem";
            resources.ApplyResources(this.openUsdbAnimuxDeToolStripMenuItem, "openUsdbAnimuxDeToolStripMenuItem");
            this.openUsdbAnimuxDeToolStripMenuItem.Click += new System.EventHandler(this.openUsdbAnimuxDeToolStripMenuItem_Click);
            // 
            // importSongTxtToolStripMenuItem
            // 
            this.importSongTxtToolStripMenuItem.Name = "importSongTxtToolStripMenuItem";
            resources.ApplyResources(this.importSongTxtToolStripMenuItem, "importSongTxtToolStripMenuItem");
            this.importSongTxtToolStripMenuItem.Click += new System.EventHandler(this.importSongTxtToolStripMenuItem_Click);
            // 
            // exportSongTxtToolStripMenuItem
            // 
            resources.ApplyResources(this.exportSongTxtToolStripMenuItem, "exportSongTxtToolStripMenuItem");
            this.exportSongTxtToolStripMenuItem.Name = "exportSongTxtToolStripMenuItem";
            this.exportSongTxtToolStripMenuItem.Click += new System.EventHandler(this.exportSongTxtToolStripMenuItem_Click);
            // 
            // songListView
            // 
            this.songListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.titleColumn, this.artistColumn, this.playableColumn, this.fileColumn });
            this.songListView.ContextMenuStrip = this.songListViewContextMenuStrip;
            resources.ApplyResources(this.songListView, "songListView");
            this.songListView.FullRowSelect = true;
            this.songListView.GridLines = true;
            this.songListView.MultiSelect = false;
            this.songListView.Name = "songListView";
            this.songListView.ShowItemToolTips = true;
            this.songListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.songListView.TabStop = false;
            this.songListView.UseCompatibleStateImageBehavior = false;
            this.songListView.View = System.Windows.Forms.View.Details;
            this.songListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.songListView_ColumnClick);
            this.songListView.SelectedIndexChanged += new System.EventHandler(this.songListView_SelectedIndexChanged);
            this.songListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.songListView_KeyDown);
            // 
            // titleColumn
            // 
            resources.ApplyResources(this.titleColumn, "titleColumn");
            // 
            // artistColumn
            // 
            resources.ApplyResources(this.artistColumn, "artistColumn");
            // 
            // playableColumn
            // 
            resources.ApplyResources(this.playableColumn, "playableColumn");
            // 
            // fileColumn
            // 
            resources.ApplyResources(this.fileColumn, "fileColumn");
            // 
            // songListViewContextMenuStrip
            // 
            this.songListViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openSongTxtContextMenuItem, this.openDirectoryContextMenuItem, this.toolStripSeparator6, this.reloadSongContextMenuItem, this.deleteSongContextMenuItem, this.toolStripSeparator5, this.webSearchToolStripMenuItem1 });
            this.songListViewContextMenuStrip.Name = "songListViewContextMenuStrip";
            resources.ApplyResources(this.songListViewContextMenuStrip, "songListViewContextMenuStrip");
            // 
            // openSongTxtContextMenuItem
            // 
            this.openSongTxtContextMenuItem.Name = "openSongTxtContextMenuItem";
            resources.ApplyResources(this.openSongTxtContextMenuItem, "openSongTxtContextMenuItem");
            this.openSongTxtContextMenuItem.Click += new System.EventHandler(this.openSongTxtToolStripMenuItem_Click);
            // 
            // openDirectoryContextMenuItem
            // 
            this.openDirectoryContextMenuItem.Name = "openDirectoryContextMenuItem";
            resources.ApplyResources(this.openDirectoryContextMenuItem, "openDirectoryContextMenuItem");
            this.openDirectoryContextMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // reloadSongContextMenuItem
            // 
            this.reloadSongContextMenuItem.Name = "reloadSongContextMenuItem";
            resources.ApplyResources(this.reloadSongContextMenuItem, "reloadSongContextMenuItem");
            this.reloadSongContextMenuItem.Click += new System.EventHandler(this.reloadSongToolStripMenuItem_Click);
            // 
            // deleteSongContextMenuItem
            // 
            this.deleteSongContextMenuItem.Name = "deleteSongContextMenuItem";
            resources.ApplyResources(this.deleteSongContextMenuItem, "deleteSongContextMenuItem");
            this.deleteSongContextMenuItem.Click += new System.EventHandler(this.deleteSongToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // webSearchToolStripMenuItem1
            // 
            this.webSearchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.googleSearchContextMenuItem, this.discogsSearchContextMenuItem });
            this.webSearchToolStripMenuItem1.Name = "webSearchToolStripMenuItem1";
            resources.ApplyResources(this.webSearchToolStripMenuItem1, "webSearchToolStripMenuItem1");
            // 
            // googleSearchContextMenuItem
            // 
            this.googleSearchContextMenuItem.Name = "googleSearchContextMenuItem";
            resources.ApplyResources(this.googleSearchContextMenuItem, "googleSearchContextMenuItem");
            this.googleSearchContextMenuItem.Click += new System.EventHandler(this.googleSearchToolStripMenuItem_Click);
            // 
            // discogsSearchContextMenuItem
            // 
            this.discogsSearchContextMenuItem.Name = "discogsSearchContextMenuItem";
            resources.ApplyResources(this.discogsSearchContextMenuItem, "discogsSearchContextMenuItem");
            this.discogsSearchContextMenuItem.Click += new System.EventHandler(this.discogsSearchToolStripMenuItem_Click);
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.coverPictureBox, "coverPictureBox");
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.TabStop = false;
            this.coverPictureBox.DoubleClick += new System.EventHandler(this.coverPictureBox_DoubleClick);
            // 
            // artistTextBox
            // 
            resources.ApplyResources(this.artistTextBox, "artistTextBox");
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // artistLabel
            // 
            resources.ApplyResources(this.artistLabel, "artistLabel");
            this.artistLabel.Name = "artistLabel";
            // 
            // coverDeleteButton
            // 
            resources.ApplyResources(this.coverDeleteButton, "coverDeleteButton");
            this.coverDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coverDeleteButton.Name = "coverDeleteButton";
            this.coverDeleteButton.TabStop = false;
            this.coverDeleteButton.UseVisualStyleBackColor = true;
            this.coverDeleteButton.Click += new System.EventHandler(this.coverDeleteButton_Click);
            // 
            // coverEditButton
            // 
            resources.ApplyResources(this.coverEditButton, "coverEditButton");
            this.coverEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coverEditButton.Name = "coverEditButton";
            this.coverEditButton.TabStop = false;
            this.coverEditButton.UseVisualStyleBackColor = true;
            this.coverEditButton.Click += new System.EventHandler(this.coverEditButton_Click);
            // 
            // yearLabel
            // 
            resources.ApplyResources(this.yearLabel, "yearLabel");
            this.yearLabel.Name = "yearLabel";
            // 
            // languageTextBox
            // 
            resources.ApplyResources(this.languageTextBox, "languageTextBox");
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // genreTextBox
            // 
            resources.ApplyResources(this.genreTextBox, "genreTextBox");
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // genreLabel
            // 
            resources.ApplyResources(this.genreLabel, "genreLabel");
            this.genreLabel.Name = "genreLabel";
            // 
            // editionTextBox
            // 
            resources.ApplyResources(this.editionTextBox, "editionTextBox");
            this.editionTextBox.Name = "editionTextBox";
            this.editionTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // editionLabel
            // 
            resources.ApplyResources(this.editionLabel, "editionLabel");
            this.editionLabel.Name = "editionLabel";
            // 
            // songInfoGroupBox
            // 
            this.songInfoGroupBox.Controls.Add(this.titleTextBox);
            this.songInfoGroupBox.Controls.Add(this.artistMissingPictureBox);
            this.songInfoGroupBox.Controls.Add(this.titleMissingPictureBox);
            this.songInfoGroupBox.Controls.Add(this.coverDownloadButton);
            this.songInfoGroupBox.Controls.Add(this.coverEditButton);
            this.songInfoGroupBox.Controls.Add(this.coverDeleteButton);
            this.songInfoGroupBox.Controls.Add(this.yearTextBox);
            this.songInfoGroupBox.Controls.Add(this.artistTextBox);
            this.songInfoGroupBox.Controls.Add(this.coverPictureBox);
            this.songInfoGroupBox.Controls.Add(this.languageTextBox);
            this.songInfoGroupBox.Controls.Add(this.genreTextBox);
            this.songInfoGroupBox.Controls.Add(this.editionTextBox);
            this.songInfoGroupBox.Controls.Add(this.editionLabel);
            this.songInfoGroupBox.Controls.Add(this.titleLabel);
            this.songInfoGroupBox.Controls.Add(this.genreLabel);
            this.songInfoGroupBox.Controls.Add(this.artistLabel);
            this.songInfoGroupBox.Controls.Add(this.languageLabel);
            this.songInfoGroupBox.Controls.Add(this.yearLabel);
            resources.ApplyResources(this.songInfoGroupBox, "songInfoGroupBox");
            this.songInfoGroupBox.Name = "songInfoGroupBox";
            this.songInfoGroupBox.TabStop = false;
            // 
            // artistMissingPictureBox
            // 
            resources.ApplyResources(this.artistMissingPictureBox, "artistMissingPictureBox");
            this.artistMissingPictureBox.Name = "artistMissingPictureBox";
            this.artistMissingPictureBox.TabStop = false;
            // 
            // titleMissingPictureBox
            // 
            resources.ApplyResources(this.titleMissingPictureBox, "titleMissingPictureBox");
            this.titleMissingPictureBox.Name = "titleMissingPictureBox";
            this.titleMissingPictureBox.TabStop = false;
            // 
            // coverDownloadButton
            // 
            resources.ApplyResources(this.coverDownloadButton, "coverDownloadButton");
            this.coverDownloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coverDownloadButton.Name = "coverDownloadButton";
            this.coverDownloadButton.TabStop = false;
            this.coverDownloadButton.UseVisualStyleBackColor = true;
            this.coverDownloadButton.Click += new System.EventHandler(this.coverDownloadButton_Click);
            // 
            // yearTextBox
            // 
            resources.ApplyResources(this.yearTextBox, "yearTextBox");
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // songSettingsGroupBox
            // 
            this.songSettingsGroupBox.Controls.Add(this.duetCheckBox);
            this.songSettingsGroupBox.Controls.Add(this.videoGapLabel);
            this.songSettingsGroupBox.Controls.Add(this.bpmLabel);
            this.songSettingsGroupBox.Controls.Add(this.gapLabel);
            this.songSettingsGroupBox.Controls.Add(this.duetSinger2TextBox);
            this.songSettingsGroupBox.Controls.Add(this.duetSinger1TextBox);
            this.songSettingsGroupBox.Controls.Add(this.videoGapNumericUpDown);
            this.songSettingsGroupBox.Controls.Add(this.bpmNumericUpDown);
            this.songSettingsGroupBox.Controls.Add(this.duetSinger2Label);
            this.songSettingsGroupBox.Controls.Add(this.gapNumericUpDown);
            this.songSettingsGroupBox.Controls.Add(this.duetSinger1Label);
            resources.ApplyResources(this.songSettingsGroupBox, "songSettingsGroupBox");
            this.songSettingsGroupBox.Name = "songSettingsGroupBox";
            this.songSettingsGroupBox.TabStop = false;
            // 
            // duetCheckBox
            // 
            resources.ApplyResources(this.duetCheckBox, "duetCheckBox");
            this.duetCheckBox.Name = "duetCheckBox";
            this.duetCheckBox.UseVisualStyleBackColor = true;
            this.duetCheckBox.CheckedChanged += new System.EventHandler(this.duetCheckBox_CheckedChanged);
            // 
            // videoGapLabel
            // 
            resources.ApplyResources(this.videoGapLabel, "videoGapLabel");
            this.videoGapLabel.Name = "videoGapLabel";
            // 
            // bpmLabel
            // 
            resources.ApplyResources(this.bpmLabel, "bpmLabel");
            this.bpmLabel.Name = "bpmLabel";
            // 
            // gapLabel
            // 
            resources.ApplyResources(this.gapLabel, "gapLabel");
            this.gapLabel.Name = "gapLabel";
            // 
            // duetSinger2TextBox
            // 
            resources.ApplyResources(this.duetSinger2TextBox, "duetSinger2TextBox");
            this.duetSinger2TextBox.Name = "duetSinger2TextBox";
            this.duetSinger2TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // duetSinger1TextBox
            // 
            resources.ApplyResources(this.duetSinger1TextBox, "duetSinger1TextBox");
            this.duetSinger1TextBox.Name = "duetSinger1TextBox";
            this.duetSinger1TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // videoGapNumericUpDown
            // 
            this.videoGapNumericUpDown.DecimalPlaces = 2;
            resources.ApplyResources(this.videoGapNumericUpDown, "videoGapNumericUpDown");
            this.videoGapNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.videoGapNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.videoGapNumericUpDown.Name = "videoGapNumericUpDown";
            this.videoGapNumericUpDown.ValueChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // bpmNumericUpDown
            // 
            this.bpmNumericUpDown.DecimalPlaces = 2;
            resources.ApplyResources(this.bpmNumericUpDown, "bpmNumericUpDown");
            this.bpmNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.bpmNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.bpmNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.bpmNumericUpDown.Name = "bpmNumericUpDown";
            this.bpmNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.bpmNumericUpDown.ValueChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // duetSinger2Label
            // 
            resources.ApplyResources(this.duetSinger2Label, "duetSinger2Label");
            this.duetSinger2Label.Name = "duetSinger2Label";
            // 
            // gapNumericUpDown
            // 
            this.gapNumericUpDown.DecimalPlaces = 2;
            resources.ApplyResources(this.gapNumericUpDown, "gapNumericUpDown");
            this.gapNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.gapNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.gapNumericUpDown.Name = "gapNumericUpDown";
            this.gapNumericUpDown.ValueChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // duetSinger1Label
            // 
            resources.ApplyResources(this.duetSinger1Label, "duetSinger1Label");
            this.duetSinger1Label.Name = "duetSinger1Label";
            // 
            // songFilesGroupBox
            // 
            this.songFilesGroupBox.Controls.Add(this.mp3MissingPictureBox);
            this.songFilesGroupBox.Controls.Add(this.videoNotFoundPictureBox);
            this.songFilesGroupBox.Controls.Add(this.mp3NotFoundPictureBox);
            this.songFilesGroupBox.Controls.Add(this.videoTextBox);
            this.songFilesGroupBox.Controls.Add(this.mp3TextBox);
            this.songFilesGroupBox.Controls.Add(this.videoEditButton);
            this.songFilesGroupBox.Controls.Add(this.videoPlayButton);
            this.songFilesGroupBox.Controls.Add(this.mp3PlayButton);
            this.songFilesGroupBox.Controls.Add(this.mp3EditButton);
            this.songFilesGroupBox.Controls.Add(this.mp3DeleteButton);
            this.songFilesGroupBox.Controls.Add(this.videoDeleteButton);
            this.songFilesGroupBox.Controls.Add(this.videoLabel);
            this.songFilesGroupBox.Controls.Add(this.mp3Label);
            resources.ApplyResources(this.songFilesGroupBox, "songFilesGroupBox");
            this.songFilesGroupBox.Name = "songFilesGroupBox";
            this.songFilesGroupBox.TabStop = false;
            // 
            // mp3MissingPictureBox
            // 
            resources.ApplyResources(this.mp3MissingPictureBox, "mp3MissingPictureBox");
            this.mp3MissingPictureBox.Name = "mp3MissingPictureBox";
            this.mp3MissingPictureBox.TabStop = false;
            // 
            // videoNotFoundPictureBox
            // 
            resources.ApplyResources(this.videoNotFoundPictureBox, "videoNotFoundPictureBox");
            this.videoNotFoundPictureBox.Name = "videoNotFoundPictureBox";
            this.videoNotFoundPictureBox.TabStop = false;
            // 
            // mp3NotFoundPictureBox
            // 
            resources.ApplyResources(this.mp3NotFoundPictureBox, "mp3NotFoundPictureBox");
            this.mp3NotFoundPictureBox.Name = "mp3NotFoundPictureBox";
            this.mp3NotFoundPictureBox.TabStop = false;
            // 
            // videoTextBox
            // 
            resources.ApplyResources(this.videoTextBox, "videoTextBox");
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // mp3TextBox
            // 
            resources.ApplyResources(this.mp3TextBox, "mp3TextBox");
            this.mp3TextBox.Name = "mp3TextBox";
            this.mp3TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // videoEditButton
            // 
            resources.ApplyResources(this.videoEditButton, "videoEditButton");
            this.videoEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoEditButton.Name = "videoEditButton";
            this.videoEditButton.TabStop = false;
            this.videoEditButton.UseVisualStyleBackColor = true;
            this.videoEditButton.Click += new System.EventHandler(this.videoEditButton_Click);
            // 
            // videoPlayButton
            // 
            resources.ApplyResources(this.videoPlayButton, "videoPlayButton");
            this.videoPlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoPlayButton.Name = "videoPlayButton";
            this.videoPlayButton.TabStop = false;
            this.videoPlayButton.UseVisualStyleBackColor = true;
            this.videoPlayButton.Click += new System.EventHandler(this.videoPlayButton_Click);
            // 
            // mp3PlayButton
            // 
            resources.ApplyResources(this.mp3PlayButton, "mp3PlayButton");
            this.mp3PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp3PlayButton.Name = "mp3PlayButton";
            this.mp3PlayButton.TabStop = false;
            this.mp3PlayButton.UseVisualStyleBackColor = true;
            this.mp3PlayButton.Click += new System.EventHandler(this.mp3PlayButton_Click);
            // 
            // mp3EditButton
            // 
            resources.ApplyResources(this.mp3EditButton, "mp3EditButton");
            this.mp3EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp3EditButton.Name = "mp3EditButton";
            this.mp3EditButton.TabStop = false;
            this.mp3EditButton.UseVisualStyleBackColor = true;
            this.mp3EditButton.Click += new System.EventHandler(this.mp3EditButton_Click);
            // 
            // mp3DeleteButton
            // 
            resources.ApplyResources(this.mp3DeleteButton, "mp3DeleteButton");
            this.mp3DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp3DeleteButton.Name = "mp3DeleteButton";
            this.mp3DeleteButton.TabStop = false;
            this.mp3DeleteButton.UseVisualStyleBackColor = true;
            this.mp3DeleteButton.Click += new System.EventHandler(this.mp3DeleteButton_Click);
            // 
            // videoDeleteButton
            // 
            resources.ApplyResources(this.videoDeleteButton, "videoDeleteButton");
            this.videoDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoDeleteButton.Name = "videoDeleteButton";
            this.videoDeleteButton.TabStop = false;
            this.videoDeleteButton.UseVisualStyleBackColor = true;
            this.videoDeleteButton.Click += new System.EventHandler(this.videoDeleteButton_Click);
            // 
            // videoLabel
            // 
            resources.ApplyResources(this.videoLabel, "videoLabel");
            this.videoLabel.Name = "videoLabel";
            // 
            // mp3Label
            // 
            resources.ApplyResources(this.mp3Label, "mp3Label");
            this.mp3Label.Name = "mp3Label";
            // 
            // textTabControl
            // 
            this.textTabControl.Controls.Add(this.player1TextTab);
            this.textTabControl.Controls.Add(this.player2TextTab);
            resources.ApplyResources(this.textTabControl, "textTabControl");
            this.textTabControl.Name = "textTabControl";
            this.textTabControl.SelectedIndex = 0;
            this.textTabControl.TabStop = false;
            this.textTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.textTabControl_Selecting);
            // 
            // player1TextTab
            // 
            this.player1TextTab.Controls.Add(this.player1TextBox);
            this.player1TextTab.Controls.Add(this.songText1MissingPictureBox);
            resources.ApplyResources(this.player1TextTab, "player1TextTab");
            this.player1TextTab.Name = "player1TextTab";
            this.player1TextTab.UseVisualStyleBackColor = true;
            // 
            // player1TextBox
            // 
            resources.ApplyResources(this.player1TextBox, "player1TextBox");
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // songText1MissingPictureBox
            // 
            this.songText1MissingPictureBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.songText1MissingPictureBox, "songText1MissingPictureBox");
            this.songText1MissingPictureBox.Name = "songText1MissingPictureBox";
            this.songText1MissingPictureBox.TabStop = false;
            // 
            // player2TextTab
            // 
            this.player2TextTab.Controls.Add(this.songText2MissingPictureBox);
            this.player2TextTab.Controls.Add(this.player2TextBox);
            resources.ApplyResources(this.player2TextTab, "player2TextTab");
            this.player2TextTab.Name = "player2TextTab";
            this.player2TextTab.UseVisualStyleBackColor = true;
            // 
            // songText2MissingPictureBox
            // 
            this.songText2MissingPictureBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.songText2MissingPictureBox, "songText2MissingPictureBox");
            this.songText2MissingPictureBox.Name = "songText2MissingPictureBox";
            this.songText2MissingPictureBox.TabStop = false;
            // 
            // player2TextBox
            // 
            resources.ApplyResources(this.player2TextBox, "player2TextBox");
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            this.toolTip.ShowAlways = true;
            // 
            // deleteMp3ToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteMp3ToolStripMenuItem, "deleteMp3ToolStripMenuItem");
            this.deleteMp3ToolStripMenuItem.Name = "deleteMp3ToolStripMenuItem";
            this.deleteMp3ToolStripMenuItem.Click += new System.EventHandler(this.mp3DeleteButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textTabControl);
            this.Controls.Add(this.songFilesGroupBox);
            this.Controls.Add(this.songSettingsGroupBox);
            this.Controls.Add(this.songInfoGroupBox);
            this.Controls.Add(this.songListView);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.songListViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.coverPictureBox)).EndInit();
            this.songInfoGroupBox.ResumeLayout(false);
            this.songInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.artistMissingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.titleMissingPictureBox)).EndInit();
            this.songSettingsGroupBox.ResumeLayout(false);
            this.songSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.videoGapNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bpmNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.gapNumericUpDown)).EndInit();
            this.songFilesGroupBox.ResumeLayout(false);
            this.songFilesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.mp3MissingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.videoNotFoundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.mp3NotFoundPictureBox)).EndInit();
            this.textTabControl.ResumeLayout(false);
            this.player1TextTab.ResumeLayout(false);
            this.player1TextTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.songText1MissingPictureBox)).EndInit();
            this.player2TextTab.ResumeLayout(false);
            this.player2TextTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.songText2MissingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem deleteMp3ToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem webSearchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem googleSearchContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discogsSearchContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSongTxtContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryContextMenuItem;

        private System.Windows.Forms.ToolStripMenuItem deleteSongContextMenuItem;

        private System.Windows.Forms.ToolStripMenuItem reloadSongContextMenuItem;

        private System.Windows.Forms.ContextMenuStrip songListViewContextMenuStrip;

        private System.Windows.Forms.ColumnHeader playableColumn;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private System.Windows.Forms.ToolStripMenuItem deleteSongToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem newSongToolStripMenuItem;

        private System.Windows.Forms.Button mp3DeleteButton;

        private System.Windows.Forms.PictureBox mp3MissingPictureBox;

        private System.Windows.Forms.PictureBox songText1MissingPictureBox;

        private System.Windows.Forms.PictureBox songText2MissingPictureBox;

        private System.Windows.Forms.PictureBox titleMissingPictureBox;
        private System.Windows.Forms.PictureBox artistMissingPictureBox;

        private System.Windows.Forms.ToolStripMenuItem deleteVideoToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem chooseMp3FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseVideoToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem mp3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openUsdbAnimuxDeToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem importSongTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSongTxtToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startUltraStarDeluxeToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;

        private System.Windows.Forms.PictureBox mp3NotFoundPictureBox;
        private System.Windows.Forms.PictureBox videoNotFoundPictureBox;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openSongTxtToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem reloadSongToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem downloadCoverFromURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseCoverImageToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem coverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCoverToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem openMp3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discogsSearchToolStripMenuItem;

        private System.Windows.Forms.ColumnHeader fileColumn;

        private System.Windows.Forms.ToolTip toolTip;

        private System.Windows.Forms.Button coverDownloadButton;

        private System.Windows.Forms.ToolStripMenuItem reloadSongsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;

        private System.Windows.Forms.TextBox yearTextBox;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        private System.Windows.Forms.Button videoPlayButton;

        private System.Windows.Forms.Button mp3PlayButton;

        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.TextBox player2TextBox;

        private System.Windows.Forms.TabPage player2TextTab;

        private System.Windows.Forms.TabControl textTabControl;
        private System.Windows.Forms.TabPage player1TextTab;

        private System.Windows.Forms.Label mp3Label;
        private System.Windows.Forms.TextBox mp3TextBox;
        private System.Windows.Forms.Button coverEditButton;
        private System.Windows.Forms.Button mp3EditButton;
        private System.Windows.Forms.Label videoLabel;
        private System.Windows.Forms.Button videoDeleteButton;
        private System.Windows.Forms.Button videoEditButton;
        private System.Windows.Forms.TextBox videoTextBox;

        private System.Windows.Forms.GroupBox songFilesGroupBox;

        private System.Windows.Forms.Label duetSinger1Label;
        private System.Windows.Forms.TextBox duetSinger1TextBox;
        private System.Windows.Forms.Label duetSinger2Label;
        private System.Windows.Forms.TextBox duetSinger2TextBox;

        private System.Windows.Forms.CheckBox duetCheckBox;

        private System.Windows.Forms.NumericUpDown bpmNumericUpDown;
        private System.Windows.Forms.Label bpmLabel;
        private System.Windows.Forms.NumericUpDown videoGapNumericUpDown;
        private System.Windows.Forms.Label videoGapLabel;

        private System.Windows.Forms.Label gapLabel;
        private System.Windows.Forms.NumericUpDown gapNumericUpDown;

        private System.Windows.Forms.GroupBox songInfoGroupBox;
        private System.Windows.Forms.GroupBox songSettingsGroupBox;

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox editionTextBox;
        private System.Windows.Forms.Label editionLabel;

        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Button coverDeleteButton;

        private System.Windows.Forms.PictureBox coverPictureBox;

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.ColumnHeader artistColumn;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.TextBox titleTextBox;

        private System.Windows.Forms.ListView songListView;

        private System.Windows.Forms.MenuStrip mainMenuStrip;

        #endregion
    }
}