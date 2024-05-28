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
    public partial class AddGuestsForm : Form
    {
        DBClass dbclass = new DBClass(); //используем методы из класса DBClass

        public AddGuestsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e) //кнопка для добавления в бд данных
        {
            dbclass.ConnectionDB(); //открытие подключения с бд

            var name = NameGuestsTextBox.Text; //столбец с именем
            var phone = PhoneGuestsTextBox.Text; //столбец с номером телефона
            var mail = MailGuestsTextBox.Text; //столбец с электронноц почтой
            var info = InfoGuestsTextBox.Text; //столбец с доп. информацией

            var addQuery = $"insert into сustomers (name, phone, mail, info) values ('{name}','{phone}','{mail}','{info}')"; //SQL запрос
            var command = new MySqlCommand(addQuery, dbclass.GetConnection()); //SQL комманды для запроса
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана");

            dbclass.CleseDB(); //закрытие подключения с бд
        }

        private void button3_Click(object sender, EventArgs e) //кнопка закрытия текущей формы
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) //кнопка свёртывания окна
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
