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
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.okButton.Location = new System.Drawing.Point(276, 107);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 28);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cancelButton.Location = new System.Drawing.Point(369, 107);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 28);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // songDirectoryComboBox
            // 
            this.songDirectoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.songDirectoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.songDirectoryComboBox.FormattingEnabled = true;
            this.songDirectoryComboBox.ItemHeight = 13;
            this.songDirectoryComboBox.Location = new System.Drawing.Point(126, 70);
            this.songDirectoryComboBox.Name = "songDirectoryComboBox";
            this.songDirectoryComboBox.Size = new System.Drawing.Size(330, 21);
            this.songDirectoryComboBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.titleTextBox.Location = new System.Drawing.Point(126, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(330, 23);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // artistTextBox
            // 
            this.artistTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.artistTextBox.Location = new System.Drawing.Point(126, 41);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(330, 23);
            this.artistTextBox.TabIndex = 1;
            this.artistTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(108, 23);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // artistLabel
            // 
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.artistLabel.Location = new System.Drawing.Point(12, 41);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(108, 23);
            this.artistLabel.TabIndex = 5;
            this.artistLabel.Text = "Artist";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // songDirectoryLabel
            // 
            this.songDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.songDirectoryLabel.Location = new System.Drawing.Point(12, 68);
            this.songDirectoryLabel.Name = "songDirectoryLabel";
            this.songDirectoryLabel.Size = new System.Drawing.Size(108, 23);
            this.songDirectoryLabel.TabIndex = 5;
            this.songDirectoryLabel.Text = "Song Directory";
            this.songDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewSongToolForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(468, 147);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Song";
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