﻿using System;
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
        DBClass dbclass = new DBClass();

        static public string loginActive;
        static public string whois;

        public InForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //кнопка "вход"
        {
            if (LoginTextBox.Text != "" && PasswordTextBox.Text != "") //если текстбоксы логина и пароля пустые, то код читается дальше
            {
                AuthorizationClass.Authorization(LoginTextBox.Text, PasswordTextBox.Text);
                switch (AuthorizationClass.post)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует!", "Проверте данные и попробуйте снова."); //выдаёт при введении данных в текстбоксы которых нет в бд
                            break;
                        }
                    case "Администратор": //роль администратора
                        {
                            loginActive = LoginTextBox.Text;
                            whois = "Администратор";
                            AuthorizationClass.user = LoginTextBox.Text;
                            string name = AuthorizationClass.AuthorizationName(LoginTextBox.Text);
                            AuthorizationClass.name = name;
                            MessageBox.Show(name + ", добро пожаловать в меню администратора!"); //встречающее сообщение для роли администратора
                            this.Hide();
                            HomeForm homeForm = new HomeForm(); //переход в форму для роли администратора
                            homeForm.Show();
                            break;
                        }
                    case "Менеджер": //роль менеджера
                        {
                            loginActive = LoginTextBox.Text;
                            whois = "Менеджер";
                            AuthorizationClass.user = LoginTextBox.Text;
                            string name = AuthorizationClass.AuthorizationName(LoginTextBox.Text);
                            AuthorizationClass.name = name;
                            this.Hide();
                            MainForm mainForm = new MainForm(); //переход в форму для роли менеджера
                            mainForm.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!"); //выводится при не заполнении текстбоксов (одного и/или двух)
            }
        }

        private void button3_Click(object sender, EventArgs e) //кнопка выхода из программы
        {
            Application.Exit(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InForm_Load(object sender, EventArgs e)
        {

        }
    }
}
