namespace Maraphon_Skills
{
    partial class koordinator_menu
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
            this.return_to_start = new System.Windows.Forms.Button();
            this.coord_menu = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.time_to_start = new System.Windows.Forms.Label();
            this.sponsors = new System.Windows.Forms.Button();
            this.runners = new System.Windows.Forms.Button();
            this.panel_2_sar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_1_sar.SuspendLayout();
            this.panel_2_sar.SuspendLayout();
            this.SuspendLayout();
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
            // coord_menu
            // 
            this.coord_menu.AutoSize = true;
            this.coord_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coord_menu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coord_menu.Location = new System.Drawing.Point(470, 110);
            this.coord_menu.Name = "coord_menu";
            this.coord_menu.Size = new System.Drawing.Size(379, 44);
            this.coord_menu.TabIndex = 39;
            this.coord_menu.Text = "Меню координатора";
            this.coord_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout.Location = new System.Drawing.Point(1109, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 47);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel_1_sar
            // 
            this.panel_1_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_1_sar.Controls.Add(this.logout);
            this.panel_1_sar.Controls.Add(this.Welcome);
            this.panel_1_sar.Controls.Add(this.return_to_start);
            this.panel_1_sar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1_sar.Location = new System.Drawing.Point(0, 0);
            this.panel_1_sar.Name = "panel_1_sar";
            this.panel_1_sar.Size = new System.Drawing.Size(1246, 69);
            this.panel_1_sar.TabIndex = 38;
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
            // sponsors
            // 
            this.sponsors.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsors.Location = new System.Drawing.Point(711, 170);
            this.sponsors.Name = "sponsors";
            this.sponsors.Size = new System.Drawing.Size(339, 132);
            this.sponsors.TabIndex = 41;
            this.sponsors.Text = "Спонсоры";
            this.sponsors.UseVisualStyleBackColor = true;
            // 
            // runners
            // 
            this.runners.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runners.Location = new System.Drawing.Point(237, 170);
            this.runners.Name = "runners";
            this.runners.Size = new System.Drawing.Size(339, 132);
            this.runners.TabIndex = 40;
            this.runners.Text = "Бегуны";
            this.runners.UseVisualStyleBackColor = true;
            // 
            // panel_2_sar
            // 
            this.panel_2_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_2_sar.Controls.Add(this.time_to_start);
            this.panel_2_sar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2_sar.Location = new System.Drawing.Point(0, 652);
            this.panel_2_sar.Name = "panel_2_sar";
            this.panel_2_sar.Size = new System.Drawing.Size(1246, 68);
            this.panel_2_sar.TabIndex = 37;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // koordinator_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1246, 720);
            this.Controls.Add(this.coord_menu);
            this.Controls.Add(this.panel_1_sar);
            this.Controls.Add(this.sponsors);
            this.Controls.Add(this.runners);
            this.Controls.Add(this.panel_2_sar);
            this.Name = "koordinator_menu";
            this.Text = "koordinator_menu";
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            this.panel_2_sar.ResumeLayout(false);
            this.panel_2_sar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_to_start;
        private System.Windows.Forms.Label coord_menu;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label time_to_start;
        private System.Windows.Forms.Button sponsors;
        private System.Windows.Forms.Button runners;
        private System.Windows.Forms.Panel panel_2_sar;
        private System.Windows.Forms.Timer timer1;
    }
}