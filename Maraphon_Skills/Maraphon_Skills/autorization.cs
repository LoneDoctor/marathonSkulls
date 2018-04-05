using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Maraphon_Skills
{
    public partial class autorization : Form
    {
        SqlConnection database;
        /// <summary>
        /// подключение базы данных
        /// </summary>
        public autorization()
        {

            InitializeComponent();

            database = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER01; Initial Catalog = ws; Integrated Security = True");
            database.Open();
        }
        /// <summary>
        /// Обратный отсчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2018, 10, 30);
            time_to_start.Text = "";
            DateTime date_now = new DateTime();
            date_now = DateTime.Now;
            time_to_start.Text = (date - date_now).Days + " дней " + (date - date_now).Hours + " часов " + (date - date_now).Minutes + " минут " + " до старта марафона!";
        }
        /// <summary>
        /// Возвращение на стартовую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_to_start_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_m sm = new Start_m();
            sm.Show();
        }
        /// <summary>
        /// Вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Click(object sender, EventArgs e)
        {

            if (textBox_password.Text != "" && textBox_email.Text != "")
            {

                SqlCommand command = new SqlCommand("SELECT * FROM [user]", database);
            SqlDataReader sqlread = null;
                 try
                    {
                        sqlread = command.ExecuteReader(); //Компиляция
                        while (sqlread.Read()) // Чтение данных по запросу
                        {
                            if ((sqlread["Email"].ToString() == textBox_email.Text) && (sqlread["password"].ToString() == textBox_password.Text) && sqlread["RoleId"].ToString() == "R")
                            {

                                runner_menu rm = new runner_menu();
                                this.Hide();
                                rm.Show();
                                break;
                                
                            }
                            else 
                            if ((sqlread["Email"].ToString() == textBox_email.Text) && (sqlread["password"].ToString() == textBox_password.Text) && sqlread["RoleId"].ToString() == "A")
                            {
                                administrator_menu am = new administrator_menu();
                                this.Hide();
                                am.Show();
                                break;
                            }

                            if ((sqlread["Email"].ToString() == textBox_email.Text) && (sqlread["password"].ToString() == textBox_password.Text) && sqlread["RoleId"].ToString() == "C")
                            {
                                koordinator_menu km = new koordinator_menu();
                                this.Hide();
                                km.Show();
                                break;
                            }
                        }
                    }
                    catch {
                    MessageBox.Show("Логин или пароль введены неверно!");
                }
                    finally
                    {
                        if (sqlread != null)
                            sqlread.Close();
                    }
                }
            else
                MessageBox.Show("Не введен логин или пароль");
        }

        private void autorization_Load(object sender, EventArgs e)
        {
            panel_1_sar.BackColor = Color.FromArgb(81, 81, 81);
            panel_2_sar.BackColor = Color.FromArgb(81, 81, 81);
        }
    }
        }



   
    
        
    

