namespace Alarm_ {
    partial class Alarm {
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
            this.labelDanger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDanger
            // 
            this.labelDanger.AutoSize = true;
            this.labelDanger.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDanger.ForeColor = System.Drawing.Color.Red;
            this.labelDanger.Location = new System.Drawing.Point(39, 9);
            this.labelDanger.Name = "labelDanger";
            this.labelDanger.Size = new System.Drawing.Size(355, 117);
            this.labelDanger.TabIndex = 10;
            this.labelDanger.Text = "DANGER";
            this.labelDanger.Visible = false;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(421, 229);
            this.ControlBox = false;
            this.Controls.Add(this.labelDanger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDanger;
    }
}