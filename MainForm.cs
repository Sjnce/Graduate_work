﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Graduate_work
{
    public partial class MainForm : Form
    {
        DBClass dbclass = new DBClass(); //используем методы из класса DBClass

        public MainForm()
        {
            InitializeComponent();
            panel2.Controls.Clear(); //очистить все элементы управления из Panel2
            HomeForm homeForm = new HomeForm(); //создание экземпляра второй формы
            homeForm.TopLevel = false; //установка TopLevel в false, чтобы форма не была самостоятельным окном
            homeForm.AutoScroll = true; //включение автопрокрутки, если это необходимо
            panel2.Controls.Add(homeForm); //добавление второй формы в panel1
            homeForm.Show(); //отображение второй формы
        }

        private void button3_Click(object sender, EventArgs e) //кнопка выхода из программы
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e) //кнопка "Гости"
        {
            panel2.Controls.Clear(); //очистить все элементы управления из Panel2
            GuestsForm guestsform = new GuestsForm(); //создание экземпляра второй формы
            guestsform.TopLevel = false; //установка TopLevel в false, чтобы форма не была самостоятельным окном
            guestsform.AutoScroll = true; //включение автопрокрутки, если это необходимо
            panel2.Controls.Add(guestsform); //добавление второй формы в panel1
            guestsform.Show(); //отображение второй формы
        }

        private void panel2_Paint(object sender, PaintEventArgs e) //панель где выводятся другие формы
        {

        }

        private void checkRole(string role) //метод скрытия кнопки для роли
        {
            switch (role)
            {
                case "admin":
                    //потом можно добавить кнопки для скрытия
                    //потом можно добавить кнопки для скрытия
                    UserPanel.Dispose(); //скрывает панель для роли Алминистратора (admin)
                    break;
                case "user":
                    //потом можно добавить кнопки для скрытия
                    AdminPanel.Dispose(); //скрывает панель для роли менеджер (user)
                    button1.Dispose(); //скрывает кнопку для роли менеджер (user)
                    break;
                default:
                    //потом можно добавить кнопки для скрытия
                    AdminPanel.Dispose(); //скрывает панель для роли менеджер (user) 
                    button1.Dispose(); //скрывает кнопку для некорректной роли 
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkRole(AuthorizationClass.post); //используем методы из класса AuthorizationClass и метод checkRole для скрытия кнопок по ролям
        }

        private void button7_Click(object sender, EventArgs e) //кнопка "Выход"
        {
            this.Hide();
            InForm inForm = new InForm(); //переход в форму авторизации
            inForm.Show();
        }

        private void button4_Click(object sender, EventArgs e) //кнопка свёртывания окна
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e) //кнопка "Персонал"
        {
            panel2.Controls.Clear(); //очистить все элементы управления из Panel2
            StaffForm staffForm = new StaffForm(); //создание экземпляра второй формы
            staffForm.TopLevel = false; //установка TopLevel в false, чтобы форма не была самостоятельным окном
            staffForm.AutoScroll = true; //включение автопрокрутки, если это необходимо
            panel2.Controls.Add(staffForm); //добавление второй формы в panel1
            staffForm.Show(); //отображение второй формы
        }

        private void button2_Click(object sender, EventArgs e) //кнопка "Главная"
        {
            panel2.Controls.Clear(); //очистить все элементы управления из Panel2
            HomeForm homeForm = new HomeForm(); //создание экземпляра второй формы
            homeForm.TopLevel = false; //установка TopLevel в false, чтобы форма не была самостоятельным окном
            homeForm.AutoScroll = true; //включение автопрокрутки, если это необходимо
            panel2.Controls.Add(homeForm); //добавление второй формы в panel1
            homeForm.Show(); //отображение второй формы
        }

        private void button6_Click(object sender, EventArgs e) //кнопка "комнаты"
        {
            panel2.Controls.Clear(); //очистить все элементы управления из Panel2
            RoomsForm roomsForm = new RoomsForm(); //создание экземпляра второй формы
            roomsForm.TopLevel = false; //установка TopLevel в false, чтобы форма не была самостоятельным окном
            roomsForm.AutoScroll = true; //включение автопрокрутки, если это необходимо
            panel2.Controls.Add(roomsForm); //добавление второй формы в panel1
            roomsForm.Show(); //отображение второй формы
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
