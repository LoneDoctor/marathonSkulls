namespace Maraphon_Skills
{
    partial class registration
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
            this.Welcome = new System.Windows.Forms.Label();
            this.return_to_start = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_CVC = new System.Windows.Forms.Label();
            this.label_secondName = new System.Windows.Forms.Label();
            this.label_number_card = new System.Windows.Forms.Label();
            this.textBox_repeatPassword = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_card = new System.Windows.Forms.Label();
            this.label_runner = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.time_to_start = new System.Windows.Forms.Label();
            this.panel_1_sar = new System.Windows.Forms.Panel();
            this.panel_2_sar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textBox_SecondName = new System.Windows.Forms.TextBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsDataSet1 = new Maraphon_Skills.wsDataSet1();
            this.pictureBox_runner_photo = new System.Windows.Forms.PictureBox();
            this.textBox_name_photo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Open_choise_photo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.countryTableAdapter = new Maraphon_Skills.wsDataSet1TableAdapters.CountryTableAdapter();
            this.genderTableAdapter = new Maraphon_Skills.wsDataSet1TableAdapters.GenderTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_1_sar.SuspendLayout();
            this.panel_2_sar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_runner_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_name.Location = new System.Drawing.Point(283, 414);
            this.textBox_name.MaxLength = 16;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(318, 39);
            this.textBox_name.TabIndex = 40;
            this.textBox_name.Text = "Имя";
            this.textBox_name.Click += new System.EventHandler(this.textBox_name_Click);
            // 
            // label_CVC
            // 
            this.label_CVC.AutoSize = true;
            this.label_CVC.CausesValidation = false;
            this.label_CVC.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CVC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_CVC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_CVC.Location = new System.Drawing.Point(182, 535);
            this.label_CVC.Name = "label_CVC";
            this.label_CVC.Size = new System.Drawing.Size(76, 40);
            this.label_CVC.TabIndex = 39;
            this.label_CVC.Text = "Пол:";
            // 
            // label_secondName
            // 
            this.label_secondName.AutoSize = true;
            this.label_secondName.CausesValidation = false;
            this.label_secondName.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_secondName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_secondName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_secondName.Location = new System.Drawing.Point(124, 476);
            this.label_secondName.Name = "label_secondName";
            this.label_secondName.Size = new System.Drawing.Size(141, 40);
            this.label_secondName.TabIndex = 36;
            this.label_secondName.Text = "Фамилия:";
            // 
            // label_number_card
            // 
            this.label_number_card.AutoSize = true;
            this.label_number_card.CausesValidation = false;
            this.label_number_card.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_card.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_number_card.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_number_card.Location = new System.Drawing.Point(191, 414);
            this.label_number_card.Name = "label_number_card";
            this.label_number_card.Size = new System.Drawing.Size(78, 40);
            this.label_number_card.TabIndex = 35;
            this.label_number_card.Text = "Имя:";
            // 
            // textBox_repeatPassword
            // 
            this.textBox_repeatPassword.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_repeatPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_repeatPassword.Location = new System.Drawing.Point(283, 354);
            this.textBox_repeatPassword.Name = "textBox_repeatPassword";
            this.textBox_repeatPassword.Size = new System.Drawing.Size(318, 39);
            this.textBox_repeatPassword.TabIndex = 34;
            this.textBox_repeatPassword.Text = "Повторите пароль:";
            this.textBox_repeatPassword.Click += new System.EventHandler(this.textBox_repeatPassword_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_password.Location = new System.Drawing.Point(280, 284);
            this.textBox_password.MaxLength = 20;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(321, 39);
            this.textBox_password.TabIndex = 33;
            this.textBox_password.Text = "Пароль";
            this.textBox_password.Click += new System.EventHandler(this.textBox_password_Click);
            // 
            // label_card
            // 
            this.label_card.AutoSize = true;
            this.label_card.CausesValidation = false;
            this.label_card.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_card.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_card.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_card.Location = new System.Drawing.Point(9, 353);
            this.label_card.Name = "label_card";
            this.label_card.Size = new System.Drawing.Size(256, 40);
            this.label_card.TabIndex = 32;
            this.label_card.Text = "Повторите пароль:";
            // 
            // label_runner
            // 
            this.label_runner.AutoSize = true;
            this.label_runner.CausesValidation = false;
            this.label_runner.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_runner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_runner.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_runner.Location = new System.Drawing.Point(145, 284);
            this.label_runner.Name = "label_runner";
            this.label_runner.Size = new System.Drawing.Size(120, 40);
            this.label_runner.TabIndex = 31;
            this.label_runner.Text = "Пароль:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.CausesValidation = false;
            this.label_name.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_name.Location = new System.Drawing.Point(163, 225);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(102, 40);
            this.label_name.TabIndex = 30;
            this.label_name.Text = "E-Mail:";
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
            this.panel_1_sar.Controls.Add(this.Welcome);
            this.panel_1_sar.Controls.Add(this.return_to_start);
            this.panel_1_sar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1_sar.Location = new System.Drawing.Point(0, 0);
            this.panel_1_sar.Name = "panel_1_sar";
            this.panel_1_sar.Size = new System.Drawing.Size(1423, 69);
            this.panel_1_sar.TabIndex = 29;
            // 
            // panel_2_sar
            // 
            this.panel_2_sar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_2_sar.Controls.Add(this.time_to_start);
            this.panel_2_sar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2_sar.Location = new System.Drawing.Point(0, 816);
            this.panel_2_sar.Name = "panel_2_sar";
            this.panel_2_sar.Size = new System.Drawing.Size(1423, 68);
            this.panel_2_sar.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(169, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1039, 35);
            this.label3.TabIndex = 45;
            this.label3.Text = "Пожалуйста, заполните всю информацию, что бы зарегистрироваться в качестве бегуна" +
    "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(583, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 46);
            this.label2.TabIndex = 44;
            this.label2.Text = "Регистрация Бегуна";
            // 
            // textbox_email
            // 
            this.textbox_email.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textbox_email.Location = new System.Drawing.Point(280, 225);
            this.textbox_email.MaxLength = 20;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(362, 39);
            this.textbox_email.TabIndex = 46;
            this.textbox_email.Text = "E-Mail";
            this.textbox_email.Click += new System.EventHandler(this.textbox_email_Click);
            // 
            // textBox_SecondName
            // 
            this.textBox_SecondName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SecondName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_SecondName.Location = new System.Drawing.Point(280, 476);
            this.textBox_SecondName.MaxLength = 16;
            this.textBox_SecondName.Name = "textBox_SecondName";
            this.textBox_SecondName.Size = new System.Drawing.Size(321, 39);
            this.textBox_SecondName.TabIndex = 47;
            this.textBox_SecondName.Text = "Фамилия";
            this.textBox_SecondName.Click += new System.EventHandler(this.textBox_SecondName_Click);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.DataSource = this.genderBindingSource;
            this.comboBox_Gender.DisplayMember = "Gender";
            this.comboBox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Gender.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Location = new System.Drawing.Point(280, 536);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(321, 39);
            this.comboBox_Gender.TabIndex = 48;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.wsDataSet1BindingSource;
            // 
            // wsDataSet1BindingSource
            // 
            this.wsDataSet1BindingSource.DataSource = this.wsDataSet1;
            this.wsDataSet1BindingSource.Position = 0;
            // 
            // wsDataSet1
            // 
            this.wsDataSet1.DataSetName = "wsDataSet1";
            this.wsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox_runner_photo
            // 
            this.pictureBox_runner_photo.Location = new System.Drawing.Point(1226, 204);
            this.pictureBox_runner_photo.Name = "pictureBox_runner_photo";
            this.pictureBox_runner_photo.Size = new System.Drawing.Size(157, 205);
            this.pictureBox_runner_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_runner_photo.TabIndex = 49;
            this.pictureBox_runner_photo.TabStop = false;
            // 
            // textBox_name_photo
            // 
            this.textBox_name_photo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name_photo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_name_photo.Location = new System.Drawing.Point(881, 418);
            this.textBox_name_photo.MaxLength = 16;
            this.textBox_name_photo.Name = "textBox_name_photo";
            this.textBox_name_photo.ReadOnly = true;
            this.textBox_name_photo.Size = new System.Drawing.Size(295, 39);
            this.textBox_name_photo.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(914, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 51;
            this.label1.Text = "Фото-файл:";
            // 
            // Open_choise_photo
            // 
            this.Open_choise_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open_choise_photo.Location = new System.Drawing.Point(1197, 416);
            this.Open_choise_photo.Name = "Open_choise_photo";
            this.Open_choise_photo.Size = new System.Drawing.Size(186, 41);
            this.Open_choise_photo.TabIndex = 52;
            this.Open_choise_photo.Text = "Обзор";
            this.Open_choise_photo.UseVisualStyleBackColor = true;
            this.Open_choise_photo.Click += new System.EventHandler(this.Open_choise_photo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(874, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 40);
            this.label4.TabIndex = 53;
            this.label4.Text = "Дата Рождения:";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirth.Location = new System.Drawing.Point(1112, 478);
            this.dateOfBirth.MaxDate = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            this.dateOfBirth.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(271, 38);
            this.dateOfBirth.TabIndex = 54;
            this.dateOfBirth.Value = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(992, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 40);
            this.label5.TabIndex = 55;
            this.label5.Text = "Страна:";
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.DataSource = this.countryBindingSource;
            this.comboBox_Country.DisplayMember = "CountryName";
            this.comboBox_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Country.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(1115, 535);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(268, 39);
            this.comboBox_Country.TabIndex = 56;
            this.comboBox_Country.ValueMember = "CountryCode";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.wsDataSet1BindingSource;
            // 
            // registrat
            // 
            this.registrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrat.Location = new System.Drawing.Point(515, 667);
            this.registrat.Name = "registrat";
            this.registrat.Size = new System.Drawing.Size(204, 68);
            this.registrat.TabIndex = 57;
            this.registrat.Text = "Регистрация";
            this.registrat.UseVisualStyleBackColor = true;
            this.registrat.Click += new System.EventHandler(this.registrat_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(761, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 68);
            this.button3.TabIndex = 58;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 651);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 59;
            this.textBox1.Visible = false;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 884);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.registrat);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Open_choise_photo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name_photo);
            this.Controls.Add(this.pictureBox_runner_photo);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.textBox_SecondName);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_CVC);
            this.Controls.Add(this.label_secondName);
            this.Controls.Add(this.label_number_card);
            this.Controls.Add(this.textBox_repeatPassword);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_card);
            this.Controls.Add(this.label_runner);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.panel_1_sar);
            this.Controls.Add(this.panel_2_sar);
            this.Name = "registration";
            this.Text = "registration";
            this.Load += new System.EventHandler(this.registration_Load);
            this.panel_1_sar.ResumeLayout(false);
            this.panel_1_sar.PerformLayout();
            this.panel_2_sar.ResumeLayout(false);
            this.panel_2_sar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_runner_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button return_to_start;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_CVC;
        private System.Windows.Forms.Label label_secondName;
        private System.Windows.Forms.Label label_number_card;
        private System.Windows.Forms.TextBox textBox_repeatPassword;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_card;
        private System.Windows.Forms.Label label_runner;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label time_to_start;
        private System.Windows.Forms.Panel panel_1_sar;
        private System.Windows.Forms.Panel panel_2_sar;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textBox_SecondName;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.PictureBox pictureBox_runner_photo;
        private System.Windows.Forms.TextBox textBox_name_photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_choise_photo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.Button registrat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource wsDataSet1BindingSource;
        private wsDataSet1 wsDataSet1;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private wsDataSet1TableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private wsDataSet1TableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}