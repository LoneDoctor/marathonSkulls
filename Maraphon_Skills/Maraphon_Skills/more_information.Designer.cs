namespace Maraphon_Skills
{
    partial class more_information
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
            this.Welcome = new System.Windows.Forms.Label();
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.return_to_start = new System.Windows.Forms.Button();
            this.time_to_start = new System.Windows.Forms.Label();
            this.panel_2_sar = new System.Windows.Forms.Panel();
            this.more_info_panel = new System.Windows.Forms.Label();
            this.marathon_info = new System.Windows.Forms.Button();
            this.how_long = new System.Windows.Forms.Button();
            this.last_rezults = new System.Windows.Forms.Button();
            this.list_organization = new System.Windows.Forms.Button();
            this.BMI_calculator = new System.Windows.Forms.Button();
            this.BMR_calculator = new System.Windows.Forms.Button();
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
            this.panel_1_sar.Size = new System.Drawing.Size(1246, 69);
            this.panel_1_sar.TabIndex = 24;
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
            this.panel_2_sar.Location = new System.Drawing.Point(0, 652);
            this.panel_2_sar.Name = "panel_2_sar";
            this.panel_2_sar.Size = new System.Drawing.Size(1246, 68);
            this.panel_2_sar.TabIndex = 23;
            // 
            // more_info_panel
            // 
            this.more_info_panel.AutoSize = true;
            this.more_info_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.more_info_panel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.more_info_panel.Location = new System.Drawing.Point(427, 75);
            this.more_info_panel.Name = "more_info_panel";
            this.more_info_panel.Size = new System.Drawing.Size(454, 44);
            this.more_info_panel.TabIndex = 25;
            this.more_info_panel.Text = "Подробная информация";
            // 
            // marathon_info
            // 
            this.marathon_info.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathon_info.Location = new System.Drawing.Point(214, 122);
            this.marathon_info.Name = "marathon_info";
            this.marathon_info.Size = new System.Drawing.Size(339, 132);
            this.marathon_info.TabIndex = 26;
            this.marathon_info.Text = "Marathon Skills 2018";
            this.marathon_info.UseVisualStyleBackColor = true;
            // 
            // how_long
            // 
            this.how_long.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.how_long.Location = new System.Drawing.Point(705, 122);
            this.how_long.Name = "how_long";
            this.how_long.Size = new System.Drawing.Size(339, 132);
            this.how_long.TabIndex = 27;
            this.how_long.Text = "Насколько долгий марафон";
            this.how_long.UseVisualStyleBackColor = true;
            // 
            // last_rezults
            // 
            this.last_rezults.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_rezults.Location = new System.Drawing.Point(214, 306);
            this.last_rezults.Name = "last_rezults";
            this.last_rezults.Size = new System.Drawing.Size(339, 132);
            this.last_rezults.TabIndex = 28;
            this.last_rezults.Text = "Предыдущие результаты";
            this.last_rezults.UseVisualStyleBackColor = true;
            // 
            // list_organization
            // 
            this.list_organization.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_organization.Location = new System.Drawing.Point(705, 306);
            this.list_organization.Name = "list_organization";
            this.list_organization.Size = new System.Drawing.Size(339, 132);
            this.list_organization.TabIndex = 29;
            this.list_organization.Text = "Список благотворительных организаций";
            this.list_organization.UseVisualStyleBackColor = true;
            this.list_organization.Click += new System.EventHandler(this.list_organization_Click);
            // 
            // BMI_calculator
            // 
            this.BMI_calculator.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMI_calculator.Location = new System.Drawing.Point(214, 479);
            this.BMI_calculator.Name = "BMI_calculator";
            this.BMI_calculator.Size = new System.Drawing.Size(339, 132);
            this.BMI_calculator.TabIndex = 30;
            this.BMI_calculator.Text = "BMI калькулятор";
            this.BMI_calculator.UseVisualStyleBackColor = true;
            // 
            // BMR_calculator
            // 
            this.BMR_calculator.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMR_calculator.Location = new System.Drawing.Point(705, 479);
            this.BMR_calculator.Name = "BMR_calculator";
            this.BMR_calculator.Size = new System.Drawing.Size(339, 132);
            this.BMR_calculator.TabIndex = 31;
            this.BMR_calculator.Text = "BMR калькулятор";
            this.BMR_calculator.UseVisualStyleBackColor = true;
            // 
            // more_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 720);
            this.Controls.Add(this.BMR_calculator);
            this.Controls.Add(this.BMI_calculator);
            this.Controls.Add(this.list_organization);
            this.Controls.Add(this.last_rezults);
            this.Controls.Add(this.how_long);
            this.Controls.Add(this.marathon_info);
            this.Controls.Add(this.more_info_panel);
            this.Controls.Add(this.panel_1_sar);
            this.Controls.Add(this.panel_2_sar);
            this.Name = "more_information";
            this.Text = "more_information";
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
        private System.Windows.Forms.Label more_info_panel;
        private System.Windows.Forms.Button marathon_info;
        private System.Windows.Forms.Button how_long;
        private System.Windows.Forms.Button last_rezults;
        private System.Windows.Forms.Button list_organization;
        private System.Windows.Forms.Button BMI_calculator;
        private System.Windows.Forms.Button BMR_calculator;
    }
}