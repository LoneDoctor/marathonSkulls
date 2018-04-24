namespace Maraphon_Skills
{
    partial class upload_volunters
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
            this.label_file_vol = new System.Windows.Forms.Label();
            this.label_upload_vol = new System.Windows.Forms.Label();
            this.textBox_name_CSV = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_observe = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label_file_vol
            // 
            this.label_file_vol.AutoSize = true;
            this.label_file_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_file_vol.Location = new System.Drawing.Point(304, 162);
            this.label_file_vol.Name = "label_file_vol";
            this.label_file_vol.Size = new System.Drawing.Size(354, 36);
            this.label_file_vol.TabIndex = 6;
            this.label_file_vol.Text = "CSV-файл волонтеров:";
            // 
            // label_upload_vol
            // 
            this.label_upload_vol.AutoSize = true;
            this.label_upload_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_upload_vol.Location = new System.Drawing.Point(544, 72);
            this.label_upload_vol.Name = "label_upload_vol";
            this.label_upload_vol.Size = new System.Drawing.Size(343, 38);
            this.label_upload_vol.TabIndex = 5;
            this.label_upload_vol.Text = "Загрузка волонтеров";
            // 
            // textBox_name_CSV
            // 
            this.textBox_name_CSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name_CSV.Location = new System.Drawing.Point(677, 157);
            this.textBox_name_CSV.Name = "textBox_name_CSV";
            this.textBox_name_CSV.ReadOnly = true;
            this.textBox_name_CSV.Size = new System.Drawing.Size(232, 41);
            this.textBox_name_CSV.TabIndex = 7;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(706, 261);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(147, 46);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_upload.Location = new System.Drawing.Point(521, 261);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(147, 46);
            this.button_upload.TabIndex = 9;
            this.button_upload.Text = "Загрузка";
            this.button_upload.UseVisualStyleBackColor = true;
            // 
            // button_observe
            // 
            this.button_observe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_observe.Location = new System.Drawing.Point(939, 150);
            this.button_observe.Name = "button_observe";
            this.button_observe.Size = new System.Drawing.Size(187, 48);
            this.button_observe.TabIndex = 10;
            this.button_observe.Text = "Просмотр...";
            this.button_observe.UseVisualStyleBackColor = true;
            this.button_observe.Click += new System.EventHandler(this.button_observe_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // upload_volunters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 884);
            this.Controls.Add(this.button_observe);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_name_CSV);
            this.Controls.Add(this.label_file_vol);
            this.Controls.Add(this.label_upload_vol);
            this.Name = "upload_volunters";
            this.Text = "upload_volunters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_file_vol;
        private System.Windows.Forms.Label label_upload_vol;
        private System.Windows.Forms.TextBox textBox_name_CSV;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_observe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}