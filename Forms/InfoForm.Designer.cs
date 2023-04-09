namespace Elgamal.Forms
{
    partial class InfoForm
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
            this.lb_Info1 = new System.Windows.Forms.Label();
            this.lb_Info2 = new System.Windows.Forms.Label();
            this.lb_Info3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Info1
            // 
            this.lb_Info1.AutoSize = true;
            this.lb_Info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Info1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.lb_Info1.Location = new System.Drawing.Point(21, 10);
            this.lb_Info1.Name = "lb_Info1";
            this.lb_Info1.Size = new System.Drawing.Size(368, 87);
            this.lb_Info1.TabIndex = 0;
            this.lb_Info1.Text = "Схема Эль-Гамаля (Elgamal)\r\n\r\n\r\n";
            // 
            // lb_Info2
            // 
            this.lb_Info2.AutoSize = true;
            this.lb_Info2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
            this.lb_Info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Info2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_Info2.Location = new System.Drawing.Point(7, 41);
            this.lb_Info2.Name = "lb_Info2";
            this.lb_Info2.Size = new System.Drawing.Size(359, 100);
            this.lb_Info2.TabIndex = 1;
            this.lb_Info2.Text = "Криптосистема с открытым ключом,        \r\nоснованная на трудности вычисления \r\nди" +
    "скретных логарифмов.\r\n\r\n\r\n";
            // 
            // lb_Info3
            // 
            this.lb_Info3.AutoSize = true;
            this.lb_Info3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.lb_Info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Info3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
            this.lb_Info3.Location = new System.Drawing.Point(37, 109);
            this.lb_Info3.Name = "lb_Info3";
            this.lb_Info3.Size = new System.Drawing.Size(341, 60);
            this.lb_Info3.TabIndex = 2;
            this.lb_Info3.Text = "Эта задача носит название проблемы \r\nдискретного логарифма.\r\n\r\n";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(409, 179);
            this.Controls.Add(this.lb_Info3);
            this.Controls.Add(this.lb_Info2);
            this.Controls.Add(this.lb_Info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfoForm";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Info1;
        private System.Windows.Forms.Label lb_Info2;
        private System.Windows.Forms.Label lb_Info3;
    }
}