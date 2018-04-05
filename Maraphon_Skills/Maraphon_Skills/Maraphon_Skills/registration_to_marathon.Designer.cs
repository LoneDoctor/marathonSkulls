namespace Maraphon_Skills
{
    partial class registration_to_marathon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration_to_marathon));
            this.panel_2_sar = new System.Windows.Forms.Panel();
            this.time_to_start = new System.Windows.Forms.Label();
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.return_to_start = new System.Windows.Forms.Button();
            this.open_info_about_fond = new System.Windows.Forms.PictureBox();
            this.label_summ_pay = new System.Windows.Forms.Label();
            this.no_pay = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.summ_for_pay = new System.Windows.Forms.TextBox();
            this.summ_pay = new System.Windows.Forms.Label();
            this.label_name_fond = new System.Windows.Forms.Label();
            this.label_pay_for_nothing = new System.Windows.Forms.Label();
            this.comboBox_vznos = new System.Windows.Forms.ComboBox();
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsDataSet = new Maraphon_Skills.wsDataSet();
            this.label_pay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_full_marathon = new System.Windows.Forms.CheckBox();
            this.checkBox_halfMarathon = new System.Windows.Forms.CheckBox();
            this.checkBox_shortDistance = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_A = new System.Windows.Forms.RadioButton();
            this.radioButton_B = new System.Windows.Forms.RadioButton();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.sponsorshipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorshipTableAdapter = new Maraphon_Skills.wsDataSetTableAdapters.SponsorshipTableAdapter();
            this.charityTableAdapter = new Maraphon_Skills.wsDataSetTableAdapters.CharityTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.return_to_main_window = new System.Windows.Forms.Button();
            this.fond_information = new System.Windows.Forms.TextBox();
            this.fond_name = new System.Windows.Forms.Label();
            this.fond_label = new System.Windows.Forms.PictureBox();
            this.panel_2_sar.SuspendLayout();
            this.panel_1_sar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_info_about_fond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorshipBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fond_label)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_2_sar
            // 
            this.panel_2_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_2_sar.Controls.Add(this.time_to_start);
            this.panel_2_sar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2_sar.Location = new System.Drawing.Point(0, 816);
            this.panel_2_sar.Name = "panel_2_sar";
            this.panel_2_sar.Size = new System.Drawing.Size(1423, 68);
            this.panel_2_sar.TabIndex = 30;
            // 
            // time_to_start
            // 
            this.time_to_start.AutoSize = true;
            this.time_to_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_to_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_to_start.Location = new System.Drawing.Point(352, 23);
            this.time_to_start.Name = "time_to_start";
            this.time_to_start.Size = new System.Drawing.Size(262, 36);
            this.time_to_start.TabIndex = 4;
            this.time_to_start.Text = "Время до старта";
            this.time_to_start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel_1_sar
            // 
            this.panel_1_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_1_sar.Controls.Add(this.button_logout);
            this.panel_1_sar.Controls.Add(this.Welcome);
            this.panel_1_sar.Controls.Add(this.return_to_start);
            this.panel_1_sar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1_sar.Location = new System.Drawing.Point(0, 0);
            this.panel_1_sar.Name = "panel_1_sar";
            this.panel_1_sar.Size = new System.Drawing.Size(1423, 69);
            this.panel_1_sar.TabIndex = 31;
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logout.Location = new System.Drawing.Point(1286, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(125, 47);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome.Location = new System.Drawing.Point(165, 13);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(503, 46);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "MARAPNON SKILLS 2018";
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
            // open_info_about_fond
            // 
            this.open_info_about_fond.BackColor = System.Drawing.Color.White;
            this.open_info_about_fond.ErrorImage = ((System.Drawing.Image)(resources.GetObject("open_info_about_fond.ErrorImage")));
            this.open_info_about_fond.Image = global::Maraphon_Skills.Properties.Resources._2306085;
            this.open_info_about_fond.InitialImage = global::Maraphon_Skills.Properties.Resources.sign_computer_icon_symbol_signs_info_information;
            this.open_info_about_fond.Location = new System.Drawing.Point(603, 524);
            this.open_info_about_fond.Name = "open_info_about_fond";
            this.open_info_about_fond.Size = new System.Drawing.Size(100, 100);
            this.open_info_about_fond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.open_info_about_fond.TabIndex = 33;
            this.open_info_about_fond.TabStop = false;
            this.open_info_about_fond.Click += new System.EventHandler(this.open_info_about_fond_Click);
            // 
            // label_summ_pay
            // 
            this.label_summ_pay.AutoSize = true;
            this.label_summ_pay.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_summ_pay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_summ_pay.Location = new System.Drawing.Point(929, 560);
            this.label_summ_pay.Name = "label_summ_pay";
            this.label_summ_pay.Size = new System.Drawing.Size(411, 38);
            this.label_summ_pay.TabIndex = 41;
            this.label_summ_pay.Text = "Регистрационный взнос";
            // 
            // no_pay
            // 
            this.no_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no_pay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no_pay.Location = new System.Drawing.Point(543, 674);
            this.no_pay.Name = "no_pay";
            this.no_pay.Size = new System.Drawing.Size(160, 60);
            this.no_pay.TabIndex = 40;
            this.no_pay.Text = "Отмена";
            this.no_pay.UseVisualStyleBackColor = true;
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pay.Location = new System.Drawing.Point(324, 674);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(202, 60);
            this.pay.TabIndex = 39;
            this.pay.Text = "Регистрация";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // summ_for_pay
            // 
            this.summ_for_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summ_for_pay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.summ_for_pay.Location = new System.Drawing.Point(324, 630);
            this.summ_for_pay.MaxLength = 10;
            this.summ_for_pay.Name = "summ_for_pay";
            this.summ_for_pay.Size = new System.Drawing.Size(249, 38);
            this.summ_for_pay.TabIndex = 36;
            this.summ_for_pay.Text = "$ 00";
            this.summ_for_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.summ_for_pay.TextChanged += new System.EventHandler(this.summ_for_pay_TextChanged);
            // 
            // summ_pay
            // 
            this.summ_pay.AutoSize = true;
            this.summ_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summ_pay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.summ_pay.Location = new System.Drawing.Point(1050, 598);
            this.summ_pay.Name = "summ_pay";
            this.summ_pay.Size = new System.Drawing.Size(171, 91);
            this.summ_pay.TabIndex = 35;
            this.summ_pay.Text = "$00";
            // 
            // label_name_fond
            // 
            this.label_name_fond.AutoSize = true;
            this.label_name_fond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_fond.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_name_fond.Location = new System.Drawing.Point(1026, 191);
            this.label_name_fond.Name = "label_name_fond";
            this.label_name_fond.Size = new System.Drawing.Size(308, 32);
            this.label_name_fond.TabIndex = 34;
            this.label_name_fond.Text = "Наименование фонда";
            // 
            // label_pay_for_nothing
            // 
            this.label_pay_for_nothing.AutoSize = true;
            this.label_pay_for_nothing.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pay_for_nothing.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_pay_for_nothing.Location = new System.Drawing.Point(510, 101);
            this.label_pay_for_nothing.Name = "label_pay_for_nothing";
            this.label_pay_for_nothing.Size = new System.Drawing.Size(423, 38);
            this.label_pay_for_nothing.TabIndex = 32;
            this.label_pay_for_nothing.Text = "Регистрация на марафон";
            // 
            // comboBox_vznos
            // 
            this.comboBox_vznos.DataSource = this.charityBindingSource;
            this.comboBox_vznos.DisplayMember = "CharityName";
            this.comboBox_vznos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_vznos.FormattingEnabled = true;
            this.comboBox_vznos.Location = new System.Drawing.Point(324, 578);
            this.comboBox_vznos.Name = "comboBox_vznos";
            this.comboBox_vznos.Size = new System.Drawing.Size(249, 39);
            this.comboBox_vznos.TabIndex = 42;
            this.comboBox_vznos.SelectedIndexChanged += new System.EventHandler(this.comboBox_vznos_SelectedIndexChanged);
            // 
            // charityBindingSource
            // 
            this.charityBindingSource.DataMember = "Charity";
            this.charityBindingSource.DataSource = this.wsDataSetBindingSource;
            // 
            // wsDataSetBindingSource
            // 
            this.wsDataSetBindingSource.DataSource = this.wsDataSet;
            this.wsDataSetBindingSource.Position = 0;
            // 
            // wsDataSet
            // 
            this.wsDataSet.DataSetName = "wsDataSet";
            this.wsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_pay
            // 
            this.label_pay.AutoSize = true;
            this.label_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pay.Location = new System.Drawing.Point(173, 585);
            this.label_pay.Name = "label_pay";
            this.label_pay.Size = new System.Drawing.Size(102, 32);
            this.label_pay.TabIndex = 43;
            this.label_pay.Text = "Взнос:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Сумма взноса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(276, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "Детали спонсорства";
            // 
            // checkBox_full_marathon
            // 
            this.checkBox_full_marathon.AutoSize = true;
            this.checkBox_full_marathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_full_marathon.Location = new System.Drawing.Point(99, 252);
            this.checkBox_full_marathon.Name = "checkBox_full_marathon";
            this.checkBox_full_marathon.Size = new System.Drawing.Size(436, 36);
            this.checkBox_full_marathon.TabIndex = 46;
            this.checkBox_full_marathon.Text = "42км Полный Марафон ($145)";
            this.checkBox_full_marathon.UseVisualStyleBackColor = true;
            this.checkBox_full_marathon.Click += new System.EventHandler(this.checkBox_full_marathon_Click);
            // 
            // checkBox_halfMarathon
            // 
            this.checkBox_halfMarathon.AutoSize = true;
            this.checkBox_halfMarathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_halfMarathon.Location = new System.Drawing.Point(99, 294);
            this.checkBox_halfMarathon.Name = "checkBox_halfMarathon";
            this.checkBox_halfMarathon.Size = new System.Drawing.Size(368, 36);
            this.checkBox_halfMarathon.TabIndex = 47;
            this.checkBox_halfMarathon.Text = "21км полумарафон ($75)";
            this.checkBox_halfMarathon.UseVisualStyleBackColor = true;
            this.checkBox_halfMarathon.Click += new System.EventHandler(this.checkBox_halfMarathon_Click);
            // 
            // checkBox_shortDistance
            // 
            this.checkBox_shortDistance.AutoSize = true;
            this.checkBox_shortDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_shortDistance.Location = new System.Drawing.Point(99, 336);
            this.checkBox_shortDistance.Name = "checkBox_shortDistance";
            this.checkBox_shortDistance.Size = new System.Drawing.Size(395, 36);
            this.checkBox_shortDistance.TabIndex = 48;
            this.checkBox_shortDistance.Text = "5км малая дистанция ($20)";
            this.checkBox_shortDistance.UseVisualStyleBackColor = true;
            this.checkBox_shortDistance.Click += new System.EventHandler(this.checkBox_shortDistance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(64, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "Наименование фонда";
            // 
            // radioButton_A
            // 
            this.radioButton_A.AutoSize = true;
            this.radioButton_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_A.Location = new System.Drawing.Point(1066, 229);
            this.radioButton_A.Name = "radioButton_A";
            this.radioButton_A.Size = new System.Drawing.Size(231, 36);
            this.radioButton_A.TabIndex = 50;
            this.radioButton_A.TabStop = true;
            this.radioButton_A.Text = "Вариант А ($0)";
            this.radioButton_A.UseVisualStyleBackColor = true;
            this.radioButton_A.Click += new System.EventHandler(this.radioButton_A_Click);
            // 
            // radioButton_B
            // 
            this.radioButton_B.AutoSize = true;
            this.radioButton_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_B.Location = new System.Drawing.Point(1066, 294);
            this.radioButton_B.Name = "radioButton_B";
            this.radioButton_B.Size = new System.Drawing.Size(247, 36);
            this.radioButton_B.TabIndex = 51;
            this.radioButton_B.TabStop = true;
            this.radioButton_B.Text = "Вариант B ($20)";
            this.radioButton_B.UseVisualStyleBackColor = true;
            this.radioButton_B.CheckedChanged += new System.EventHandler(this.radioButton_B_CheckedChanged);
            // 
            // radioButton_C
            // 
            this.radioButton_C.AutoSize = true;
            this.radioButton_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_C.Location = new System.Drawing.Point(1066, 358);
            this.radioButton_C.Name = "radioButton_C";
            this.radioButton_C.Size = new System.Drawing.Size(248, 36);
            this.radioButton_C.TabIndex = 52;
            this.radioButton_C.TabStop = true;
            this.radioButton_C.Text = "Вариант С ($45)";
            this.radioButton_C.UseVisualStyleBackColor = true;
            this.radioButton_C.CheckedChanged += new System.EventHandler(this.radioButton_C_CheckedChanged);
            // 
            // sponsorshipBindingSource
            // 
            this.sponsorshipBindingSource.DataMember = "Sponsorship";
            this.sponsorshipBindingSource.DataSource = this.wsDataSetBindingSource;
            // 
            // sponsorshipTableAdapter
            // 
            this.sponsorshipTableAdapter.ClearBeforeFill = true;
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.return_to_main_window);
            this.panel1.Controls.Add(this.fond_information);
            this.panel1.Controls.Add(this.fond_name);
            this.panel1.Controls.Add(this.fond_label);
            this.panel1.Location = new System.Drawing.Point(631, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 432);
            this.panel1.TabIndex = 53;
            this.panel1.Visible = false;
            // 
            // return_to_main_window
            // 
            this.return_to_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_to_main_window.Location = new System.Drawing.Point(21, 6);
            this.return_to_main_window.Name = "return_to_main_window";
            this.return_to_main_window.Size = new System.Drawing.Size(125, 47);
            this.return_to_main_window.TabIndex = 4;
            this.return_to_main_window.Text = "Назад";
            this.return_to_main_window.UseVisualStyleBackColor = true;
            this.return_to_main_window.Click += new System.EventHandler(this.return_to_main_window_Click);
            // 
            // fond_information
            // 
            this.fond_information.Location = new System.Drawing.Point(44, 227);
            this.fond_information.Multiline = true;
            this.fond_information.Name = "fond_information";
            this.fond_information.Size = new System.Drawing.Size(515, 166);
            this.fond_information.TabIndex = 2;
            // 
            // fond_name
            // 
            this.fond_name.AutoSize = true;
            this.fond_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fond_name.Location = new System.Drawing.Point(270, 36);
            this.fond_name.Name = "fond_name";
            this.fond_name.Size = new System.Drawing.Size(93, 32);
            this.fond_name.TabIndex = 1;
            this.fond_name.Text = "label9";
            // 
            // fond_label
            // 
            this.fond_label.Location = new System.Drawing.Point(80, 84);
            this.fond_label.Name = "fond_label";
            this.fond_label.Size = new System.Drawing.Size(426, 137);
            this.fond_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fond_label.TabIndex = 0;
            this.fond_label.TabStop = false;
            // 
            // registration_to_marathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 884);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton_C);
            this.Controls.Add(this.radioButton_B);
            this.Controls.Add(this.radioButton_A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_shortDistance);
            this.Controls.Add(this.checkBox_halfMarathon);
            this.Controls.Add(this.checkBox_full_marathon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_pay);
            this.Controls.Add(this.comboBox_vznos);
            this.Controls.Add(this.open_info_about_fond);
            this.Controls.Add(this.label_summ_pay);
            this.Controls.Add(this.no_pay);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.summ_for_pay);
            this.Controls.Add(this.summ_pay);
            this.Controls.Add(this.label_name_fond);
            this.Controls.Add(this.label_pay_for_nothing);
            this.Controls.Add(this.panel_2_sar);
            this.Controls.Add(this.panel_1_sar);
            this.Name = "registration_to_marathon";
            this.Text = "registration_to_marathon";
            this.Load += new System.EventHandler(this.registration_to_marathon_Load);
            this.panel_2_sar.ResumeLayout(false);
            this.panel_2_sar.PerformLayout();
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_info_about_fond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorshipBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fond_label)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_2_sar;
        private System.Windows.Forms.Label time_to_start;
        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button return_to_start;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.PictureBox open_info_about_fond;
        private System.Windows.Forms.Label label_summ_pay;
        private System.Windows.Forms.Button no_pay;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.TextBox summ_for_pay;
        public System.Windows.Forms.Label summ_pay;
        public System.Windows.Forms.Label label_name_fond;
        private System.Windows.Forms.Label label_pay_for_nothing;
        private System.Windows.Forms.ComboBox comboBox_vznos;
        private System.Windows.Forms.BindingSource wsDataSetBindingSource;
        private wsDataSet wsDataSet;
        private System.Windows.Forms.Label label_pay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_full_marathon;
        private System.Windows.Forms.CheckBox checkBox_halfMarathon;
        private System.Windows.Forms.CheckBox checkBox_shortDistance;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_A;
        private System.Windows.Forms.RadioButton radioButton_B;
        private System.Windows.Forms.RadioButton radioButton_C;
        private System.Windows.Forms.BindingSource sponsorshipBindingSource;
        private wsDataSetTableAdapters.SponsorshipTableAdapter sponsorshipTableAdapter;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private wsDataSetTableAdapters.CharityTableAdapter charityTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button return_to_main_window;
        private System.Windows.Forms.TextBox fond_information;
        private System.Windows.Forms.Label fond_name;
        private System.Windows.Forms.PictureBox fond_label;
    }
}