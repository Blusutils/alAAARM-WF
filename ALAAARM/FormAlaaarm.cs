using NAudio.Wave;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace alAAARM {
    public partial class FormAlaaarm : System.Windows.Forms.Form {
        DateTime targetTime = DateTime.Now;
        TreeNode selectedAlarm;
        TimeSpan relativeTimeContainer;

        public FormAlaaarm() {
            InitializeComponent();
            resetTargetTime();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            relativesCheckBox.Checked = !Config.Instance.useRelativeTime;
            relativesCheckBox.Checked = !relativesCheckBox.Checked;
            repeatCheckBox.Checked = Config.Instance.repeatSound;
            //this.alarmTitle.Location = new System.Drawing.Point(this.Size.Width / 2, 10);
            //Int32.MaxValue;
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
        /// <summary>
        /// Set target time from <see cref="TimeSpan"/>
        /// </summary>
        /// <param name="time"></param>
        void setTargetTime(TimeSpan time) {
            targetTime += time;
            dateTimePicker.Value = targetTime;
            relativeTimeContainer += time;
            relativeTimeDisplayLabel.Text = $"{(int)relativeTimeContainer.TotalHours}:{relativeTimeContainer.Minutes}:{relativeTimeContainer.Seconds}";
        }
        /// <summary>
        /// Reset target time
        /// </summary>
        void resetTargetTime() {
            targetTime = DateTime.Now;
            dateTimePicker.Value = targetTime;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e) {
            targetTime = dateTimePicker.Value;
        }

        private void setAlarmButton_Click(object sender, EventArgs e) {
            if (targetTime == null || targetTime < DateTime.Now) {
                MessageBox.Show("Picked date is invalid.", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var targnode = treeView1.Nodes.Add($"Alarm {targetTime}");
            string path;
            if (!Config.alarmSoundsPathes.TryGetValue(Config.Instance.selectedSound, out path) || path == "" || !File.Exists(path)) {
                MessageBox.Show("Path of selected sound is empty/not exists/invalid. Sound was reseted to \"Beep Beep Beep\"", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Config.Instance.selectedSound = "Beep Beep Beep";
                path = Config.alarmSoundsPathes["Beep Beep Beep"];
                alarmSoundSelectComboButton.SelectedIndex = alarmSoundSelectComboButton.Items.Count-1;
            }
            var alarm = new Alarm($"alarm{Alarm.GetAlarms().ToArray().Length}", targetTime, targnode, Config.Instance.repeatSound, new AudioFileReader(path), Config.Instance.soundVolume);
            Alarm.AddAlarm(alarm, true);
            Alarm.AlarmStartEvent += (Alarm target) => {
                //TopMost = true;
                var r = MessageBox.Show("ALARM ALARM alAAARM!", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (r == DialogResult.OK) {
                    //TopMost = false;
                    Alarm.RemoveAlarm(alarm);
                }
            };
        }

        private void resetToNowButton_Click(object sender, EventArgs e) {
            resetTargetTime();
            relativeTimeDisplayLabel.Text = "0:0:0";
            relativeTimeContainer = TimeSpan.Zero;
        }

        private void resetToNowToolStripMenuItem_Click(object sender, EventArgs e) {
            resetToNowButton_Click(null, null);
        }

        private void plus30SecButton_Click(object sender, EventArgs e) {
            setTargetTime(TimeSpan.FromSeconds(30));
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e) {
            plus30SecButton_Click(null, null);
        }

        private void plus1MinButton_Click(object sender, EventArgs e) {
            setTargetTime(TimeSpan.FromMinutes(1));
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            plus1MinButton_Click(null, null);
        }

        private void plus5MinButton_Click(object sender, EventArgs e) {
            setTargetTime(TimeSpan.FromMinutes(5));
        }
        private void minToolStripMenuItem_Click(object sender, EventArgs e) {
            plus5MinButton_Click(null, null);
        }

        private void plus10MinButton_Click(object sender, EventArgs e) {
            setTargetTime(TimeSpan.FromMinutes(10));
        }
        private void minToolStripMenuItem1_Click(object sender, EventArgs e) {
            plus10MinButton_Click(null, null);
        }

        private void plus30MinButton_Click(object sender, EventArgs e) {
            setTargetTime(TimeSpan.FromMinutes(30));
        }
        private void minToolStripMenuItem2_Click(object sender, EventArgs e) {
            plus30MinButton_Click(null, null);
        }

        private void plus1HourButton_Click(object sender, EventArgs e) {
            setTargetTime(TimeSpan.FromHours(1));
        }
        private void hToolStripMenuItem_Click(object sender, EventArgs e) {
            plus1HourButton_Click(null, null);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            selectedAlarm = treeView1.SelectedNode;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (selectedAlarm != null)
                Alarm.RemoveAlarm(Alarm.FindAlarm(selectedAlarm));
            else MessageBox.Show("Alarm isn't selected", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void relativesCheckBox_CheckedChanged(object sender, EventArgs e) {
            dateTimePicker.Enabled = !relativesCheckBox.Checked;
            Config.Instance.useRelativeTime
                = plus10MinButton.Enabled
                = plus1HourButton.Enabled
                = plus1MinButton.Enabled
                = plus30MinButton.Enabled
                = plus30SecButton.Enabled
                = plus5MinButton.Enabled
                = relativesCheckBox.Checked;
        }

        private void modifyButton_Click(object sender, EventArgs e) {
            if (selectedAlarm == null) {
                MessageBox.Show("Alarm isn't selected", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var alarmToChange = Alarm.FindAlarm(selectedAlarm);
            if (alarmToChange != null) {
                if (targetTime == null || targetTime < DateTime.Now) {
                    MessageBox.Show("Picked date is invalid.", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                alarmToChange.WhenAlarmStart = targetTime;
                alarmToChange.AlarmName = $"alarm{Alarm.GetAlarms().IndexOf(alarmToChange)}";
                alarmToChange.AssociatedNodeInForm.Text = $"Alarm {targetTime}";
            }
        }

        private void alarmSoundVolumeTrackBar_Scroll(object sender, EventArgs e) {
            Config.Instance.soundVolume = (byte)alarmSoundVolumeTrackBar.Value;
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

        private void repeatCheckBox_CheckedChanged(object sender, EventArgs e) {
           Config.Instance.repeatSound = repeatCheckBox.Checked;
        }
    }
}
