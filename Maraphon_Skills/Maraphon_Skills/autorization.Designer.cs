namespace Maraphon_Skills
{
    partial class autorization
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
            this.components = new System.ComponentModel.Container();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.return_to_start = new System.Windows.Forms.Button();
            this.time_to_start = new System.Windows.Forms.Label();
            this.panel_2_sar = new System.Windows.Forms.Panel();
            this.auto_info = new System.Windows.Forms.Label();
            this.auto_panel = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_1_sar.SuspendLayout();
            this.panel_2_sar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome.Location = new System.Drawing.Point(165, 13);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(497, 46);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "MARATNON SKILLS 2018";
            // 
            // panel_1_sar
            // 
            this.panel_1_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_1_sar.Controls.Add(this.Welcome);
            this.panel_1_sar.Controls.Add(this.return_to_start);
            this.panel_1_sar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1_sar.Location = new System.Drawing.Point(0, 0);
            this.panel_1_sar.Name = "panel_1_sar";
            this.panel_1_sar.Size = new System.Drawing.Size(1423, 69);
            this.panel_1_sar.TabIndex = 28;
            // 
            // return_to_start
            // 
            this.return_to_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_to_start.Location = new System.Drawing.Point(12, 12);
            this.return_to_start.Name = "return_to_start";
            this.return_to_start.Size = new System.Drawing.Size(125, 47);
            this.return_to_start.TabIndex = 2;
            this.return_to_start.Text = "Назад";
            this.return_to_start.UseVisualStyleBackColor = true;
            this.return_to_start.Click += new System.EventHandler(this.return_to_start_Click);
            // 
            // time_to_start
            // 
            this.time_to_start.AutoSize = true;
            this.time_to_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_to_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_to_start.Location = new System.Drawing.Point(304, 25);
            this.time_to_start.Name = "time_to_start";
            this.time_to_start.Size = new System.Drawing.Size(172, 25);
            this.time_to_start.TabIndex = 4;
            this.time_to_start.Text = "Время до старта";
            this.time_to_start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel_2_sar
            // 
            this.panel_2_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_2_sar.Controls.Add(this.time_to_start);
            this.panel_2_sar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2_sar.Location = new System.Drawing.Point(0, 816);
            this.panel_2_sar.Name = "panel_2_sar";
            this.panel_2_sar.Size = new System.Drawing.Size(1423, 68);
            this.panel_2_sar.TabIndex = 27;
            // 
            // auto_info
            // 
            this.auto_info.AutoSize = true;
            this.auto_info.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.auto_info.Location = new System.Drawing.Point(166, 173);
            this.auto_info.Name = "auto_info";
            this.auto_info.Size = new System.Drawing.Size(1049, 80);
            this.auto_info.TabIndex = 31;
            this.auto_info.Text = "Пожалуйста, авторизуйтесь в системе, используя свой адрес электронной почты\r\n    " +
    "                                                              и пароль.";
            // 
            // auto_panel
            // 
            this.auto_panel.AutoSize = true;
            this.auto_panel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.auto_panel.Location = new System.Drawing.Point(583, 106);
            this.auto_panel.Name = "auto_panel";
            this.auto_panel.Size = new System.Drawing.Size(269, 40);
            this.auto_panel.TabIndex = 30;
            this.auto_panel.Text = "Форма авторизации";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_email.Location = new System.Drawing.Point(590, 322);
            this.textBox_email.MaxLength = 50;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(344, 38);
            this.textBox_email.TabIndex = 32;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(590, 397);
            this.textBox_password.MaxLength = 50;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(344, 38);
            this.textBox_password.TabIndex = 33;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(493, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 35);
            this.label2.TabIndex = 34;
            this.label2.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(458, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 35);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password:";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(590, 454);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(129, 47);
            this.login.TabIndex = 36;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(725, 454);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(129, 47);
            this.cancel.TabIndex = 37;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 884);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.auto_info);
            this.Controls.Add(this.auto_panel);
            this.Controls.Add(this.panel_1_sar);
            this.Controls.Add(this.panel_2_sar);
            this.Name = "autorization";
            this.Text = "autorization";
            this.Load += new System.EventHandler(this.autorization_Load);
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            this.panel_2_sar.ResumeLayout(false);
            this.panel_2_sar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Button return_to_start;
        private System.Windows.Forms.Label time_to_start;
        private System.Windows.Forms.Panel panel_2_sar;
        private System.Windows.Forms.Label auto_info;
        private System.Windows.Forms.Label auto_panel;
        public System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Timer timer1;
    }
}