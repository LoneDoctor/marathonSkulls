namespace Maraphon_Skills
{
    partial class Runner_choise
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
            this.I_wanna_stay_runner = new System.Windows.Forms.Button();
            this.panel_2_start = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.I_was_runner = new System.Windows.Forms.Button();
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.return_to_start = new System.Windows.Forms.Button();
            this.panel_2_start.SuspendLayout();
            this.panel_1_sar.SuspendLayout();
            this.SuspendLayout();
            // 
            // I_wanna_stay_runner
            // 
            this.I_wanna_stay_runner.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_wanna_stay_runner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.I_wanna_stay_runner.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.I_wanna_stay_runner.Location = new System.Drawing.Point(440, 424);
            this.I_wanna_stay_runner.Name = "I_wanna_stay_runner";
            this.I_wanna_stay_runner.Size = new System.Drawing.Size(577, 131);
            this.I_wanna_stay_runner.TabIndex = 3;
            this.I_wanna_stay_runner.Text = "Я новый участник";
            this.I_wanna_stay_runner.UseVisualStyleBackColor = true;
            this.I_wanna_stay_runner.Click += new System.EventHandler(this.I_wanna_stay_runner_Click);
            // 
            // panel_2_start
            // 
            this.panel_2_start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_2_start.Controls.Add(this.label1);
            this.panel_2_start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2_start.Location = new System.Drawing.Point(0, 816);
            this.panel_2_start.Name = "panel_2_start";
            this.panel_2_start.Size = new System.Drawing.Size(1423, 68);
            this.panel_2_start.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(434, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время до старта";
            // 
            // I_was_runner
            // 
            this.I_was_runner.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_was_runner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.I_was_runner.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.I_was_runner.Location = new System.Drawing.Point(440, 270);
            this.I_was_runner.Name = "I_was_runner";
            this.I_was_runner.Size = new System.Drawing.Size(577, 131);
            this.I_was_runner.TabIndex = 6;
            this.I_was_runner.Text = "Я учавствовал ранее";
            this.I_was_runner.UseVisualStyleBackColor = true;
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
            this.panel_1_sar.TabIndex = 27;
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
            // return_to_start
            // 
            this.return_to_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_to_start.Location = new System.Drawing.Point(12, 12);
            this.return_to_start.Name = "return_to_start";
            this.return_to_start.Size = new System.Drawing.Size(125, 47);
            this.return_to_start.TabIndex = 2;
            this.return_to_start.Text = "Назад";
            this.return_to_start.UseVisualStyleBackColor = true;
            // 
            // Runner_choise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 884);
            this.Controls.Add(this.panel_1_sar);
            this.Controls.Add(this.I_was_runner);
            this.Controls.Add(this.panel_2_start);
            this.Controls.Add(this.I_wanna_stay_runner);
            this.Name = "Runner_choise";
            this.Text = "Runner_choise";
            this.panel_2_start.ResumeLayout(false);
            this.panel_2_start.PerformLayout();
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button I_wanna_stay_runner;
        private System.Windows.Forms.Panel panel_2_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button I_was_runner;
        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button return_to_start;
    }
}