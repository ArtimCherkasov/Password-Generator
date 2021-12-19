using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Генератор_паролей
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (TBLogin.Text == "")
                MessageBox.Show("Вы забыли ввести логин!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TBPass2.Text == "")
                MessageBox.Show("Вы забыли ввести пароль повторно!");
        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {          
           
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `pass`, `name`) VALUES (NULL, @login, @pass, @name)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = TBLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TBPass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TBName.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                Form1 frmMain = new Form1();
                frmMain.Show();
                this.Hide();
                MessageBox.Show("Аккаунт был создан");
                
            }
            else
                MessageBox.Show("Что-то пошло не так");
            db.closeConnection();
            
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            if (TBName.Text == "")
                MessageBox.Show("Вы забыли ввести имя!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 frmMain = new Form1();
            frmMain.Show();
            this.Hide();
        }

        private void TBPass_TextChanged(object sender, EventArgs e)
        {
            if (TBPass.Text == "")
                MessageBox.Show("Вы забыли ввести пароль!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text == "")
                MessageBox.Show("Вы забыли поставить галочку");
        }
    }
}
