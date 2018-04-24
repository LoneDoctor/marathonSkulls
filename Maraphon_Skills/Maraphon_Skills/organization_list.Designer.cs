namespace Maraphon_Skills
{
    partial class organization_list
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
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.return_to_start = new System.Windows.Forms.Button();
            this.time_to_start = new System.Windows.Forms.Label();
            this.panel_2_sar = new System.Windows.Forms.Panel();
            this.dataGridView_list_organization = new System.Windows.Forms.DataGridView();
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsDataSet = new Maraphon_Skills.wsDataSet();
            this.organization_panel = new System.Windows.Forms.Label();
            this.organization_panel_info = new System.Windows.Forms.Label();
            this.charityTableAdapter = new Maraphon_Skills.wsDataSetTableAdapters.CharityTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_1_sar.SuspendLayout();
            this.panel_2_sar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_organization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.panel_1_sar.TabIndex = 26;
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
            this.return_to_start.Click += new System.EventHandler(this.return_to_start_Click);
            // 
            // time_to_start
            // 
            this.time_to_start.AutoSize = true;
            this.time_to_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_to_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_to_start.Location = new System.Drawing.Point(434, 25);
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
            this.panel_2_sar.Location = new System.Drawing.Point(0, 670);
            this.panel_2_sar.Name = "panel_2_sar";
            this.panel_2_sar.Size = new System.Drawing.Size(1423, 68);
            this.panel_2_sar.TabIndex = 25;
            // 
            // dataGridView_list_organization
            // 
            this.dataGridView_list_organization.AllowUserToResizeColumns = false;
            this.dataGridView_list_organization.AllowUserToResizeRows = false;
            this.dataGridView_list_organization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_organization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_list_organization.Location = new System.Drawing.Point(50, 252);
            this.dataGridView_list_organization.Name = "dataGridView_list_organization";
            this.dataGridView_list_organization.RowTemplate.Height = 24;
            this.dataGridView_list_organization.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_list_organization.Size = new System.Drawing.Size(1320, 397);
            this.dataGridView_list_organization.TabIndex = 27;
            this.dataGridView_list_organization.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_organization_CellContentClick);
            // 
            // charityBindingSource
            // 
            this.charityBindingSource.DataMember = "Charity";
            this.charityBindingSource.DataSource = this.wsDataSet;
            // 
            // wsDataSet
            // 
            this.wsDataSet.DataSetName = "wsDataSet";
            this.wsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organization_panel
            // 
            this.organization_panel.AutoSize = true;
            this.organization_panel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organization_panel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.organization_panel.Location = new System.Drawing.Point(415, 121);
            this.organization_panel.Name = "organization_panel";
            this.organization_panel.Size = new System.Drawing.Size(531, 40);
            this.organization_panel.TabIndex = 28;
            this.organization_panel.Text = "Список благотворительных организаций";
            // 
            // organization_panel_info
            // 
            this.organization_panel_info.AutoSize = true;
            this.organization_panel_info.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organization_panel_info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.organization_panel_info.Location = new System.Drawing.Point(246, 161);
            this.organization_panel_info.Name = "organization_panel_info";
            this.organization_panel_info.Size = new System.Drawing.Size(911, 66);
            this.organization_panel_info.TabIndex = 29;
            this.organization_panel_info.Text = "Это - список всех благотворительных организаций,которые поддерживаются \r\nв Maraho" +
    "n Skills 2018. Спасибо за помощь вы поддерживаете их, спонсируя бегунов!";
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CharityId";
            this.Column2.HeaderText = "Column2";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 69;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 92;
            // 
            // organization_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 738);
            this.Controls.Add(this.organization_panel_info);
            this.Controls.Add(this.organization_panel);
            this.Controls.Add(this.dataGridView_list_organization);
            this.Controls.Add(this.panel_1_sar);
            this.Controls.Add(this.panel_2_sar);
            this.Name = "organization_list";
            this.Text = "organization_list";
            this.Load += new System.EventHandler(this.organization_list_Load);
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            this.panel_2_sar.ResumeLayout(false);
            this.panel_2_sar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_organization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button return_to_start;
        private System.Windows.Forms.Label time_to_start;
        private System.Windows.Forms.Panel panel_2_sar;
        public System.Windows.Forms.DataGridView dataGridView_list_organization;
        private System.Windows.Forms.Label organization_panel;
        private System.Windows.Forms.Label organization_panel_info;
        private wsDataSet wsDataSet;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private wsDataSetTableAdapters.CharityTableAdapter charityTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}