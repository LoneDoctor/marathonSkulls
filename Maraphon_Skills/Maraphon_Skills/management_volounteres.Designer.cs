namespace Maraphon_Skills
{
    partial class management_volounteres
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
            this.label_manage_vol = new System.Windows.Forms.Label();
            this.label_upload = new System.Windows.Forms.Label();
            this.label_ort_and_filtr = new System.Windows.Forms.Label();
            this.comboBox_sort = new System.Windows.Forms.ComboBox();
            this.label_sort_to = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.label_all_vol = new System.Windows.Forms.Label();
            this.label_number_vol = new System.Windows.Forms.Label();
            this.dataGridView_volounteres = new System.Windows.Forms.DataGridView();
            this.wsDataSet = new Maraphon_Skills.wsDataSet();
            this.wsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volunteerTableAdapter = new Maraphon_Skills.wsDataSetTableAdapters.VolunteerTableAdapter();
            this.volunteerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_volounteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_manage_vol
            // 
            this.label_manage_vol.AutoSize = true;
            this.label_manage_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_manage_vol.Location = new System.Drawing.Point(506, 56);
            this.label_manage_vol.Name = "label_manage_vol";
            this.label_manage_vol.Size = new System.Drawing.Size(428, 39);
            this.label_manage_vol.TabIndex = 0;
            this.label_manage_vol.Text = "Управление волонтерами";
            // 
            // label_upload
            // 
            this.label_upload.AutoSize = true;
            this.label_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_upload.Location = new System.Drawing.Point(1067, 153);
            this.label_upload.Name = "label_upload";
            this.label_upload.Size = new System.Drawing.Size(150, 36);
            this.label_upload.TabIndex = 1;
            this.label_upload.Text = "Загрузка";
            // 
            // label_ort_and_filtr
            // 
            this.label_ort_and_filtr.AutoSize = true;
            this.label_ort_and_filtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ort_and_filtr.Location = new System.Drawing.Point(55, 153);
            this.label_ort_and_filtr.Name = "label_ort_and_filtr";
            this.label_ort_and_filtr.Size = new System.Drawing.Size(408, 36);
            this.label_ort_and_filtr.TabIndex = 2;
            this.label_ort_and_filtr.Text = "Сортировка и фильтрация";
            // 
            // comboBox_sort
            // 
            this.comboBox_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_sort.FormattingEnabled = true;
            this.comboBox_sort.Location = new System.Drawing.Point(317, 219);
            this.comboBox_sort.Name = "comboBox_sort";
            this.comboBox_sort.Size = new System.Drawing.Size(236, 39);
            this.comboBox_sort.TabIndex = 3;
            this.comboBox_sort.SelectedIndexChanged += new System.EventHandler(this.comboBox_sort_SelectedIndexChanged);
            // 
            // label_sort_to
            // 
            this.label_sort_to.AutoSize = true;
            this.label_sort_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sort_to.Location = new System.Drawing.Point(27, 222);
            this.label_sort_to.Name = "label_sort_to";
            this.label_sort_to.Size = new System.Drawing.Size(255, 36);
            this.label_sort_to.TabIndex = 4;
            this.label_sort_to.Text = "Сортировать по:";
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.Location = new System.Drawing.Point(317, 295);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(174, 54);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_upload.Location = new System.Drawing.Point(974, 204);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(330, 54);
            this.button_upload.TabIndex = 6;
            this.button_upload.Text = "Загрузка волонтеров";
            this.button_upload.UseVisualStyleBackColor = true;
            // 
            // label_all_vol
            // 
            this.label_all_vol.AutoSize = true;
            this.label_all_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_all_vol.Location = new System.Drawing.Point(541, 388);
            this.label_all_vol.Name = "label_all_vol";
            this.label_all_vol.Size = new System.Drawing.Size(301, 36);
            this.label_all_vol.TabIndex = 7;
            this.label_all_vol.Text = "Всего волонтеров:";
            // 
            // label_number_vol
            // 
            this.label_number_vol.AutoSize = true;
            this.label_number_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_vol.Location = new System.Drawing.Point(848, 388);
            this.label_number_vol.Name = "label_number_vol";
            this.label_number_vol.Size = new System.Drawing.Size(66, 36);
            this.label_number_vol.TabIndex = 8;
            this.label_number_vol.Text = "111";
            // 
            // dataGridView_volounteres
            // 
            this.dataGridView_volounteres.AutoGenerateColumns = false;
            this.dataGridView_volounteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_volounteres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView_volounteres.DataSource = this.volunteerBindingSource;
            this.dataGridView_volounteres.Location = new System.Drawing.Point(491, 427);
            this.dataGridView_volounteres.Name = "dataGridView_volounteres";
            this.dataGridView_volounteres.RowTemplate.Height = 24;
            this.dataGridView_volounteres.Size = new System.Drawing.Size(443, 291);
            this.dataGridView_volounteres.TabIndex = 9;
            // 
            // wsDataSet
            // 
            this.wsDataSet.DataSetName = "wsDataSet";
            this.wsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wsDataSetBindingSource
            // 
            this.wsDataSetBindingSource.DataSource = this.wsDataSet;
            this.wsDataSetBindingSource.Position = 0;
            // 
            // volunteerBindingSource
            // 
            this.volunteerBindingSource.DataMember = "Volunteer";
            this.volunteerBindingSource.DataSource = this.wsDataSetBindingSource;
            // 
            // volunteerTableAdapter
            // 
            this.volunteerTableAdapter.ClearBeforeFill = true;
            // 
            // volunteerBindingSource1
            // 
            this.volunteerBindingSource1.DataMember = "Volunteer";
            this.volunteerBindingSource1.DataSource = this.wsDataSetBindingSource;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // management_volounteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 884);
            this.Controls.Add(this.dataGridView_volounteres);
            this.Controls.Add(this.label_number_vol);
            this.Controls.Add(this.label_all_vol);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label_sort_to);
            this.Controls.Add(this.comboBox_sort);
            this.Controls.Add(this.label_ort_and_filtr);
            this.Controls.Add(this.label_upload);
            this.Controls.Add(this.label_manage_vol);
            this.Name = "management_volounteres";
            this.Text = "management_volounteres";
            this.Load += new System.EventHandler(this.management_volounteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_volounteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_manage_vol;
        private System.Windows.Forms.Label label_upload;
        private System.Windows.Forms.Label label_ort_and_filtr;
        private System.Windows.Forms.ComboBox comboBox_sort;
        private System.Windows.Forms.Label label_sort_to;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Label label_all_vol;
        private System.Windows.Forms.Label label_number_vol;
        private System.Windows.Forms.DataGridView dataGridView_volounteres;
        private System.Windows.Forms.BindingSource wsDataSetBindingSource;
        private wsDataSet wsDataSet;
        private System.Windows.Forms.BindingSource volunteerBindingSource;
        private wsDataSetTableAdapters.VolunteerTableAdapter volunteerTableAdapter;
        private System.Windows.Forms.BindingSource volunteerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}