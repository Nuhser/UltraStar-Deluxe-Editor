using System;
using System.Windows.Forms;

namespace UltraStarDeluxeEditor {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            songInfoGroupBox.Enabled = false;
            songSettingsGroupBox.Enabled = false;
            songFilesGroupBox.Enabled = false;
            textTabControl.Enabled = false;
            player2TextTab.Enabled = false;
        }

        private void initSongListView() {
            
        }

        private void duetCheckBox_CheckedChanged(object sender, EventArgs e) {
            duetSinger1Label.Enabled = duetCheckBox.Checked;
            duetSinger1TextBox.Enabled = duetCheckBox.Checked;
            duetSinger2Label.Enabled = duetCheckBox.Checked;
            duetSinger2TextBox.Enabled = duetCheckBox.Checked;
            player2TextTab.Enabled = duetCheckBox.Checked;
        }
    }
}