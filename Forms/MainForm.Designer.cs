namespace Elgamal.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Input = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Output = new System.Windows.Forms.RichTextBox();
            this.lb_Output = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.lb_x = new System.Windows.Forms.Label();
            this.lb_p = new System.Windows.Forms.Label();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Input
            // 
            this.lb_Input.AutoSize = true;
            this.lb_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.lb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_Input.Location = new System.Drawing.Point(12, 31);
            this.lb_Input.Name = "lb_Input";
            this.lb_Input.Size = new System.Drawing.Size(245, 25);
            this.lb_Input.TabIndex = 1;
            this.lb_Input.Text = "Исходное сообщение";
            // 
            // tb_Input
            // 
            this.tb_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.tb_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tb_Input.Location = new System.Drawing.Point(12, 59);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(375, 152);
            this.tb_Input.TabIndex = 2;
            this.tb_Input.Text = "Выс";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1,
            this.оАвтореToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.справкаToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // оАвтореToolStripMenuItem
            // 
            this.оАвтореToolStripMenuItem.Name = "оАвтореToolStripMenuItem";
            this.оАвтореToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оАвтореToolStripMenuItem.Text = "О авторе";
            this.оАвтореToolStripMenuItem.Click += new System.EventHandler(this.оАвтореToolStripMenuItem_Click);
            // 
            // tb_Output
            // 
            this.tb_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.tb_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tb_Output.Location = new System.Drawing.Point(12, 300);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(375, 152);
            this.tb_Output.TabIndex = 5;
            this.tb_Output.Text = "";
            // 
            // lb_Output
            // 
            this.lb_Output.AutoSize = true;
            this.lb_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.lb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_Output.Location = new System.Drawing.Point(12, 272);
            this.lb_Output.Name = "lb_Output";
            this.lb_Output.Size = new System.Drawing.Size(319, 25);
            this.lb_Output.TabIndex = 4;
            this.lb_Output.Text = "Зашифрованное сообщение";
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.btn_Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Encrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
            this.btn_Encrypt.Location = new System.Drawing.Point(393, 59);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(162, 152);
            this.btn_Encrypt.TabIndex = 6;
            this.btn_Encrypt.Text = "Зашифровать";
            this.btn_Encrypt.UseVisualStyleBackColor = false;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Decrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
            this.btn_Decrypt.Location = new System.Drawing.Point(393, 300);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(162, 152);
            this.btn_Decrypt.TabIndex = 7;
            this.btn_Decrypt.Text = "Расшифровать";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // tb_x
            // 
            this.tb_x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tb_x.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.tb_x.Location = new System.Drawing.Point(474, 214);
            this.tb_x.Multiline = true;
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(78, 25);
            this.tb_x.TabIndex = 8;
            this.tb_x.Text = "970";
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.lb_x.Location = new System.Drawing.Point(295, 214);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(173, 25);
            this.lb_x.TabIndex = 9;
            this.lb_x.Text = "Переменная х:";
            // 
            // lb_p
            // 
            this.lb_p.AutoSize = true;
            this.lb_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.lb_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.lb_p.Location = new System.Drawing.Point(12, 214);
            this.lb_p.Name = "lb_p";
            this.lb_p.Size = new System.Drawing.Size(174, 25);
            this.lb_p.TabIndex = 13;
            this.lb_p.Text = "Переменная p:";
            // 
            // tb_p
            // 
            this.tb_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tb_p.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.tb_p.Location = new System.Drawing.Point(192, 214);
            this.tb_p.Multiline = true;
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(78, 25);
            this.tb_p.TabIndex = 12;
            this.tb_p.Text = "11743";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(564, 464);
            this.Controls.Add(this.lb_p);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.lb_x);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.lb_Output);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.lb_Input);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "гш";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Input;
        private System.Windows.Forms.RichTextBox tb_Input;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox tb_Output;
        private System.Windows.Forms.Label lb_Output;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оАвтореToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.Label lb_p;
        private System.Windows.Forms.TextBox tb_p;
    }
}

