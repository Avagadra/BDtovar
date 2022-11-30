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

namespace WindowsFormsApp1
{
    public partial class Avtorizaciy : Form
    {
        private int n;
        public Avtorizaciy()
        {
            InitializeComponent();

            string[] roly = { "Клиент", "Менеджер", "Администратор"};
            comboBox1.Items.AddRange(roly);

            Random rnd = new Random();
            n = rnd.Next(0, 3);

            if (n == 1)
            {
                pictureBox1.Image = Properties.Resources._1;
            }
            else if (n == 2)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            else
            {
                pictureBox1.Image = Properties.Resources._3;
            }
        }

        /// <summary>
        /// Кнопка авторизации.
        /// Считает количество совпадений Логина и Пароля в БД.
        /// Проверяет капчу. Осуществляет переход на форму SpisokTovarov.
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            int user_here;
            SqlConnection con = new SqlConnection(@"Data Source=DBSrv\DEMO;Initial Catalog=Demo2_KoltsovaEA_007ca2;Integrated Security=True");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM " + comboBox1.Text + " WHERE Логин LIKE " + textBox1.Text + " AND Пароль LIKE '" + textBox2.Text + "'";
            user_here = (int)cmd.ExecuteScalar();

            string ID = textBox1.Text;

            if (user_here > 0)
            {
                if (n == 1)
                {
                    if (textBox1.Text == "moiates")
                    {
                        if (comboBox1.Text == "Клиент"|| comboBox1.Text == "Менеджер")
                        {
                            SpisokTovarov form1 = new SpisokTovarov();
                            form1.Show();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Ne verno");
                    }
                }
                else if (n == 2)
                {
                    if (textBox1.Text == "plings")
                    {
                        if (comboBox1.Text == "Клиент" || comboBox1.Text == "Менеджер")
                        {
                            SpisokTovarov form1 = new SpisokTovarov();
                            form1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne verno");
                    }
                }
                else
                {
                    if (textBox1.Text == "pritio")
                    {
                        if (comboBox1.Text == "Клиент" || comboBox1.Text == "Менеджер")
                        {
                            SpisokTovarov form1 = new SpisokTovarov();
                            form1.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne verno");
                    }
                }
            }

            con.Close();
        }
    }
}
