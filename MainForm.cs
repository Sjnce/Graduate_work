using System;
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
        DBClass dbclass = new DBClass();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GuestsForm guestsform = new GuestsForm(); // Создание экземпляра второй формы
            guestsform.TopLevel = false; // Установка TopLevel в false, чтобы форма не была самостоятельным окном
            guestsform.AutoScroll = true; // Включение автопрокрутки, если это необходимо
            panel2.Controls.Add(guestsform); // Добавление второй формы в panel1
            guestsform.Show(); // Отображение второй формы
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            InForm inForm = new InForm(); //переход в форму для роли менеджера
            inForm.Show();
        }

        private void button4_Click(object sender, EventArgs e) //кнопка свёртывания окна
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
