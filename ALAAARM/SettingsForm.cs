using System;
using System.Linq;
using System.Windows.Forms;

namespace alAAARM {
    public partial class SettingsForm : Form {
        public SettingsForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            alarmSoundVolumeTrackBar.Value = Config.Instance.soundVolume;
            volumePercentageLabel.Text = $"{alarmSoundVolumeTrackBar.Value}%";
            alarmSoundSelectComboButton.Items.Clear();
            alarmSoundSelectComboButton.Items.AddRange(Config.alarmSoundsPathes.Keys.ToArray());
            alarmSoundSelectComboButton.SelectedItem = Config.Instance.selectedSound;
            alarmCustomSoundFileDialogButton.Enabled
                = alarmCustomSoundPathLabel.Enabled
                = alarmCustomSoundSaveButton.Enabled
                = alarmCustomSoundTextBox.Enabled
                = alarmSoundSelectComboButton.SelectedItem.ToString() == "Custom";
            alarmCustomSoundTextBox.Text = Config.Instance.customSoundPath;
        }

        private void alarmSoundVolumeTrackBar_Scroll(object sender, EventArgs e) {
            Config.Instance.soundVolume = alarmSoundVolumeTrackBar.Value;
            volumePercentageLabel.Text = $"{alarmSoundVolumeTrackBar.Value}%";
        }

        private void alarmSoundSelectComboButton_SelectedIndexChanged(object sender, EventArgs e) {
            alarmCustomSoundFileDialogButton.Enabled
                = alarmCustomSoundPathLabel.Enabled
                = alarmCustomSoundSaveButton.Enabled
                = alarmCustomSoundTextBox.Enabled
                = alarmSoundSelectComboButton.SelectedItem.ToString() == "Custom";
            Config.Instance.selectedSound = alarmSoundSelectComboButton.SelectedItem.ToString();
        }

        private void alarmCustomSoundFileDialogButton_Click(object sender, EventArgs e) {
            using (var fd = new OpenFileDialog()) {
                fd.Filter = "MP3 sound (*.mp3)|*.mp3";
                var res = fd.ShowDialog();
                if (res == DialogResult.OK) {
                    alarmCustomSoundTextBox.Text = fd.FileName;
                }
            }
        }

        private void alarmCustomSoundSaveButton_Click(object sender, EventArgs e) {
            Config.Instance.customSoundPath = alarmCustomSoundTextBox.Text;
        }
    }
}
