namespace Alarm_ {
    partial class Settings {
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.checkSMS = new System.Windows.Forms.CheckBox();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.editMobileNumber = new System.Windows.Forms.TextBox();
            this.dialogFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.editFolderSelect = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.dialogFromFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSMSSettings = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.checkSoundNotify = new System.Windows.Forms.CheckBox();
            this.editSoundFilename = new System.Windows.Forms.TextBox();
            this.btnChoiceSound = new System.Windows.Forms.Button();
            this.dialogSoundSelect = new System.Windows.Forms.OpenFileDialog();
            this.editDiff = new System.Windows.Forms.TrackBar();
            this.labelDiff = new System.Windows.Forms.Label();
            this.labelInternetConnection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editDiff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Чутливість детектора";
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(12, 102);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(113, 17);
            this.checkEmail.TabIndex = 8;
            this.checkEmail.Text = "Email сповіщення";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // checkSMS
            // 
            this.checkSMS.AutoSize = true;
            this.checkSMS.Location = new System.Drawing.Point(12, 79);
            this.checkSMS.Name = "checkSMS";
            this.checkSMS.Size = new System.Drawing.Size(111, 17);
            this.checkSMS.TabIndex = 2;
            this.checkSMS.Text = "SMS сповіщення";
            this.checkSMS.UseVisualStyleBackColor = true;
            this.checkSMS.CheckedChanged += new System.EventHandler(this.checkSMS_CheckedChanged);
            // 
            // editEmail
            // 
            this.editEmail.Enabled = false;
            this.editEmail.Location = new System.Drawing.Point(140, 99);
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(133, 20);
            this.editEmail.TabIndex = 9;
            this.editEmail.Enter += new System.EventHandler(this.editEmail_Enter);
            this.editEmail.Leave += new System.EventHandler(this.editEmail_Leave);
            // 
            // editMobileNumber
            // 
            this.editMobileNumber.Enabled = false;
            this.editMobileNumber.Location = new System.Drawing.Point(140, 77);
            this.editMobileNumber.Name = "editMobileNumber";
            this.editMobileNumber.Size = new System.Drawing.Size(133, 20);
            this.editMobileNumber.TabIndex = 3;
            this.editMobileNumber.Enter += new System.EventHandler(this.editMobileNumber_Enter);
            this.editMobileNumber.Leave += new System.EventHandler(this.editMobileNumber_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Папка для зображень";
            // 
            // editFolderSelect
            // 
            this.editFolderSelect.Enabled = false;
            this.editFolderSelect.Location = new System.Drawing.Point(139, 19);
            this.editFolderSelect.Name = "editFolderSelect";
            this.editFolderSelect.Size = new System.Drawing.Size(135, 20);
            this.editFolderSelect.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(280, 17);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(60, 22);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Змінити";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSMSSettings
            // 
            this.btnSMSSettings.Enabled = false;
            this.btnSMSSettings.Location = new System.Drawing.Point(279, 76);
            this.btnSMSSettings.Name = "btnSMSSettings";
            this.btnSMSSettings.Size = new System.Drawing.Size(60, 23);
            this.btnSMSSettings.TabIndex = 4;
            this.btnSMSSettings.Text = "Змінити";
            this.btnSMSSettings.UseVisualStyleBackColor = true;
            this.btnSMSSettings.Click += new System.EventHandler(this.btnSMSSettings_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(239, 166);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkSoundNotify
            // 
            this.checkSoundNotify.AutoSize = true;
            this.checkSoundNotify.Location = new System.Drawing.Point(12, 52);
            this.checkSoundNotify.Name = "checkSoundNotify";
            this.checkSoundNotify.Size = new System.Drawing.Size(130, 17);
            this.checkSoundNotify.TabIndex = 5;
            this.checkSoundNotify.Text = "Звукове сповіщення";
            this.checkSoundNotify.UseVisualStyleBackColor = true;
            this.checkSoundNotify.CheckedChanged += new System.EventHandler(this.checkSoundNotify_CheckedChanged);
            // 
            // editSoundFilename
            // 
            this.editSoundFilename.Enabled = false;
            this.editSoundFilename.Location = new System.Drawing.Point(140, 48);
            this.editSoundFilename.Name = "editSoundFilename";
            this.editSoundFilename.Size = new System.Drawing.Size(133, 20);
            this.editSoundFilename.TabIndex = 6;
            this.editSoundFilename.Text = "Виберіть звук";
            // 
            // btnChoiceSound
            // 
            this.btnChoiceSound.Location = new System.Drawing.Point(279, 48);
            this.btnChoiceSound.Name = "btnChoiceSound";
            this.btnChoiceSound.Size = new System.Drawing.Size(60, 22);
            this.btnChoiceSound.TabIndex = 7;
            this.btnChoiceSound.Text = "Вибрати";
            this.btnChoiceSound.UseVisualStyleBackColor = true;
            this.btnChoiceSound.Click += new System.EventHandler(this.btnChoiceSound_Click);
            // 
            // editDiff
            // 
            this.editDiff.Location = new System.Drawing.Point(126, 128);
            this.editDiff.Minimum = 1;
            this.editDiff.Name = "editDiff";
            this.editDiff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editDiff.Size = new System.Drawing.Size(107, 45);
            this.editDiff.TabIndex = 10;
            this.editDiff.Value = 3;
            this.editDiff.Scroll += new System.EventHandler(this.editDiff_Scroll);
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(233, 134);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(0, 13);
            this.labelDiff.TabIndex = 35;
            // 
            // labelInternetConnection
            // 
            this.labelInternetConnection.AutoSize = true;
            this.labelInternetConnection.ForeColor = System.Drawing.Color.Green;
            this.labelInternetConnection.Location = new System.Drawing.Point(9, 176);
            this.labelInternetConnection.Name = "labelInternetConnection";
            this.labelInternetConnection.Size = new System.Drawing.Size(97, 13);
            this.labelInternetConnection.TabIndex = 36;
            this.labelInternetConnection.Text = "InternetConnection";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 203);
            this.ControlBox = false;
            this.Controls.Add(this.labelInternetConnection);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.editDiff);
            this.Controls.Add(this.btnChoiceSound);
            this.Controls.Add(this.editSoundFilename);
            this.Controls.Add(this.checkSoundNotify);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSMSSettings);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.editFolderSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editMobileNumber);
            this.Controls.Add(this.editEmail);
            this.Controls.Add(this.checkSMS);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Налаштування";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editDiff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.CheckBox checkSMS;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.TextBox editMobileNumber;
        private System.Windows.Forms.FolderBrowserDialog dialogFolderSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editFolderSelect;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.OpenFileDialog dialogFromFile;
        private System.Windows.Forms.Button btnSMSSettings;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox checkSoundNotify;
        private System.Windows.Forms.TextBox editSoundFilename;
        private System.Windows.Forms.Button btnChoiceSound;
        private System.Windows.Forms.OpenFileDialog dialogSoundSelect;
        private System.Windows.Forms.TrackBar editDiff;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Label labelInternetConnection;
    }
}