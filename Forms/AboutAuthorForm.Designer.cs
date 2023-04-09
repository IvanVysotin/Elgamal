namespace Elgamal.Forms
{
    partial class AboutAuthorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Info2 = new System.Windows.Forms.Label();
            this.lb_Info1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Info2
            // 
            this.lb_Info2.AutoSize = true;
            this.lb_Info2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
            this.lb_Info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Info2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_Info2.Location = new System.Drawing.Point(12, 44);
            this.lb_Info2.Name = "lb_Info2";
            this.lb_Info2.Size = new System.Drawing.Size(107, 75);
            this.lb_Info2.TabIndex = 4;
            this.lb_Info2.Text = "ЭИСб-34\r\n\r\n\r\n";
            // 
            // lb_Info1
            // 
            this.lb_Info1.AutoSize = true;
            this.lb_Info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Info1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.lb_Info1.Location = new System.Drawing.Point(26, 12);
            this.lb_Info1.Name = "lb_Info1";
            this.lb_Info1.Size = new System.Drawing.Size(368, 87);
            this.lb_Info1.TabIndex = 3;
            this.lb_Info1.Text = "Высотин Иван Сергеевич     \r\n\r\n\r\n";
            // 
            // AboutAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(407, 131);
            this.Controls.Add(this.lb_Info2);
            this.Controls.Add(this.lb_Info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutAuthorForm";
            this.Text = "О Авторе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Info2;
        private System.Windows.Forms.Label lb_Info1;
    }
}