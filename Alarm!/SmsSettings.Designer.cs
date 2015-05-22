namespace Alarm_ {
    partial class SmsSettings {
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
            this.cbSMSService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSMSService
            // 
            this.cbSMSService.DisplayMember = "1";
            this.cbSMSService.FormattingEnabled = true;
            this.cbSMSService.Items.AddRange(new object[] {
            "smsc.ua"});
            this.cbSMSService.Location = new System.Drawing.Point(87, 19);
            this.cbSMSService.Name = "cbSMSService";
            this.cbSMSService.Size = new System.Drawing.Size(121, 21);
            this.cbSMSService.TabIndex = 0;
            this.cbSMSService.Text = "smsc.ua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMS Сервіс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логін";
            // 
            // editUsername
            // 
            this.editUsername.Location = new System.Drawing.Point(87, 50);
            this.editUsername.Name = "editUsername";
            this.editUsername.Size = new System.Drawing.Size(100, 20);
            this.editUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(87, 76);
            this.editPassword.Name = "editPassword";
            this.editPassword.PasswordChar = '*';
            this.editPassword.Size = new System.Drawing.Size(100, 20);
            this.editPassword.TabIndex = 5;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(30, 106);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(74, 33);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Відправити";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(125, 106);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(74, 33);
            this.bntClose.TabIndex = 7;
            this.bntClose.Text = "Закрити";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // SmsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 151);
            this.ControlBox = false;
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSMSService);
            this.Name = "SmsSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SmsSettings";
            this.Load += new System.EventHandler(this.SmsSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSMSService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button bntClose;
    }
}