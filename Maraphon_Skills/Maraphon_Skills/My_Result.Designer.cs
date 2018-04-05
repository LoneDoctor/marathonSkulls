namespace Maraphon_Skills
{
    partial class My_Result
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
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.return_to_start = new System.Windows.Forms.Button();
            this.panel_2_start = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_1_sar.SuspendLayout();
            this.panel_2_start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_1_sar
            // 
            this.panel_1_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_1_sar.Controls.Add(this.Welcome);
            this.panel_1_sar.Controls.Add(this.return_to_start);
            this.panel_1_sar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1_sar.Location = new System.Drawing.Point(0, 0);
            this.panel_1_sar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_1_sar.Name = "panel_1_sar";
            this.panel_1_sar.Size = new System.Drawing.Size(823, 56);
            this.panel_1_sar.TabIndex = 28;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome.Location = new System.Drawing.Point(124, 11);
            this.Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(401, 37);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "MARATNON SKILLS 2018";
            // 
            // return_to_start
            // 
            this.return_to_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_to_start.Location = new System.Drawing.Point(9, 10);
            this.return_to_start.Margin = new System.Windows.Forms.Padding(2);
            this.return_to_start.Name = "return_to_start";
            this.return_to_start.Size = new System.Drawing.Size(94, 38);
            this.return_to_start.TabIndex = 2;
            this.return_to_start.Text = "Назад";
            this.return_to_start.UseVisualStyleBackColor = true;
            // 
            // panel_2_start
            // 
            this.panel_2_start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_2_start.Controls.Add(this.label1);
            this.panel_2_start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2_start.Location = new System.Drawing.Point(0, 448);
            this.panel_2_start.Margin = new System.Windows.Forms.Padding(2);
            this.panel_2_start.Name = "panel_2_start";
            this.panel_2_start.Size = new System.Drawing.Size(823, 55);
            this.panel_2_start.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(326, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время до старта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(325, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Мои результаты";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(81, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(712, 81);
            this.label3.TabIndex = 0;
            this.label3.Text = "Это - список всех ваших прошлых результатов гонки для Marathon Skills.\r\nОбщее мес" +
    "то сравнивает всех бегунов.\r\nМесто по категории compares runners in the same gen" +
    "der and age categories.\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 174);
            this.dataGridView1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(201, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Показать все результаты";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(197, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(251, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(350, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Возрастная категория: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(563, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "label7";
            // 
            // My_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 503);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_2_start);
            this.Controls.Add(this.panel_1_sar);
            this.Name = "My_Result";
            this.Text = "My_Result";
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            this.panel_2_start.ResumeLayout(false);
            this.panel_2_start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button return_to_start;
        private System.Windows.Forms.Panel panel_2_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}