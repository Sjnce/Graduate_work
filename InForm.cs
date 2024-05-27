using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Graduate_work
{
    public partial class InForm : Form
    {
        static public string loginActive;
        static public string whois;
        public InForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //кнопка "вход"
        {
            if (LoginTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                AuthorizationClass.Authorization(LoginTextBox.Text, PasswordTextBox.Text);
                switch (AuthorizationClass.post)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует!", "Проверте данные и попробуйте снова.");
                            break;
                        }
                    case "Администратор":
                        {
                            loginActive = LoginTextBox.Text;
                            whois = "Администратор";
                            AuthorizationClass.user = LoginTextBox.Text;
                            string name = AuthorizationClass.AuthorizationName(LoginTextBox.Text);
                            AuthorizationClass.name = name;
                            MessageBox.Show(name + ", добро пожаловать в меню администратора!");
                            this.Hide();
                            HomeForm homeForm = new HomeForm();
                            homeForm.Show();
                            break;
                        }
                    case "Менеджер":
                        {
                            loginActive = LoginTextBox.Text;
                            whois = "Менеджер";
                            AuthorizationClass.user = LoginTextBox.Text;
                            string name = AuthorizationClass.AuthorizationName(LoginTextBox.Text);
                            AuthorizationClass.name = name;
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //кнопка выхода из программы
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
