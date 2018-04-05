namespace Maraphon_Skills
{
    partial class Start_m
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
            this.components = new System.ComponentModel.Container();
            this.panel_2_start = new System.Windows.Forms.Panel();
            this.time_to_start = new System.Windows.Forms.Label();
            this.panel_1_start = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.Location_date_now = new System.Windows.Forms.TextBox();
            this.button_wanna_runner = new System.Windows.Forms.Button();
            this.button_wanna_sponsor = new System.Windows.Forms.Button();
            this.button_wanna_now = new System.Windows.Forms.Button();
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            this.login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_2_start.SuspendLayout();
            this.panel_1_start.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_2_start
            // 
            this.panel_2_start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_2_start.Controls.Add(this.time_to_start);
            this.panel_2_start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2_start.Location = new System.Drawing.Point(0, 816);
            this.panel_2_start.Name = "panel_2_start";
            this.panel_2_start.Size = new System.Drawing.Size(1423, 68);
            this.panel_2_start.TabIndex = 0;
            // 
            // time_to_start
            // 
            this.time_to_start.AutoSize = true;
            this.time_to_start.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_to_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_to_start.Location = new System.Drawing.Point(434, 14);
            this.time_to_start.Name = "time_to_start";
            this.time_to_start.Size = new System.Drawing.Size(207, 35);
            this.time_to_start.TabIndex = 3;
            this.time_to_start.Text = "Время до старта";
            // 
            // panel_1_start
            // 
            this.panel_1_start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_1_start.Controls.Add(this.Welcome);
            this.panel_1_start.Controls.Add(this.Location_date_now);
            this.panel_1_start.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1_start.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel_1_start.Location = new System.Drawing.Point(0, 0);
            this.panel_1_start.Name = "panel_1_start";
            this.panel_1_start.Size = new System.Drawing.Size(1423, 220);
            this.panel_1_start.TabIndex = 1;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome.Location = new System.Drawing.Point(350, 51);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(759, 70);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "MARAPNON SKILLS 2018";
            // 
            // Location_date_now
            // 
            this.Location_date_now.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Location_date_now.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Location_date_now.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location_date_now.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Location_date_now.Location = new System.Drawing.Point(362, 134);
            this.Location_date_now.Multiline = true;
            this.Location_date_now.Name = "Location_date_now";
            this.Location_date_now.ReadOnly = true;
            this.Location_date_now.Size = new System.Drawing.Size(717, 83);
            this.Location_date_now.TabIndex = 1;
            this.Location_date_now.Text = "Москва, Россия,\r\n ";
            this.Location_date_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_wanna_runner
            // 
            this.button_wanna_runner.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_wanna_runner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_wanna_runner.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_wanna_runner.Location = new System.Drawing.Point(440, 243);
            this.button_wanna_runner.Name = "button_wanna_runner";
            this.button_wanna_runner.Size = new System.Drawing.Size(577, 131);
            this.button_wanna_runner.TabIndex = 2;
            this.button_wanna_runner.Text = "Я хочу стать бегуном";
            this.button_wanna_runner.UseVisualStyleBackColor = true;
            this.button_wanna_runner.Click += new System.EventHandler(this.button_wanna_runner_Click);
            // 
            // button_wanna_sponsor
            // 
            this.button_wanna_sponsor.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_wanna_sponsor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_wanna_sponsor.Location = new System.Drawing.Point(440, 431);
            this.button_wanna_sponsor.Name = "button_wanna_sponsor";
            this.button_wanna_sponsor.Size = new System.Drawing.Size(577, 131);
            this.button_wanna_sponsor.TabIndex = 3;
            this.button_wanna_sponsor.Text = "Я хочу стать спонсором бегуна";
            this.button_wanna_sponsor.UseVisualStyleBackColor = true;
            this.button_wanna_sponsor.Click += new System.EventHandler(this.button_wanna_sponsor_Click);
            // 
            // button_wanna_now
            // 
            this.button_wanna_now.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_wanna_now.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_wanna_now.Location = new System.Drawing.Point(440, 638);
            this.button_wanna_now.Name = "button_wanna_now";
            this.button_wanna_now.Size = new System.Drawing.Size(577, 131);
            this.button_wanna_now.TabIndex = 4;
            this.button_wanna_now.Text = "Я хочу больше знать о событии";
            this.button_wanna_now.UseVisualStyleBackColor = true;
            this.button_wanna_now.Click += new System.EventHandler(this.button_wanna_now_Click);
            // 
            // timer_date
            // 
            this.timer_date.Enabled = true;
            this.timer_date.Interval = 1000;
            this.timer_date.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Location = new System.Drawing.Point(1245, 703);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(134, 68);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Start_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1423, 884);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button_wanna_now);
            this.Controls.Add(this.button_wanna_sponsor);
            this.Controls.Add(this.button_wanna_runner);
            this.Controls.Add(this.panel_1_start);
            this.Controls.Add(this.panel_2_start);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Start_m";
            this.Text = "Maraphon Skills 2018";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_2_start.ResumeLayout(false);
            this.panel_2_start.PerformLayout();
            this.panel_1_start.ResumeLayout(false);
            this.panel_1_start.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_2_start;
        private System.Windows.Forms.Panel panel_1_start;
        private System.Windows.Forms.TextBox Location_date_now;
        private System.Windows.Forms.Button button_wanna_runner;
        private System.Windows.Forms.Button button_wanna_sponsor;
        private System.Windows.Forms.Button button_wanna_now;
        private System.Windows.Forms.Timer timer_date;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label time_to_start;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

