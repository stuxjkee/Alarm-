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
            this.editPercantage = new System.Windows.Forms.NumericUpDown();
            this.btnResolution = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.checkSMS = new System.Windows.Forms.CheckBox();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.editMobileNumber = new System.Windows.Forms.TextBox();
            this.dialogFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.editFolderSelect = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnFromFile = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.dialogFromFile = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSMSSettings = new System.Windows.Forms.Button();
            this.imgForCompare = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editPercantage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Permissible mistake (%)";
            // 
            // editPercantage
            // 
            this.editPercantage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.editPercantage.Location = new System.Drawing.Point(130, 44);
            this.editPercantage.Name = "editPercantage";
            this.editPercantage.Size = new System.Drawing.Size(71, 20);
            this.editPercantage.TabIndex = 13;
            this.editPercantage.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.editPercantage.ValueChanged += new System.EventHandler(this.editPercantage_ValueChanged);
            // 
            // btnResolution
            // 
            this.btnResolution.Location = new System.Drawing.Point(341, 41);
            this.btnResolution.Name = "btnResolution";
            this.btnResolution.Size = new System.Drawing.Size(75, 23);
            this.btnResolution.TabIndex = 12;
            this.btnResolution.Text = "Resolution";
            this.btnResolution.UseVisualStyleBackColor = true;
            this.btnResolution.Click += new System.EventHandler(this.btnResolution_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.Location = new System.Drawing.Point(341, 12);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(75, 23);
            this.btnDevice.TabIndex = 11;
            this.btnDevice.Text = "Device";
            this.btnDevice.UseVisualStyleBackColor = true;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(12, 96);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(79, 17);
            this.checkEmail.TabIndex = 15;
            this.checkEmail.Text = "Email notify";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // checkSMS
            // 
            this.checkSMS.AutoSize = true;
            this.checkSMS.Location = new System.Drawing.Point(12, 119);
            this.checkSMS.Name = "checkSMS";
            this.checkSMS.Size = new System.Drawing.Size(77, 17);
            this.checkSMS.TabIndex = 16;
            this.checkSMS.Text = "SMS notify";
            this.checkSMS.UseVisualStyleBackColor = true;
            this.checkSMS.CheckedChanged += new System.EventHandler(this.checkSMS_CheckedChanged);
            // 
            // editEmail
            // 
            this.editEmail.Enabled = false;
            this.editEmail.Location = new System.Drawing.Point(98, 96);
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(136, 20);
            this.editEmail.TabIndex = 17;
            this.editEmail.Enter += new System.EventHandler(this.editEmail_Enter);
            this.editEmail.Leave += new System.EventHandler(this.editEmail_Leave);
            // 
            // editMobileNumber
            // 
            this.editMobileNumber.Enabled = false;
            this.editMobileNumber.Location = new System.Drawing.Point(99, 119);
            this.editMobileNumber.Name = "editMobileNumber";
            this.editMobileNumber.Size = new System.Drawing.Size(135, 20);
            this.editMobileNumber.TabIndex = 18;
            this.editMobileNumber.Enter += new System.EventHandler(this.editMobileNumber_Enter);
            this.editMobileNumber.Leave += new System.EventHandler(this.editMobileNumber_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Images directory";
            // 
            // editFolderSelect
            // 
            this.editFolderSelect.Enabled = false;
            this.editFolderSelect.Location = new System.Drawing.Point(98, 19);
            this.editFolderSelect.Name = "editFolderSelect";
            this.editFolderSelect.Size = new System.Drawing.Size(120, 20);
            this.editFolderSelect.TabIndex = 20;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(224, 17);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(60, 23);
            this.btnSelectFolder.TabIndex = 21;
            this.btnSelectFolder.Text = "Change";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Image for compare";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(18, 341);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 24;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Visible = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnFromFile
            // 
            this.btnFromFile.Location = new System.Drawing.Point(143, 341);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(75, 23);
            this.btnFromFile.TabIndex = 25;
            this.btnFromFile.Text = "From File";
            this.btnFromFile.UseVisualStyleBackColor = true;
            this.btnFromFile.Visible = false;
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(92, 341);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(59, 23);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Snapshoot delay (sec)\r\n";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(130, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnSMSSettings
            // 
            this.btnSMSSettings.Enabled = false;
            this.btnSMSSettings.Location = new System.Drawing.Point(240, 119);
            this.btnSMSSettings.Name = "btnSMSSettings";
            this.btnSMSSettings.Size = new System.Drawing.Size(61, 20);
            this.btnSMSSettings.TabIndex = 29;
            this.btnSMSSettings.Text = "Settings";
            this.btnSMSSettings.UseVisualStyleBackColor = true;
            this.btnSMSSettings.Click += new System.EventHandler(this.btnSMSSettings_Click);
            // 
            // imgForCompare
            // 
            this.imgForCompare.Location = new System.Drawing.Point(11, 172);
            this.imgForCompare.Name = "imgForCompare";
            this.imgForCompare.Size = new System.Drawing.Size(222, 163);
            this.imgForCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgForCompare.TabIndex = 22;
            this.imgForCompare.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(341, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 380);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSMSSettings);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnFromFile);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgForCompare);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.editFolderSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editMobileNumber);
            this.Controls.Add(this.editEmail);
            this.Controls.Add(this.checkSMS);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editPercantage);
            this.Controls.Add(this.btnResolution);
            this.Controls.Add(this.btnDevice);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editPercantage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForCompare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown editPercantage;
        private System.Windows.Forms.Button btnResolution;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.CheckBox checkSMS;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.TextBox editMobileNumber;
        private System.Windows.Forms.FolderBrowserDialog dialogFolderSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editFolderSelect;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.PictureBox imgForCompare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnFromFile;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.OpenFileDialog dialogFromFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSMSSettings;
        private System.Windows.Forms.Button btnOK;
    }
}