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
            ((System.ComponentModel.ISupportInitialize)(this.editPercantage)).BeginInit();
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
            10,
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
            this.checkEmail.Location = new System.Drawing.Point(13, 149);
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
            this.checkSMS.Location = new System.Drawing.Point(13, 172);
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
            this.editEmail.Location = new System.Drawing.Point(99, 149);
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(136, 20);
            this.editEmail.TabIndex = 17;
            this.editEmail.Enter += new System.EventHandler(this.editEmail_Enter);
            this.editEmail.Leave += new System.EventHandler(this.editEmail_Leave);
            // 
            // editMobileNumber
            // 
            this.editMobileNumber.Enabled = false;
            this.editMobileNumber.Location = new System.Drawing.Point(100, 172);
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
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Photos directory";
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 350);
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
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editPercantage)).EndInit();
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
    }
}