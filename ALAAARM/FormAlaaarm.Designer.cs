﻿namespace alAAARM {
    partial class FormAlaaarm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Autogenerated code

        /// <summary>
        /// Won't change this method directly!
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlaaarm));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmTitle = new System.Windows.Forms.Label();
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.setDirectDateLabel = new System.Windows.Forms.Label();
            this.resetToNowButton = new System.Windows.Forms.Button();
            this.plus30SecButton = new System.Windows.Forms.Button();
            this.plus1MinButton = new System.Windows.Forms.Button();
            this.plus5MinButton = new System.Windows.Forms.Button();
            this.plus10MinButton = new System.Windows.Forms.Button();
            this.plus30MinButton = new System.Windows.Forms.Button();
            this.plus1HourButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.relativesLabel = new System.Windows.Forms.Label();
            this.relativesCheckBox = new System.Windows.Forms.CheckBox();
            this.alarmsListLabel = new System.Windows.Forms.Label();
            this.alarmSoundVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.alarmSoundVolumeLabel = new System.Windows.Forms.Label();
            this.volumePercentageLabel = new System.Windows.Forms.Label();
            this.alarmSoundSelectLabel = new System.Windows.Forms.Label();
            this.alarmSoundSelectComboButton = new System.Windows.Forms.ComboBox();
            this.alarmCustomSoundPathLabel = new System.Windows.Forms.Label();
            this.alarmCustomSoundFileDialogButton = new System.Windows.Forms.Button();
            this.alarmCustomSoundTextBox = new System.Windows.Forms.TextBox();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            this.relativeTimeDisplayLabel = new System.Windows.Forms.Label();
            this.addonsLabel = new System.Windows.Forms.Label();
            this.addonAddButtonFileDialog = new System.Windows.Forms.Button();
            this.addonsTreeView = new System.Windows.Forms.TreeView();
            this.addonDeleteButton = new System.Windows.Forms.Button();
            this.addonOpenButton = new System.Windows.Forms.Button();
            this.trayMinimizerButton = new System.Windows.Forms.Button();
            this.untrayCheckBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmSoundVolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToNowToolStripMenuItem,
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // resetToNowToolStripMenuItem
            // 
            this.resetToNowToolStripMenuItem.Name = "resetToNowToolStripMenuItem";
            resources.ApplyResources(this.resetToNowToolStripMenuItem, "resetToNowToolStripMenuItem");
            this.resetToNowToolStripMenuItem.Click += new System.EventHandler(this.resetToNowToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem,
            this.toolStripMenuItem1,
            this.minToolStripMenuItem,
            this.minToolStripMenuItem1,
            this.minToolStripMenuItem2,
            this.hToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            resources.ApplyResources(this.secToolStripMenuItem, "secToolStripMenuItem");
            this.secToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            resources.ApplyResources(this.minToolStripMenuItem, "minToolStripMenuItem");
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            resources.ApplyResources(this.minToolStripMenuItem1, "minToolStripMenuItem1");
            this.minToolStripMenuItem1.Click += new System.EventHandler(this.minToolStripMenuItem1_Click);
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            resources.ApplyResources(this.minToolStripMenuItem2, "minToolStripMenuItem2");
            this.minToolStripMenuItem2.Click += new System.EventHandler(this.minToolStripMenuItem2_Click);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            resources.ApplyResources(this.hToolStripMenuItem, "hToolStripMenuItem");
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // alarmTitle
            // 
            resources.ApplyResources(this.alarmTitle, "alarmTitle");
            this.alarmTitle.Name = "alarmTitle";
            // 
            // setAlarmButton
            // 
            resources.ApplyResources(this.setAlarmButton, "setAlarmButton");
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.setAlarmButton_Click);
            // 
            // setDirectDateLabel
            // 
            resources.ApplyResources(this.setDirectDateLabel, "setDirectDateLabel");
            this.setDirectDateLabel.Name = "setDirectDateLabel";
            // 
            // resetToNowButton
            // 
            resources.ApplyResources(this.resetToNowButton, "resetToNowButton");
            this.resetToNowButton.Name = "resetToNowButton";
            this.resetToNowButton.UseVisualStyleBackColor = true;
            this.resetToNowButton.Click += new System.EventHandler(this.resetToNowButton_Click);
            // 
            // plus30SecButton
            // 
            resources.ApplyResources(this.plus30SecButton, "plus30SecButton");
            this.plus30SecButton.Name = "plus30SecButton";
            this.plus30SecButton.UseVisualStyleBackColor = true;
            this.plus30SecButton.Click += new System.EventHandler(this.plus30SecButton_Click);
            // 
            // plus1MinButton
            // 
            resources.ApplyResources(this.plus1MinButton, "plus1MinButton");
            this.plus1MinButton.Name = "plus1MinButton";
            this.plus1MinButton.UseVisualStyleBackColor = true;
            this.plus1MinButton.Click += new System.EventHandler(this.plus1MinButton_Click);
            // 
            // plus5MinButton
            // 
            resources.ApplyResources(this.plus5MinButton, "plus5MinButton");
            this.plus5MinButton.Name = "plus5MinButton";
            this.plus5MinButton.UseVisualStyleBackColor = true;
            this.plus5MinButton.Click += new System.EventHandler(this.plus5MinButton_Click);
            // 
            // plus10MinButton
            // 
            resources.ApplyResources(this.plus10MinButton, "plus10MinButton");
            this.plus10MinButton.Name = "plus10MinButton";
            this.plus10MinButton.UseVisualStyleBackColor = true;
            this.plus10MinButton.Click += new System.EventHandler(this.plus10MinButton_Click);
            // 
            // plus30MinButton
            // 
            resources.ApplyResources(this.plus30MinButton, "plus30MinButton");
            this.plus30MinButton.Name = "plus30MinButton";
            this.plus30MinButton.UseVisualStyleBackColor = true;
            this.plus30MinButton.Click += new System.EventHandler(this.plus30MinButton_Click);
            // 
            // plus1HourButton
            // 
            resources.ApplyResources(this.plus1HourButton, "plus1HourButton");
            this.plus1HourButton.Name = "plus1HourButton";
            this.plus1HourButton.UseVisualStyleBackColor = true;
            this.plus1HourButton.Click += new System.EventHandler(this.plus1HourButton_Click);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            resources.ApplyResources(this.modifyButton, "modifyButton");
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // relativesLabel
            // 
            resources.ApplyResources(this.relativesLabel, "relativesLabel");
            this.relativesLabel.Name = "relativesLabel";
            // 
            // relativesCheckBox
            // 
            resources.ApplyResources(this.relativesCheckBox, "relativesCheckBox");
            this.relativesCheckBox.Name = "relativesCheckBox";
            this.relativesCheckBox.UseVisualStyleBackColor = true;
            this.relativesCheckBox.CheckedChanged += new System.EventHandler(this.relativesCheckBox_CheckedChanged);
            // 
            // alarmsListLabel
            // 
            resources.ApplyResources(this.alarmsListLabel, "alarmsListLabel");
            this.alarmsListLabel.Name = "alarmsListLabel";
            // 
            // alarmSoundVolumeTrackBar
            // 
            resources.ApplyResources(this.alarmSoundVolumeTrackBar, "alarmSoundVolumeTrackBar");
            this.alarmSoundVolumeTrackBar.Maximum = 100;
            this.alarmSoundVolumeTrackBar.Name = "alarmSoundVolumeTrackBar";
            this.alarmSoundVolumeTrackBar.Scroll += new System.EventHandler(this.alarmSoundVolumeTrackBar_Scroll);
            // 
            // alarmSoundVolumeLabel
            // 
            resources.ApplyResources(this.alarmSoundVolumeLabel, "alarmSoundVolumeLabel");
            this.alarmSoundVolumeLabel.Name = "alarmSoundVolumeLabel";
            // 
            // volumePercentageLabel
            // 
            resources.ApplyResources(this.volumePercentageLabel, "volumePercentageLabel");
            this.volumePercentageLabel.Name = "volumePercentageLabel";
            // 
            // alarmSoundSelectLabel
            // 
            resources.ApplyResources(this.alarmSoundSelectLabel, "alarmSoundSelectLabel");
            this.alarmSoundSelectLabel.Name = "alarmSoundSelectLabel";
            // 
            // alarmSoundSelectComboButton
            // 
            this.alarmSoundSelectComboButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alarmSoundSelectComboButton.FormattingEnabled = true;
            resources.ApplyResources(this.alarmSoundSelectComboButton, "alarmSoundSelectComboButton");
            this.alarmSoundSelectComboButton.Name = "alarmSoundSelectComboButton";
            this.alarmSoundSelectComboButton.SelectedIndexChanged += new System.EventHandler(this.alarmSoundSelectComboButton_SelectedIndexChanged);
            // 
            // alarmCustomSoundPathLabel
            // 
            resources.ApplyResources(this.alarmCustomSoundPathLabel, "alarmCustomSoundPathLabel");
            this.alarmCustomSoundPathLabel.Name = "alarmCustomSoundPathLabel";
            // 
            // alarmCustomSoundFileDialogButton
            // 
            resources.ApplyResources(this.alarmCustomSoundFileDialogButton, "alarmCustomSoundFileDialogButton");
            this.alarmCustomSoundFileDialogButton.Name = "alarmCustomSoundFileDialogButton";
            this.alarmCustomSoundFileDialogButton.UseVisualStyleBackColor = true;
            this.alarmCustomSoundFileDialogButton.Click += new System.EventHandler(this.alarmCustomSoundFileDialogButton_Click);
            // 
            // alarmCustomSoundTextBox
            // 
            resources.ApplyResources(this.alarmCustomSoundTextBox, "alarmCustomSoundTextBox");
            this.alarmCustomSoundTextBox.Name = "alarmCustomSoundTextBox";
            // 
            // repeatCheckBox
            // 
            resources.ApplyResources(this.repeatCheckBox, "repeatCheckBox");
            this.repeatCheckBox.Checked = true;
            this.repeatCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            this.repeatCheckBox.CheckedChanged += new System.EventHandler(this.repeatCheckBox_CheckedChanged);
            // 
            // relativeTimeDisplayLabel
            // 
            resources.ApplyResources(this.relativeTimeDisplayLabel, "relativeTimeDisplayLabel");
            this.relativeTimeDisplayLabel.Name = "relativeTimeDisplayLabel";
            // 
            // addonsLabel
            // 
            resources.ApplyResources(this.addonsLabel, "addonsLabel");
            this.addonsLabel.Name = "addonsLabel";
            // 
            // addonAddButtonFileDialog
            // 
            resources.ApplyResources(this.addonAddButtonFileDialog, "addonAddButtonFileDialog");
            this.addonAddButtonFileDialog.Name = "addonAddButtonFileDialog";
            this.addonAddButtonFileDialog.UseVisualStyleBackColor = true;
            this.addonAddButtonFileDialog.Click += new System.EventHandler(this.addonAddButtonFileDialog_Click);
            // 
            // addonsTreeView
            // 
            resources.ApplyResources(this.addonsTreeView, "addonsTreeView");
            this.addonsTreeView.Name = "addonsTreeView";
            this.addonsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.addonsTreeView_AfterSelect);
            // 
            // addonDeleteButton
            // 
            resources.ApplyResources(this.addonDeleteButton, "addonDeleteButton");
            this.addonDeleteButton.Name = "addonDeleteButton";
            this.addonDeleteButton.UseVisualStyleBackColor = true;
            this.addonDeleteButton.Click += new System.EventHandler(this.addonDeleteButton_Click);
            // 
            // addonOpenButton
            // 
            resources.ApplyResources(this.addonOpenButton, "addonOpenButton");
            this.addonOpenButton.Name = "addonOpenButton";
            this.addonOpenButton.UseVisualStyleBackColor = true;
            this.addonOpenButton.Click += new System.EventHandler(this.addonOpenButton_Click);
            // 
            // trayMinimizerButton
            // 
            resources.ApplyResources(this.trayMinimizerButton, "trayMinimizerButton");
            this.trayMinimizerButton.Name = "trayMinimizerButton";
            this.trayMinimizerButton.UseVisualStyleBackColor = true;
            this.trayMinimizerButton.Click += new System.EventHandler(this.trayMinimizerButton_Click);
            // 
            // untrayCheckBox
            // 
            resources.ApplyResources(this.untrayCheckBox, "untrayCheckBox");
            this.untrayCheckBox.Name = "untrayCheckBox";
            this.untrayCheckBox.UseVisualStyleBackColor = true;
            this.untrayCheckBox.CheckedChanged += new System.EventHandler(this.untrayCheckBox_CheckedChanged);
            // 
            // FormAlaaarm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.untrayCheckBox);
            this.Controls.Add(this.trayMinimizerButton);
            this.Controls.Add(this.addonOpenButton);
            this.Controls.Add(this.addonDeleteButton);
            this.Controls.Add(this.addonsTreeView);
            this.Controls.Add(this.addonsLabel);
            this.Controls.Add(this.relativeTimeDisplayLabel);
            this.Controls.Add(this.repeatCheckBox);
            this.Controls.Add(this.alarmCustomSoundPathLabel);
            this.Controls.Add(this.addonAddButtonFileDialog);
            this.Controls.Add(this.alarmCustomSoundFileDialogButton);
            this.Controls.Add(this.alarmCustomSoundTextBox);
            this.Controls.Add(this.alarmSoundSelectComboButton);
            this.Controls.Add(this.alarmSoundSelectLabel);
            this.Controls.Add(this.volumePercentageLabel);
            this.Controls.Add(this.alarmSoundVolumeLabel);
            this.Controls.Add(this.alarmSoundVolumeTrackBar);
            this.Controls.Add(this.alarmsListLabel);
            this.Controls.Add(this.relativesCheckBox);
            this.Controls.Add(this.relativesLabel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.plus1HourButton);
            this.Controls.Add(this.plus30MinButton);
            this.Controls.Add(this.plus10MinButton);
            this.Controls.Add(this.plus5MinButton);
            this.Controls.Add(this.plus1MinButton);
            this.Controls.Add(this.plus30SecButton);
            this.Controls.Add(this.resetToNowButton);
            this.Controls.Add(this.setDirectDateLabel);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.alarmTitle);
            this.Controls.Add(this.dateTimePicker);
            this.MaximizeBox = false;
            this.Name = "FormAlaaarm";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alarmSoundVolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label alarmTitle;
        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.Label setDirectDateLabel;
        private System.Windows.Forms.Button resetToNowButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.Button plus30SecButton;
        private System.Windows.Forms.Button plus1MinButton;
        private System.Windows.Forms.Button plus5MinButton;
        private System.Windows.Forms.Button plus10MinButton;
        private System.Windows.Forms.Button plus30MinButton;
        private System.Windows.Forms.Button plus1HourButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label relativesLabel;
        private System.Windows.Forms.CheckBox relativesCheckBox;
        private System.Windows.Forms.Label alarmsListLabel;
        private System.Windows.Forms.TrackBar alarmSoundVolumeTrackBar;
        private System.Windows.Forms.Label alarmSoundVolumeLabel;
        private System.Windows.Forms.Label volumePercentageLabel;
        private System.Windows.Forms.Label alarmSoundSelectLabel;
        private System.Windows.Forms.ComboBox alarmSoundSelectComboButton;
        private System.Windows.Forms.Label alarmCustomSoundPathLabel;
        private System.Windows.Forms.Button alarmCustomSoundFileDialogButton;
        private System.Windows.Forms.TextBox alarmCustomSoundTextBox;
        private System.Windows.Forms.CheckBox repeatCheckBox;
        private System.Windows.Forms.Label relativeTimeDisplayLabel;
        private System.Windows.Forms.Label addonsLabel;
        private System.Windows.Forms.Button addonAddButtonFileDialog;
        private System.Windows.Forms.TreeView addonsTreeView;
        private System.Windows.Forms.Button addonDeleteButton;
        private System.Windows.Forms.Button addonOpenButton;
        private System.Windows.Forms.Button trayMinimizerButton;
        private System.Windows.Forms.CheckBox untrayCheckBox;
    }
}

