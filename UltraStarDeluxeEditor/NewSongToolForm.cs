using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UltraStarDeluxeEditor.Configuration;
using UltraStarDeluxeEditor.Properties;

namespace UltraStarDeluxeEditor {
    public partial class NewSongToolForm : Form {
        private readonly Color TEXT_BOX_ERROR_COLOR = Color.FromArgb(255, 204, 204);

        public NewSongToolForm() {
            InitializeComponent();

            var songDirectories = ConfigService.GetSongDirectories();
            songDirectoryComboBox.DataSource = songDirectories.Where(Directory.Exists).ToList();
        }

        public string Title { get; private set; }
        public string Artist { get; private set; }
        public string SongDirectory { get; private set; }

        private void okButton_Click(object sender, EventArgs e) {
            titleTextBox.BackColor =
                string.IsNullOrWhiteSpace(titleTextBox.Text) ? TEXT_BOX_ERROR_COLOR : SystemColors.Window;

            artistTextBox.BackColor = string.IsNullOrWhiteSpace(artistTextBox.Text)
                ? TEXT_BOX_ERROR_COLOR
                : SystemColors.Window;

            if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(artistTextBox.Text)) {
                MessageBox.Show(Resources.newSongTitleOrArtistMissingErrorMessage, Resources.errorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Title = titleTextBox.Text;
            Artist = artistTextBox.Text;
            SongDirectory = songDirectoryComboBox.SelectedValue.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e) {
            if (sender is TextBox textBox && textBox.BackColor == TEXT_BOX_ERROR_COLOR &&
                !string.IsNullOrWhiteSpace(textBox.Text)) {
                textBox.BackColor = SystemColors.Window;
            }
        }
    }
}