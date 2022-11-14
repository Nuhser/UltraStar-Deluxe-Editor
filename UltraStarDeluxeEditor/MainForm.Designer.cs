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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "Test", "Foo" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.songListView = new System.Windows.Forms.ListView();
            this.titleColumn = new System.Windows.Forms.ColumnHeader();
            this.artistColumn = new System.Windows.Forms.ColumnHeader();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.songInfoGroupBox = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.songInfoGroupBox.SuspendLayout();
            this.songSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoGapNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpmNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gapNumericUpDown)).BeginInit();
            this.songFilesGroupBox.SuspendLayout();
            this.textTabControl.SuspendLayout();
            this.player1TextTab.SuspendLayout();
            this.player2TextTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1123, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // songListView
            // 
            this.songListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.titleColumn, this.artistColumn });
            this.songListView.FullRowSelect = true;
            this.songListView.GridLines = true;
            this.songListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            this.songListView.Location = new System.Drawing.Point(12, 27);
            this.songListView.MultiSelect = false;
            this.songListView.Name = "songListView";
            this.songListView.Size = new System.Drawing.Size(369, 849);
            this.songListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.songListView.TabIndex = 1;
            this.songListView.TabStop = false;
            this.songListView.UseCompatibleStateImageBehavior = false;
            this.songListView.View = System.Windows.Forms.View.Details;
            // 
            // titleColumn
            // 
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 211;
            // 
            // artistColumn
            // 
            this.artistColumn.Text = "Artist";
            this.artistColumn.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.coverPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("coverPictureBox.Image")));
            this.coverPictureBox.InitialImage = null;
            this.coverPictureBox.Location = new System.Drawing.Point(568, 22);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(150, 150);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 4;
            this.coverPictureBox.TabStop = false;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistTextBox.Location = new System.Drawing.Point(100, 56);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(452, 26);
            this.artistTextBox.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.Location = new System.Drawing.Point(9, 58);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(85, 23);
            this.artistLabel.TabIndex = 3;
            this.artistLabel.Text = "Artist";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteCoverButton
            // 
            this.deleteCoverButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteCoverButton.BackgroundImage")));
            this.deleteCoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteCoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCoverButton.Location = new System.Drawing.Point(686, 180);
            this.deleteCoverButton.Name = "deleteCoverButton";
            this.deleteCoverButton.Size = new System.Drawing.Size(32, 32);
            this.deleteCoverButton.TabIndex = 5;
            this.deleteCoverButton.TabStop = false;
            this.deleteCoverButton.UseVisualStyleBackColor = true;
            // 
            // editCoverButton
            // 
            this.editCoverButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editCoverButton.BackgroundImage")));
            this.editCoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editCoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCoverButton.Location = new System.Drawing.Point(648, 180);
            this.editCoverButton.Name = "editCoverButton";
            this.editCoverButton.Size = new System.Drawing.Size(32, 32);
            this.editCoverButton.TabIndex = 5;
            this.editCoverButton.TabStop = false;
            this.editCoverButton.UseVisualStyleBackColor = true;
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(9, 91);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(85, 23);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageTextBox.Location = new System.Drawing.Point(100, 120);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(452, 26);
            this.languageTextBox.TabIndex = 3;
            // 
            // languageLabel
            // 
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(9, 123);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(85, 23);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "Language";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTextBox.Location = new System.Drawing.Point(100, 152);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(452, 26);
            this.genreTextBox.TabIndex = 4;
            // 
            // genreLabel
            // 
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(9, 155);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(85, 23);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // editionTextBox
            // 
            this.editionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionTextBox.Location = new System.Drawing.Point(100, 184);
            this.editionTextBox.Name = "editionTextBox";
            this.editionTextBox.Size = new System.Drawing.Size(452, 26);
            this.editionTextBox.TabIndex = 5;
            // 
            // editionLabel
            // 
            this.editionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionLabel.Location = new System.Drawing.Point(9, 186);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(85, 23);
            this.editionLabel.TabIndex = 3;
            this.editionLabel.Text = "Edition";
            this.editionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearNumericUpDown.Location = new System.Drawing.Point(100, 89);
            this.yearNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(452, 26);
            this.yearNumericUpDown.TabIndex = 2;
            this.yearNumericUpDown.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // songInfoGroupBox
            // 
            this.songInfoGroupBox.Controls.Add(this.textBox1);
            this.songInfoGroupBox.Controls.Add(this.editCoverButton);
            this.songInfoGroupBox.Controls.Add(this.deleteCoverButton);
            this.songInfoGroupBox.Controls.Add(this.yearNumericUpDown);
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
            this.songInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfoGroupBox.Location = new System.Drawing.Point(387, 27);
            this.songInfoGroupBox.Name = "songInfoGroupBox";
            this.songInfoGroupBox.Size = new System.Drawing.Size(724, 218);
            this.songInfoGroupBox.TabIndex = 6;
            this.songInfoGroupBox.TabStop = false;
            this.songInfoGroupBox.Text = "Song Info";
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
            this.songSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songSettingsGroupBox.Location = new System.Drawing.Point(387, 251);
            this.songSettingsGroupBox.Name = "songSettingsGroupBox";
            this.songSettingsGroupBox.Size = new System.Drawing.Size(724, 121);
            this.songSettingsGroupBox.TabIndex = 7;
            this.songSettingsGroupBox.TabStop = false;
            this.songSettingsGroupBox.Text = "Song Settings";
            // 
            // duetCheckBox
            // 
            this.duetCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duetCheckBox.Location = new System.Drawing.Point(9, 54);
            this.duetCheckBox.Name = "duetCheckBox";
            this.duetCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.duetCheckBox.Size = new System.Drawing.Size(104, 24);
            this.duetCheckBox.TabIndex = 4;
            this.duetCheckBox.Text = "Is Duet";
            this.duetCheckBox.UseVisualStyleBackColor = true;
            this.duetCheckBox.CheckedChanged += new System.EventHandler(this.duetCheckBox_CheckedChanged);
            // 
            // videoGapLabel
            // 
            this.videoGapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoGapLabel.Location = new System.Drawing.Point(519, 23);
            this.videoGapLabel.Name = "videoGapLabel";
            this.videoGapLabel.Size = new System.Drawing.Size(85, 23);
            this.videoGapLabel.TabIndex = 3;
            this.videoGapLabel.Text = "Video Gap";
            this.videoGapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bpmLabel
            // 
            this.bpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmLabel.Location = new System.Drawing.Point(241, 23);
            this.bpmLabel.Name = "bpmLabel";
            this.bpmLabel.Size = new System.Drawing.Size(85, 23);
            this.bpmLabel.TabIndex = 3;
            this.bpmLabel.Text = "BPM";
            this.bpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gapLabel
            // 
            this.gapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gapLabel.Location = new System.Drawing.Point(9, 23);
            this.gapLabel.Name = "gapLabel";
            this.gapLabel.Size = new System.Drawing.Size(85, 23);
            this.gapLabel.TabIndex = 3;
            this.gapLabel.Text = "Gap";
            this.gapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // duetSinger2TextBox
            // 
            this.duetSinger2TextBox.Enabled = false;
            this.duetSinger2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duetSinger2TextBox.Location = new System.Drawing.Point(266, 86);
            this.duetSinger2TextBox.Name = "duetSinger2TextBox";
            this.duetSinger2TextBox.Size = new System.Drawing.Size(452, 26);
            this.duetSinger2TextBox.TabIndex = 1;
            // 
            // duetSinger1TextBox
            // 
            this.duetSinger1TextBox.Enabled = false;
            this.duetSinger1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duetSinger1TextBox.Location = new System.Drawing.Point(266, 54);
            this.duetSinger1TextBox.Name = "duetSinger1TextBox";
            this.duetSinger1TextBox.Size = new System.Drawing.Size(452, 26);
            this.duetSinger1TextBox.TabIndex = 1;
            // 
            // videoGapNumericUpDown
            // 
            this.videoGapNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoGapNumericUpDown.Location = new System.Drawing.Point(610, 22);
            this.videoGapNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.videoGapNumericUpDown.Name = "videoGapNumericUpDown";
            this.videoGapNumericUpDown.Size = new System.Drawing.Size(108, 26);
            this.videoGapNumericUpDown.TabIndex = 2;
            this.videoGapNumericUpDown.ThousandsSeparator = true;
            // 
            // bpmNumericUpDown
            // 
            this.bpmNumericUpDown.DecimalPlaces = 2;
            this.bpmNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.bpmNumericUpDown.Location = new System.Drawing.Point(332, 22);
            this.bpmNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.bpmNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.bpmNumericUpDown.Name = "bpmNumericUpDown";
            this.bpmNumericUpDown.Size = new System.Drawing.Size(108, 26);
            this.bpmNumericUpDown.TabIndex = 2;
            this.bpmNumericUpDown.ThousandsSeparator = true;
            this.bpmNumericUpDown.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // duetSinger2Label
            // 
            this.duetSinger2Label.Enabled = false;
            this.duetSinger2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duetSinger2Label.Location = new System.Drawing.Point(150, 88);
            this.duetSinger2Label.Name = "duetSinger2Label";
            this.duetSinger2Label.Size = new System.Drawing.Size(110, 23);
            this.duetSinger2Label.TabIndex = 3;
            this.duetSinger2Label.Text = "Duet Singer 2";
            this.duetSinger2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gapNumericUpDown
            // 
            this.gapNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gapNumericUpDown.Location = new System.Drawing.Point(100, 22);
            this.gapNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.gapNumericUpDown.Name = "gapNumericUpDown";
            this.gapNumericUpDown.Size = new System.Drawing.Size(108, 26);
            this.gapNumericUpDown.TabIndex = 2;
            this.gapNumericUpDown.ThousandsSeparator = true;
            // 
            // duetSinger1Label
            // 
            this.duetSinger1Label.Enabled = false;
            this.duetSinger1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.songFilesGroupBox.Controls.Add(this.mp3EditButton);
            this.songFilesGroupBox.Controls.Add(this.videoDeleteButton);
            this.songFilesGroupBox.Controls.Add(this.videoLabel);
            this.songFilesGroupBox.Controls.Add(this.mp3DeleteButton);
            this.songFilesGroupBox.Controls.Add(this.mp3Label);
            this.songFilesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songFilesGroupBox.Location = new System.Drawing.Point(387, 378);
            this.songFilesGroupBox.Name = "songFilesGroupBox";
            this.songFilesGroupBox.Size = new System.Drawing.Size(724, 100);
            this.songFilesGroupBox.TabIndex = 8;
            this.songFilesGroupBox.TabStop = false;
            this.songFilesGroupBox.Text = "Song Files";
            // 
            // videoTextBox
            // 
            this.videoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoTextBox.Location = new System.Drawing.Point(100, 62);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.Size = new System.Drawing.Size(542, 26);
            this.videoTextBox.TabIndex = 0;
            // 
            // mp3TextBox
            // 
            this.mp3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp3TextBox.Location = new System.Drawing.Point(100, 24);
            this.mp3TextBox.Name = "mp3TextBox";
            this.mp3TextBox.Size = new System.Drawing.Size(542, 26);
            this.mp3TextBox.TabIndex = 0;
            // 
            // videoEditButton
            // 
            this.videoEditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("videoEditButton.BackgroundImage")));
            this.videoEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoEditButton.Location = new System.Drawing.Point(648, 58);
            this.videoEditButton.Name = "videoEditButton";
            this.videoEditButton.Size = new System.Drawing.Size(32, 32);
            this.videoEditButton.TabIndex = 5;
            this.videoEditButton.TabStop = false;
            this.videoEditButton.UseVisualStyleBackColor = true;
            // 
            // mp3EditButton
            // 
            this.mp3EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mp3EditButton.BackgroundImage")));
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
            this.videoDeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("videoDeleteButton.BackgroundImage")));
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
            this.videoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoLabel.Location = new System.Drawing.Point(9, 64);
            this.videoLabel.Name = "videoLabel";
            this.videoLabel.Size = new System.Drawing.Size(85, 23);
            this.videoLabel.TabIndex = 3;
            this.videoLabel.Text = "Video";
            this.videoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mp3DeleteButton
            // 
            this.mp3DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mp3DeleteButton.BackgroundImage")));
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
            this.mp3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textTabControl.Location = new System.Drawing.Point(387, 484);
            this.textTabControl.Name = "textTabControl";
            this.textTabControl.SelectedIndex = 0;
            this.textTabControl.Size = new System.Drawing.Size(718, 392);
            this.textTabControl.TabIndex = 9;
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
            this.player1TextBox.Location = new System.Drawing.Point(6, 6);
            this.player1TextBox.Multiline = true;
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(698, 354);
            this.player1TextBox.TabIndex = 0;
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
            this.player2TextBox.Enabled = false;
            this.player2TextBox.Location = new System.Drawing.Point(6, 6);
            this.player2TextBox.Multiline = true;
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(698, 354);
            this.player2TextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 888);
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
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.songInfoGroupBox.ResumeLayout(false);
            this.songInfoGroupBox.PerformLayout();
            this.songSettingsGroupBox.ResumeLayout(false);
            this.songSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoGapNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpmNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gapNumericUpDown)).EndInit();
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

        private System.Windows.Forms.NumericUpDown yearNumericUpDown;

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
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListView songListView;

        private System.Windows.Forms.MenuStrip mainMenuStrip;

        #endregion
    }
}