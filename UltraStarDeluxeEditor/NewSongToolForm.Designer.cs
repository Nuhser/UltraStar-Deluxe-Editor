using System.ComponentModel;

namespace UltraStarDeluxeEditor {
    partial class NewSongToolForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSongToolForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.songDirectoryComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.songDirectoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // songDirectoryComboBox
            // 
            this.songDirectoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.songDirectoryComboBox, "songDirectoryComboBox");
            this.songDirectoryComboBox.FormattingEnabled = true;
            this.songDirectoryComboBox.Name = "songDirectoryComboBox";
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // artistTextBox
            // 
            resources.ApplyResources(this.artistTextBox, "artistTextBox");
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // artistLabel
            // 
            resources.ApplyResources(this.artistLabel, "artistLabel");
            this.artistLabel.Name = "artistLabel";
            // 
            // songDirectoryLabel
            // 
            resources.ApplyResources(this.songDirectoryLabel, "songDirectoryLabel");
            this.songDirectoryLabel.Name = "songDirectoryLabel";
            // 
            // NewSongToolForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.songDirectoryLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.songDirectoryComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewSongToolForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label songDirectoryLabel;

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.ComboBox songDirectoryComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox artistTextBox;

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;

        #endregion
    }
}