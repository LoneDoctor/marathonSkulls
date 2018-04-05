namespace Maraphon_Skills
{
    partial class administrator_menu
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
            this.logout = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel_administrator = new System.Windows.Forms.Label();
            this.return_to_start = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.fonds = new System.Windows.Forms.Button();
            this.volunteres = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.time_to_start = new System.Windows.Forms.Label();
            this.panel_2_sar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_1_sar.SuspendLayout();
            this.panel_2_sar.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout.Location = new System.Drawing.Point(1079, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 47);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome.Location = new System.Drawing.Point(236, 13);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(497, 46);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "MARATNON SKILLS 2018";
            // 
            // panel_administrator
            // 
            this.panel_administrator.AutoSize = true;
            this.panel_administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_administrator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_administrator.Location = new System.Drawing.Point(444, 97);
            this.panel_administrator.Name = "panel_administrator";
            this.panel_administrator.Size = new System.Drawing.Size(423, 44);
            this.panel_administrator.TabIndex = 41;
            this.panel_administrator.Text = "Меню администратора";
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
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventory.Location = new System.Drawing.Point(779, 322);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(339, 132);
            this.inventory.TabIndex = 45;
            this.inventory.Text = "Инвентарь";
            this.inventory.UseVisualStyleBackColor = true;
            // 
            // fonds
            // 
            this.fonds.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fonds.Location = new System.Drawing.Point(200, 322);
            this.fonds.Name = "fonds";
            this.fonds.Size = new System.Drawing.Size(339, 132);
            this.fonds.TabIndex = 44;
            this.fonds.Text = "Благотворительные организации";
            this.fonds.UseVisualStyleBackColor = true;
            // 
            // volunteres
            // 
            this.volunteres.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volunteres.Location = new System.Drawing.Point(779, 170);
            this.volunteres.Name = "volunteres";
            this.volunteres.Size = new System.Drawing.Size(339, 132);
            this.volunteres.TabIndex = 43;
            this.volunteres.Text = "Волонтеры";
            this.volunteres.UseVisualStyleBackColor = true;
            // 
            // users
            // 
            this.users.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users.Location = new System.Drawing.Point(200, 170);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(339, 132);
            this.users.TabIndex = 42;
            this.users.Text = "Пользователи";
            this.users.UseVisualStyleBackColor = true;
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
            this.panel_1_sar.TabIndex = 40;
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
            this.panel_2_sar.Location = new System.Drawing.Point(0, 652);
            this.panel_2_sar.Name = "panel_2_sar";
            this.panel_2_sar.Size = new System.Drawing.Size(1246, 68);
            this.panel_2_sar.TabIndex = 39;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // administrator_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 720);
            this.Controls.Add(this.panel_administrator);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.fonds);
            this.Controls.Add(this.volunteres);
            this.Controls.Add(this.users);
            this.Controls.Add(this.panel_1_sar);
            this.Controls.Add(this.panel_2_sar);
            this.Name = "administrator_menu";
            this.Text = "administrator_menu";
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            this.panel_2_sar.ResumeLayout(false);
            this.panel_2_sar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label panel_administrator;
        private System.Windows.Forms.Button return_to_start;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button fonds;
        private System.Windows.Forms.Button volunteres;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Label time_to_start;
        private System.Windows.Forms.Panel panel_2_sar;
        private System.Windows.Forms.Timer timer1;
    }
}