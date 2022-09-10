namespace alAAARM {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.alarmCustomSoundTextBox = new System.Windows.Forms.TextBox();
            this.alarmCustomSoundFileDialogButton = new System.Windows.Forms.Button();
            this.alarmCustomSoundPathLabel = new System.Windows.Forms.Label();
            this.alarmSoundVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.alarmSoundVolumeLabel = new System.Windows.Forms.Label();
            this.volumePercentageLabel = new System.Windows.Forms.Label();
            this.alarmSoundSelectComboButton = new System.Windows.Forms.ComboBox();
            this.alarmSoundSelectLabel = new System.Windows.Forms.Label();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.alarmCustomSoundSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alarmSoundVolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // alarmCustomSoundTextBox
            // 
            this.alarmCustomSoundTextBox.Location = new System.Drawing.Point(9, 160);
            this.alarmCustomSoundTextBox.Name = "alarmCustomSoundTextBox";
            this.alarmCustomSoundTextBox.Size = new System.Drawing.Size(269, 20);
            this.alarmCustomSoundTextBox.TabIndex = 1;
            // 
            // alarmCustomSoundFileDialogButton
            // 
            this.alarmCustomSoundFileDialogButton.Location = new System.Drawing.Point(284, 160);
            this.alarmCustomSoundFileDialogButton.Name = "alarmCustomSoundFileDialogButton";
            this.alarmCustomSoundFileDialogButton.Size = new System.Drawing.Size(24, 20);
            this.alarmCustomSoundFileDialogButton.TabIndex = 2;
            this.alarmCustomSoundFileDialogButton.Text = "...";
            this.alarmCustomSoundFileDialogButton.UseVisualStyleBackColor = true;
            this.alarmCustomSoundFileDialogButton.Click += new System.EventHandler(this.alarmCustomSoundFileDialogButton_Click);
            // 
            // alarmCustomSoundPathLabel
            // 
            this.alarmCustomSoundPathLabel.AutoSize = true;
            this.alarmCustomSoundPathLabel.Location = new System.Drawing.Point(9, 141);
            this.alarmCustomSoundPathLabel.Name = "alarmCustomSoundPathLabel";
            this.alarmCustomSoundPathLabel.Size = new System.Drawing.Size(98, 13);
            this.alarmCustomSoundPathLabel.TabIndex = 3;
            this.alarmCustomSoundPathLabel.Text = "Custom sound path";
            // 
            // alarmSoundVolumeTrackBar
            // 
            this.alarmSoundVolumeTrackBar.Location = new System.Drawing.Point(9, 28);
            this.alarmSoundVolumeTrackBar.Maximum = 100;
            this.alarmSoundVolumeTrackBar.Name = "alarmSoundVolumeTrackBar";
            this.alarmSoundVolumeTrackBar.Size = new System.Drawing.Size(158, 45);
            this.alarmSoundVolumeTrackBar.TabIndex = 4;
            this.alarmSoundVolumeTrackBar.Scroll += new System.EventHandler(this.alarmSoundVolumeTrackBar_Scroll);
            // 
            // alarmSoundVolumeLabel
            // 
            this.alarmSoundVolumeLabel.AutoSize = true;
            this.alarmSoundVolumeLabel.Location = new System.Drawing.Point(12, 9);
            this.alarmSoundVolumeLabel.Name = "alarmSoundVolumeLabel";
            this.alarmSoundVolumeLabel.Size = new System.Drawing.Size(102, 13);
            this.alarmSoundVolumeLabel.TabIndex = 5;
            this.alarmSoundVolumeLabel.Text = "Alarm sound volume";
            // 
            // volumePercentageLabel
            // 
            this.volumePercentageLabel.AutoSize = true;
            this.volumePercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumePercentageLabel.Location = new System.Drawing.Point(174, 28);
            this.volumePercentageLabel.Name = "volumePercentageLabel";
            this.volumePercentageLabel.Size = new System.Drawing.Size(39, 17);
            this.volumePercentageLabel.TabIndex = 6;
            this.volumePercentageLabel.Text = "%s%";
            // 
            // alarmSoundSelectComboButton
            // 
            this.alarmSoundSelectComboButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alarmSoundSelectComboButton.FormattingEnabled = true;
            this.alarmSoundSelectComboButton.Location = new System.Drawing.Point(9, 108);
            this.alarmSoundSelectComboButton.Name = "alarmSoundSelectComboButton";
            this.alarmSoundSelectComboButton.Size = new System.Drawing.Size(121, 21);
            this.alarmSoundSelectComboButton.TabIndex = 7;
            this.alarmSoundSelectComboButton.SelectedIndexChanged += new System.EventHandler(this.alarmSoundSelectComboButton_SelectedIndexChanged);
            // 
            // alarmSoundSelectLabel
            // 
            this.alarmSoundSelectLabel.AutoSize = true;
            this.alarmSoundSelectLabel.Location = new System.Drawing.Point(9, 89);
            this.alarmSoundSelectLabel.Name = "alarmSoundSelectLabel";
            this.alarmSoundSelectLabel.Size = new System.Drawing.Size(38, 13);
            this.alarmSoundSelectLabel.TabIndex = 8;
            this.alarmSoundSelectLabel.Text = "Sound";
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.noticeLabel.Location = new System.Drawing.Point(53, 249);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(214, 13);
            this.noticeLabel.TabIndex = 9;
            this.noticeLabel.Text = "All settings are applied automatically";
            this.noticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alarmCustomSoundSaveButton
            // 
            this.alarmCustomSoundSaveButton.Location = new System.Drawing.Point(9, 187);
            this.alarmCustomSoundSaveButton.Name = "alarmCustomSoundSaveButton";
            this.alarmCustomSoundSaveButton.Size = new System.Drawing.Size(75, 23);
            this.alarmCustomSoundSaveButton.TabIndex = 10;
            this.alarmCustomSoundSaveButton.Text = "Save";
            this.alarmCustomSoundSaveButton.UseVisualStyleBackColor = true;
            this.alarmCustomSoundSaveButton.Click += new System.EventHandler(this.alarmCustomSoundSaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 276);
            this.Controls.Add(this.alarmCustomSoundSaveButton);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.alarmSoundSelectLabel);
            this.Controls.Add(this.alarmSoundSelectComboButton);
            this.Controls.Add(this.volumePercentageLabel);
            this.Controls.Add(this.alarmSoundVolumeLabel);
            this.Controls.Add(this.alarmSoundVolumeTrackBar);
            this.Controls.Add(this.alarmCustomSoundPathLabel);
            this.Controls.Add(this.alarmCustomSoundFileDialogButton);
            this.Controls.Add(this.alarmCustomSoundTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "alAAARM Settings";
            ((System.ComponentModel.ISupportInitialize)(this.alarmSoundVolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox alarmCustomSoundTextBox;
        private System.Windows.Forms.Button alarmCustomSoundFileDialogButton;
        private System.Windows.Forms.Label alarmCustomSoundPathLabel;
        private System.Windows.Forms.TrackBar alarmSoundVolumeTrackBar;
        private System.Windows.Forms.Label alarmSoundVolumeLabel;
        private System.Windows.Forms.Label volumePercentageLabel;
        private System.Windows.Forms.ComboBox alarmSoundSelectComboButton;
        private System.Windows.Forms.Label alarmSoundSelectLabel;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.Button alarmCustomSoundSaveButton;
    }
}