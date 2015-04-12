namespace Alarm_ {
    partial class mainForm {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.labelMonitoring = new System.Windows.Forms.Label();
            this.boxDevices = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.btnCameraSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMonitoring
            // 
            this.labelMonitoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonitoring.AutoSize = true;
            this.labelMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.labelMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelMonitoring.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonitoring.ForeColor = System.Drawing.Color.Red;
            this.labelMonitoring.Location = new System.Drawing.Point(287, 9);
            this.labelMonitoring.Name = "labelMonitoring";
            this.labelMonitoring.Size = new System.Drawing.Size(108, 22);
            this.labelMonitoring.TabIndex = 10;
            this.labelMonitoring.Text = "monitoring";
            this.labelMonitoring.Visible = false;
            // 
            // boxDevices
            // 
            this.boxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDevices.BackColor = System.Drawing.SystemColors.Window;
            this.boxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDevices.FormattingEnabled = true;
            this.boxDevices.Location = new System.Drawing.Point(12, 334);
            this.boxDevices.Name = "boxDevices";
            this.boxDevices.Size = new System.Drawing.Size(383, 21);
            this.boxDevices.TabIndex = 0;
            this.boxDevices.SelectedIndexChanged += new System.EventHandler(this.boxDevices_SelectedIndexChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(44, 20);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Image = global::Alarm_.Properties.Resources.play;
            this.btnStart.Location = new System.Drawing.Point(21, 20);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(23, 22);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgVideo
            // 
            this.imgVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgVideo.BackColor = System.Drawing.Color.Black;
            this.imgVideo.Location = new System.Drawing.Point(12, 9);
            this.imgVideo.Margin = new System.Windows.Forms.Padding(0);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(408, 317);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            this.imgVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            // 
            // btnCameraSettings
            // 
            this.btnCameraSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraSettings.BackColor = System.Drawing.Color.Black;
            this.btnCameraSettings.FlatAppearance.BorderSize = 0;
            this.btnCameraSettings.Image = global::Alarm_.Properties.Resources.settings;
            this.btnCameraSettings.Location = new System.Drawing.Point(397, 334);
            this.btnCameraSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnCameraSettings.Name = "btnCameraSettings";
            this.btnCameraSettings.Size = new System.Drawing.Size(23, 22);
            this.btnCameraSettings.TabIndex = 11;
            this.btnCameraSettings.UseVisualStyleBackColor = false;
            this.btnCameraSettings.Click += new System.EventHandler(this.btnCameraSettings_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(432, 365);
            this.Controls.Add(this.btnCameraSettings);
            this.Controls.Add(this.boxDevices);
            this.Controls.Add(this.labelMonitoring);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.imgVideo);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALARM!";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Label labelMonitoring;
        private System.Windows.Forms.ComboBox boxDevices;
        private System.Windows.Forms.Button btnCameraSettings;
    }
}

