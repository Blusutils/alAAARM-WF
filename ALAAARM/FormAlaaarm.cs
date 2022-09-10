using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace alAAARM {
    public partial class FormAlaaarm : System.Windows.Forms.Form {
        DateTime targetTime;
        TreeNode selectedAlarm;

        public FormAlaaarm() {
            InitializeComponent();
            setTargetTime(DateTime.Now);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            relativesCheckBox.Checked = !Config.Instance.useRelativeTime;
            relativesCheckBox.Checked = !relativesCheckBox.Checked;
            //this.alarmTitle.Location = new System.Drawing.Point(this.Size.Width / 2, 10);
        }

        void setTargetTime(DateTime time) {
            targetTime = time;
            dateTimePicker.Value = time;
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
            }
            var alarm = new Alarm($"alarm{Alarm.GetAlarms().ToArray().Length}", targetTime, targnode, true, new AudioFileReader(path));
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
            setTargetTime(DateTime.Now);
        }

        private void resetToNowToolStripMenuItem_Click(object sender, EventArgs e) {
            setTargetTime(DateTime.Now);
        }

        private void plus30SecButton_Click(object sender, EventArgs e) {
            setTargetTime(DateTime.Now.AddSeconds(30));
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e) {
            plus30SecButton_Click(null, null);
        }

        private void plus1MinButton_Click(object sender, EventArgs e) {
            setTargetTime(DateTime.Now.AddMinutes(1));
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            plus1MinButton_Click(null, null);
        }

        private void plus5MinButton_Click(object sender, EventArgs e) {
            setTargetTime(DateTime.Now.AddMinutes(5));
        }
        private void minToolStripMenuItem_Click(object sender, EventArgs e) {
            plus5MinButton_Click(null, null);
        }

        private void plus10MinButton_Click(object sender, EventArgs e) {
            setTargetTime(DateTime.Now.AddMinutes(10));
        }
        private void minToolStripMenuItem1_Click(object sender, EventArgs e) {
            plus10MinButton_Click(null, null);
        }

        private void plus30MinButton_Click(object sender, EventArgs e) {
            setTargetTime(DateTime.Now.AddMinutes(30));
        }
        private void minToolStripMenuItem2_Click(object sender, EventArgs e) {
            plus30MinButton_Click(null, null);
        }

        private void plus1HourButton_Click(object sender, EventArgs e) {
            setTargetTime(DateTime.Now.AddHours(1));
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

        private void openSettingsButton_Click(object sender, EventArgs e) {
            new SettingsForm().ShowDialog();
        }
    }
}
