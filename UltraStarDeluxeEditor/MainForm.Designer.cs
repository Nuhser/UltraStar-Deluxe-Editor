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
            this.reloadSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discogsSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songListView = new System.Windows.Forms.ListView();
            this.titleColumn = new System.Windows.Forms.ColumnHeader();
            this.artistColumn = new System.Windows.Forms.ColumnHeader();
            this.fileColumn = new System.Windows.Forms.ColumnHeader();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.deleteCoverButton = new System.Windows.Forms.Button();
            this.editCoverButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.editionTextBox = new System.Windows.Forms.TextBox();
            this.editionLabel = new System.Windows.Forms.Label();
            this.songInfoGroupBox = new System.Windows.Forms.GroupBox();
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
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.mp3TextBox = new System.Windows.Forms.TextBox();
            this.videoEditButton = new System.Windows.Forms.Button();
            this.videoPlayButton = new System.Windows.Forms.Button();
            this.mp3PlayButton = new System.Windows.Forms.Button();
            this.mp3EditButton = new System.Windows.Forms.Button();
            this.videoDeleteButton = new System.Windows.Forms.Button();
            this.videoLabel = new System.Windows.Forms.Label();
            this.mp3DeleteButton = new System.Windows.Forms.Button();
            this.mp3Label = new System.Windows.Forms.Label();
            this.textTabControl = new System.Windows.Forms.TabControl();
            this.player1TextTab = new System.Windows.Forms.TabPage();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2TextTab = new System.Windows.Forms.TabPage();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openCoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.coverPictureBox)).BeginInit();
            this.songInfoGroupBox.SuspendLayout();
            this.songSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.videoGapNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bpmNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.gapNumericUpDown)).BeginInit();
            this.songFilesGroupBox.SuspendLayout();
            this.textTabControl.SuspendLayout();
            this.player1TextTab.SuspendLayout();
            this.player2TextTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.songToolStripMenuItem });
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1445, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.reloadSongsToolStripMenuItem, this.saveToolStripMenuItem, this.saveAllToolStripMenuItem, this.toolStripSeparator1, this.closeToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // reloadSongsToolStripMenuItem
            // 
            this.reloadSongsToolStripMenuItem.Name = "reloadSongsToolStripMenuItem";
            this.reloadSongsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reloadSongsToolStripMenuItem.Text = "Reload Songs";
            this.reloadSongsToolStripMenuItem.Click += new System.EventHandler(this.reloadSongsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openCoverToolStripMenuItem, this.openMP3ToolStripMenuItem, this.openVideoToolStripMenuItem, this.toolStripSeparator2, this.webSearchToolStripMenuItem });
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.songToolStripMenuItem.Text = "Song";
            // 
            // webSearchToolStripMenuItem
            // 
            this.webSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.googleSearchToolStripMenuItem, this.discogsSearchToolStripMenuItem });
            this.webSearchToolStripMenuItem.Name = "webSearchToolStripMenuItem";
            this.webSearchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.webSearchToolStripMenuItem.Text = "Web Search";
            // 
            // googleSearchToolStripMenuItem
            // 
            this.googleSearchToolStripMenuItem.Name = "googleSearchToolStripMenuItem";
            this.googleSearchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.googleSearchToolStripMenuItem.Text = "Search with Google";
            this.googleSearchToolStripMenuItem.Click += new System.EventHandler(this.googleSearchToolStripMenuItem_Click);
            // 
            // discogsSearchToolStripMenuItem
            // 
            this.discogsSearchToolStripMenuItem.Name = "discogsSearchToolStripMenuItem";
            this.discogsSearchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.discogsSearchToolStripMenuItem.Text = "Search on Discogs";
            this.discogsSearchToolStripMenuItem.Click += new System.EventHandler(this.discogsSearchToolStripMenuItem_Click);
            // 
            // songListView
            // 
            this.songListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.titleColumn, this.artistColumn, this.fileColumn });
            this.songListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.songListView.FullRowSelect = true;
            this.songListView.GridLines = true;
            this.songListView.Location = new System.Drawing.Point(12, 27);
            this.songListView.MultiSelect = false;
            this.songListView.Name = "songListView";
            this.songListView.ShowItemToolTips = true;
            this.songListView.Size = new System.Drawing.Size(691, 849);
            this.songListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.songListView.TabIndex = 1;
            this.songListView.TabStop = false;
            this.songListView.UseCompatibleStateImageBehavior = false;
            this.songListView.View = System.Windows.Forms.View.Details;
            this.songListView.SelectedIndexChanged += new System.EventHandler(this.songListView_SelectedIndexChanged);
            // 
            // titleColumn
            // 
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 259;
            // 
            // artistColumn
            // 
            this.artistColumn.Text = "Artist";
            this.artistColumn.Width = 216;
            // 
            // fileColumn
            // 
            this.fileColumn.Text = "File";
            this.fileColumn.Width = 266;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.titleTextBox.Location = new System.Drawing.Point(100, 22);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(452, 26);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverPictureBox.Image = ((System.Drawing.Image) (resources.GetObject("coverPictureBox.Image")));
            this.coverPictureBox.InitialImage = null;
            this.coverPictureBox.Location = new System.Drawing.Point(568, 22);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(150, 150);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 4;
            this.coverPictureBox.TabStop = false;
            this.coverPictureBox.DoubleClick += new System.EventHandler(this.coverPictureBox_DoubleClick);
            // 
            // artistTextBox
            // 
            this.artistTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.artistTextBox.Location = new System.Drawing.Point(100, 56);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(452, 26);
            this.artistTextBox.TabIndex = 1;
            this.artistTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // artistLabel
            // 
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.artistLabel.Location = new System.Drawing.Point(9, 58);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(85, 23);
            this.artistLabel.TabIndex = 3;
            this.artistLabel.Text = "Artist";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteCoverButton
            // 
            this.deleteCoverButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("deleteCoverButton.BackgroundImage")));
            this.deleteCoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteCoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCoverButton.Location = new System.Drawing.Point(686, 180);
            this.deleteCoverButton.Name = "deleteCoverButton";
            this.deleteCoverButton.Size = new System.Drawing.Size(32, 32);
            this.deleteCoverButton.TabIndex = 16;
            this.deleteCoverButton.TabStop = false;
            this.deleteCoverButton.UseVisualStyleBackColor = true;
            this.deleteCoverButton.Click += new System.EventHandler(this.deleteCoverButton_Click);
            // 
            // editCoverButton
            // 
            this.editCoverButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("editCoverButton.BackgroundImage")));
            this.editCoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editCoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCoverButton.Location = new System.Drawing.Point(648, 180);
            this.editCoverButton.Name = "editCoverButton";
            this.editCoverButton.Size = new System.Drawing.Size(32, 32);
            this.editCoverButton.TabIndex = 15;
            this.editCoverButton.TabStop = false;
            this.editCoverButton.UseVisualStyleBackColor = true;
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yearLabel.Location = new System.Drawing.Point(9, 91);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(85, 23);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.languageTextBox.Location = new System.Drawing.Point(100, 120);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(452, 26);
            this.languageTextBox.TabIndex = 3;
            this.languageTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.languageLabel.Location = new System.Drawing.Point(9, 123);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(85, 23);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "Language";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.genreTextBox.Location = new System.Drawing.Point(100, 152);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(452, 26);
            this.genreTextBox.TabIndex = 4;
            this.genreTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // genreLabel
            // 
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.genreLabel.Location = new System.Drawing.Point(9, 155);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(85, 23);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // editionTextBox
            // 
            this.editionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.editionTextBox.Location = new System.Drawing.Point(100, 184);
            this.editionTextBox.Name = "editionTextBox";
            this.editionTextBox.Size = new System.Drawing.Size(452, 26);
            this.editionTextBox.TabIndex = 5;
            this.editionTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // editionLabel
            // 
            this.editionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.editionLabel.Location = new System.Drawing.Point(9, 186);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(85, 23);
            this.editionLabel.TabIndex = 3;
            this.editionLabel.Text = "Edition";
            this.editionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // songInfoGroupBox
            // 
            this.songInfoGroupBox.Controls.Add(this.titleTextBox);
            this.songInfoGroupBox.Controls.Add(this.coverDownloadButton);
            this.songInfoGroupBox.Controls.Add(this.editCoverButton);
            this.songInfoGroupBox.Controls.Add(this.deleteCoverButton);
            this.songInfoGroupBox.Controls.Add(this.yearTextBox);
            this.songInfoGroupBox.Controls.Add(this.artistTextBox);
            this.songInfoGroupBox.Controls.Add(this.coverPictureBox);
            this.songInfoGroupBox.Controls.Add(this.languageTextBox);
            this.songInfoGroupBox.Controls.Add(this.genreTextBox);
            this.songInfoGroupBox.Controls.Add(this.editionTextBox);
            this.songInfoGroupBox.Controls.Add(this.editionLabel);
            this.songInfoGroupBox.Controls.Add(this.label1);
            this.songInfoGroupBox.Controls.Add(this.genreLabel);
            this.songInfoGroupBox.Controls.Add(this.artistLabel);
            this.songInfoGroupBox.Controls.Add(this.languageLabel);
            this.songInfoGroupBox.Controls.Add(this.yearLabel);
            this.songInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.songInfoGroupBox.Location = new System.Drawing.Point(709, 27);
            this.songInfoGroupBox.Name = "songInfoGroupBox";
            this.songInfoGroupBox.Size = new System.Drawing.Size(724, 218);
            this.songInfoGroupBox.TabIndex = 6;
            this.songInfoGroupBox.TabStop = false;
            this.songInfoGroupBox.Text = "Song Info";
            // 
            // coverDownloadButton
            // 
            this.coverDownloadButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("coverDownloadButton.BackgroundImage")));
            this.coverDownloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverDownloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coverDownloadButton.Location = new System.Drawing.Point(610, 180);
            this.coverDownloadButton.Name = "coverDownloadButton";
            this.coverDownloadButton.Size = new System.Drawing.Size(32, 32);
            this.coverDownloadButton.TabIndex = 14;
            this.coverDownloadButton.TabStop = false;
            this.coverDownloadButton.UseVisualStyleBackColor = true;
            this.coverDownloadButton.Click += new System.EventHandler(this.coverDownloadButton_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.yearTextBox.Location = new System.Drawing.Point(100, 88);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(452, 26);
            this.yearTextBox.TabIndex = 2;
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
            this.songSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.songSettingsGroupBox.Location = new System.Drawing.Point(709, 251);
            this.songSettingsGroupBox.Name = "songSettingsGroupBox";
            this.songSettingsGroupBox.Size = new System.Drawing.Size(724, 121);
            this.songSettingsGroupBox.TabIndex = 7;
            this.songSettingsGroupBox.TabStop = false;
            this.songSettingsGroupBox.Text = "Song Settings";
            // 
            // duetCheckBox
            // 
            this.duetCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.duetCheckBox.Location = new System.Drawing.Point(9, 54);
            this.duetCheckBox.Name = "duetCheckBox";
            this.duetCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.duetCheckBox.Size = new System.Drawing.Size(104, 24);
            this.duetCheckBox.TabIndex = 9;
            this.duetCheckBox.Text = "Is Duet";
            this.duetCheckBox.UseVisualStyleBackColor = true;
            this.duetCheckBox.CheckedChanged += new System.EventHandler(this.duetCheckBox_CheckedChanged);
            // 
            // videoGapLabel
            // 
            this.videoGapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.videoGapLabel.Location = new System.Drawing.Point(519, 23);
            this.videoGapLabel.Name = "videoGapLabel";
            this.videoGapLabel.Size = new System.Drawing.Size(85, 23);
            this.videoGapLabel.TabIndex = 3;
            this.videoGapLabel.Text = "Video Gap";
            this.videoGapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bpmLabel
            // 
            this.bpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bpmLabel.Location = new System.Drawing.Point(241, 23);
            this.bpmLabel.Name = "bpmLabel";
            this.bpmLabel.Size = new System.Drawing.Size(85, 23);
            this.bpmLabel.TabIndex = 3;
            this.bpmLabel.Text = "BPM";
            this.bpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gapLabel
            // 
            this.gapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gapLabel.Location = new System.Drawing.Point(9, 23);
            this.gapLabel.Name = "gapLabel";
            this.gapLabel.Size = new System.Drawing.Size(85, 23);
            this.gapLabel.TabIndex = 3;
            this.gapLabel.Text = "Gap";
            this.gapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // duetSinger2TextBox
            // 
            this.duetSinger2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.duetSinger2TextBox.Location = new System.Drawing.Point(266, 86);
            this.duetSinger2TextBox.Name = "duetSinger2TextBox";
            this.duetSinger2TextBox.Size = new System.Drawing.Size(452, 26);
            this.duetSinger2TextBox.TabIndex = 11;
            this.duetSinger2TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // duetSinger1TextBox
            // 
            this.duetSinger1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.duetSinger1TextBox.Location = new System.Drawing.Point(266, 54);
            this.duetSinger1TextBox.Name = "duetSinger1TextBox";
            this.duetSinger1TextBox.Size = new System.Drawing.Size(452, 26);
            this.duetSinger1TextBox.TabIndex = 10;
            this.duetSinger1TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // videoGapNumericUpDown
            // 
            this.videoGapNumericUpDown.DecimalPlaces = 2;
            this.videoGapNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.videoGapNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.videoGapNumericUpDown.Location = new System.Drawing.Point(610, 22);
            this.videoGapNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.videoGapNumericUpDown.Name = "videoGapNumericUpDown";
            this.videoGapNumericUpDown.Size = new System.Drawing.Size(108, 26);
            this.videoGapNumericUpDown.TabIndex = 8;
            this.videoGapNumericUpDown.ValueChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // bpmNumericUpDown
            // 
            this.bpmNumericUpDown.DecimalPlaces = 2;
            this.bpmNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bpmNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.bpmNumericUpDown.Location = new System.Drawing.Point(332, 22);
            this.bpmNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.bpmNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.bpmNumericUpDown.Name = "bpmNumericUpDown";
            this.bpmNumericUpDown.Size = new System.Drawing.Size(108, 26);
            this.bpmNumericUpDown.TabIndex = 7;
            this.bpmNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.bpmNumericUpDown.ValueChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // duetSinger2Label
            // 
            this.duetSinger2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.duetSinger2Label.Location = new System.Drawing.Point(150, 88);
            this.duetSinger2Label.Name = "duetSinger2Label";
            this.duetSinger2Label.Size = new System.Drawing.Size(110, 23);
            this.duetSinger2Label.TabIndex = 3;
            this.duetSinger2Label.Text = "Duet Singer 2";
            this.duetSinger2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gapNumericUpDown
            // 
            this.gapNumericUpDown.DecimalPlaces = 2;
            this.gapNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gapNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.gapNumericUpDown.Location = new System.Drawing.Point(100, 22);
            this.gapNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.gapNumericUpDown.Name = "gapNumericUpDown";
            this.gapNumericUpDown.Size = new System.Drawing.Size(108, 26);
            this.gapNumericUpDown.TabIndex = 6;
            this.gapNumericUpDown.ValueChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // duetSinger1Label
            // 
            this.duetSinger1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.duetSinger1Label.Location = new System.Drawing.Point(150, 54);
            this.duetSinger1Label.Name = "duetSinger1Label";
            this.duetSinger1Label.Size = new System.Drawing.Size(110, 23);
            this.duetSinger1Label.TabIndex = 3;
            this.duetSinger1Label.Text = "Duet Singer 1";
            this.duetSinger1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // songFilesGroupBox
            // 
            this.songFilesGroupBox.Controls.Add(this.videoTextBox);
            this.songFilesGroupBox.Controls.Add(this.mp3TextBox);
            this.songFilesGroupBox.Controls.Add(this.videoEditButton);
            this.songFilesGroupBox.Controls.Add(this.videoPlayButton);
            this.songFilesGroupBox.Controls.Add(this.mp3PlayButton);
            this.songFilesGroupBox.Controls.Add(this.mp3EditButton);
            this.songFilesGroupBox.Controls.Add(this.videoDeleteButton);
            this.songFilesGroupBox.Controls.Add(this.videoLabel);
            this.songFilesGroupBox.Controls.Add(this.mp3DeleteButton);
            this.songFilesGroupBox.Controls.Add(this.mp3Label);
            this.songFilesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.songFilesGroupBox.Location = new System.Drawing.Point(709, 378);
            this.songFilesGroupBox.Name = "songFilesGroupBox";
            this.songFilesGroupBox.Size = new System.Drawing.Size(724, 100);
            this.songFilesGroupBox.TabIndex = 8;
            this.songFilesGroupBox.TabStop = false;
            this.songFilesGroupBox.Text = "Song Files";
            // 
            // videoTextBox
            // 
            this.videoTextBox.Enabled = false;
            this.videoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.videoTextBox.Location = new System.Drawing.Point(100, 62);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.Size = new System.Drawing.Size(504, 26);
            this.videoTextBox.TabIndex = 0;
            this.videoTextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // mp3TextBox
            // 
            this.mp3TextBox.Enabled = false;
            this.mp3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mp3TextBox.Location = new System.Drawing.Point(100, 24);
            this.mp3TextBox.Name = "mp3TextBox";
            this.mp3TextBox.Size = new System.Drawing.Size(504, 26);
            this.mp3TextBox.TabIndex = 0;
            this.mp3TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // videoEditButton
            // 
            this.videoEditButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("videoEditButton.BackgroundImage")));
            this.videoEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoEditButton.Location = new System.Drawing.Point(648, 58);
            this.videoEditButton.Name = "videoEditButton";
            this.videoEditButton.Size = new System.Drawing.Size(32, 32);
            this.videoEditButton.TabIndex = 5;
            this.videoEditButton.TabStop = false;
            this.videoEditButton.UseVisualStyleBackColor = true;
            // 
            // videoPlayButton
            // 
            this.videoPlayButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("videoPlayButton.BackgroundImage")));
            this.videoPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoPlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoPlayButton.Location = new System.Drawing.Point(610, 58);
            this.videoPlayButton.Name = "videoPlayButton";
            this.videoPlayButton.Size = new System.Drawing.Size(32, 32);
            this.videoPlayButton.TabIndex = 5;
            this.videoPlayButton.TabStop = false;
            this.videoPlayButton.UseVisualStyleBackColor = true;
            this.videoPlayButton.Click += new System.EventHandler(this.videoPlayButton_Click);
            // 
            // mp3PlayButton
            // 
            this.mp3PlayButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("mp3PlayButton.BackgroundImage")));
            this.mp3PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mp3PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp3PlayButton.Location = new System.Drawing.Point(610, 20);
            this.mp3PlayButton.Name = "mp3PlayButton";
            this.mp3PlayButton.Size = new System.Drawing.Size(32, 32);
            this.mp3PlayButton.TabIndex = 5;
            this.mp3PlayButton.TabStop = false;
            this.mp3PlayButton.UseVisualStyleBackColor = true;
            this.mp3PlayButton.Click += new System.EventHandler(this.mp3PlayButton_Click);
            // 
            // mp3EditButton
            // 
            this.mp3EditButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("mp3EditButton.BackgroundImage")));
            this.mp3EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mp3EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp3EditButton.Location = new System.Drawing.Point(648, 20);
            this.mp3EditButton.Name = "mp3EditButton";
            this.mp3EditButton.Size = new System.Drawing.Size(32, 32);
            this.mp3EditButton.TabIndex = 5;
            this.mp3EditButton.TabStop = false;
            this.mp3EditButton.UseVisualStyleBackColor = true;
            // 
            // videoDeleteButton
            // 
            this.videoDeleteButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("videoDeleteButton.BackgroundImage")));
            this.videoDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoDeleteButton.Location = new System.Drawing.Point(686, 58);
            this.videoDeleteButton.Name = "videoDeleteButton";
            this.videoDeleteButton.Size = new System.Drawing.Size(32, 32);
            this.videoDeleteButton.TabIndex = 5;
            this.videoDeleteButton.TabStop = false;
            this.videoDeleteButton.UseVisualStyleBackColor = true;
            // 
            // videoLabel
            // 
            this.videoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.videoLabel.Location = new System.Drawing.Point(9, 64);
            this.videoLabel.Name = "videoLabel";
            this.videoLabel.Size = new System.Drawing.Size(85, 23);
            this.videoLabel.TabIndex = 3;
            this.videoLabel.Text = "Video";
            this.videoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mp3DeleteButton
            // 
            this.mp3DeleteButton.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("mp3DeleteButton.BackgroundImage")));
            this.mp3DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mp3DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp3DeleteButton.Location = new System.Drawing.Point(686, 20);
            this.mp3DeleteButton.Name = "mp3DeleteButton";
            this.mp3DeleteButton.Size = new System.Drawing.Size(32, 32);
            this.mp3DeleteButton.TabIndex = 5;
            this.mp3DeleteButton.TabStop = false;
            this.mp3DeleteButton.UseVisualStyleBackColor = true;
            // 
            // mp3Label
            // 
            this.mp3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mp3Label.Location = new System.Drawing.Point(9, 26);
            this.mp3Label.Name = "mp3Label";
            this.mp3Label.Size = new System.Drawing.Size(85, 23);
            this.mp3Label.TabIndex = 3;
            this.mp3Label.Text = "MP3";
            this.mp3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textTabControl
            // 
            this.textTabControl.Controls.Add(this.player1TextTab);
            this.textTabControl.Controls.Add(this.player2TextTab);
            this.textTabControl.Enabled = false;
            this.textTabControl.Location = new System.Drawing.Point(709, 484);
            this.textTabControl.Name = "textTabControl";
            this.textTabControl.SelectedIndex = 0;
            this.textTabControl.Size = new System.Drawing.Size(718, 392);
            this.textTabControl.TabIndex = 9;
            this.textTabControl.TabStop = false;
            this.textTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.textTabControl_Selecting);
            // 
            // player1TextTab
            // 
            this.player1TextTab.Controls.Add(this.player1TextBox);
            this.player1TextTab.Location = new System.Drawing.Point(4, 22);
            this.player1TextTab.Name = "player1TextTab";
            this.player1TextTab.Padding = new System.Windows.Forms.Padding(3);
            this.player1TextTab.Size = new System.Drawing.Size(710, 366);
            this.player1TextTab.TabIndex = 0;
            this.player1TextTab.Text = "Player 1";
            this.player1TextTab.UseVisualStyleBackColor = true;
            // 
            // player1TextBox
            // 
            this.player1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.player1TextBox.Location = new System.Drawing.Point(6, 6);
            this.player1TextBox.Multiline = true;
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.player1TextBox.Size = new System.Drawing.Size(698, 354);
            this.player1TextBox.TabIndex = 12;
            this.player1TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // player2TextTab
            // 
            this.player2TextTab.Controls.Add(this.player2TextBox);
            this.player2TextTab.Location = new System.Drawing.Point(4, 22);
            this.player2TextTab.Name = "player2TextTab";
            this.player2TextTab.Padding = new System.Windows.Forms.Padding(3);
            this.player2TextTab.Size = new System.Drawing.Size(710, 366);
            this.player2TextTab.TabIndex = 1;
            this.player2TextTab.Text = "Player 2";
            this.player2TextTab.UseVisualStyleBackColor = true;
            // 
            // player2TextBox
            // 
            this.player2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.player2TextBox.Location = new System.Drawing.Point(6, 6);
            this.player2TextBox.Multiline = true;
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.player2TextBox.Size = new System.Drawing.Size(698, 354);
            this.player2TextBox.TabIndex = 13;
            this.player2TextBox.TextChanged += new System.EventHandler(this.detailControl_ValueChanged);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            this.toolTip.ShowAlways = true;
            // 
            // openCoverToolStripMenuItem
            // 
            this.openCoverToolStripMenuItem.Name = "openCoverToolStripMenuItem";
            this.openCoverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openCoverToolStripMenuItem.Text = "Open Cover";
            this.openCoverToolStripMenuItem.Click += new System.EventHandler(this.coverPictureBox_DoubleClick);
            // 
            // openMP3ToolStripMenuItem
            // 
            this.openMP3ToolStripMenuItem.Name = "openMP3ToolStripMenuItem";
            this.openMP3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openMP3ToolStripMenuItem.Text = "Open MP3";
            this.openMP3ToolStripMenuItem.Click += new System.EventHandler(this.mp3PlayButton_Click);
            // 
            // openVideoToolStripMenuItem
            // 
            this.openVideoToolStripMenuItem.Name = "openVideoToolStripMenuItem";
            this.openVideoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openVideoToolStripMenuItem.Text = "Open Video";
            this.openVideoToolStripMenuItem.Click += new System.EventHandler(this.videoPlayButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 888);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraStar Deluxe Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.coverPictureBox)).EndInit();
            this.songInfoGroupBox.ResumeLayout(false);
            this.songInfoGroupBox.PerformLayout();
            this.songSettingsGroupBox.ResumeLayout(false);
            this.songSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.videoGapNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bpmNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.gapNumericUpDown)).EndInit();
            this.songFilesGroupBox.ResumeLayout(false);
            this.songFilesGroupBox.PerformLayout();
            this.textTabControl.ResumeLayout(false);
            this.player1TextTab.ResumeLayout(false);
            this.player1TextTab.PerformLayout();
            this.player2TextTab.ResumeLayout(false);
            this.player2TextTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem openCoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMP3ToolStripMenuItem;
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
        private System.Windows.Forms.Button editCoverButton;
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
        private System.Windows.Forms.Button deleteCoverButton;
        private System.Windows.Forms.Button mp3DeleteButton;

        private System.Windows.Forms.PictureBox coverPictureBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ColumnHeader artistColumn;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.TextBox titleTextBox;

        private System.Windows.Forms.ListView songListView;

        private System.Windows.Forms.MenuStrip mainMenuStrip;

        #endregion
    }
}