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

namespace Graduate_work
{
    public partial class AddStaffForm : Form
    {
        DBClass dbclass = new DBClass(); //используем методы из класса DBClass

        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dbclass.ConnectionDB(); //открытие подключения с бд

            var name = NameStaffTextBox.Text; //столбец с ф.и.о.
            var post = PostTextBox.Text; //столбец с должностью
            var salary = SalaryTextBox.Text; //столбец с зарплатой
            var date = Date_of_hiringTextBox.Text; //столбец с датой найма
            var mail = MailStaffTextBox.Text; //столбец с электронноц почтой
            var phone = PhoneStaffTextBox.Text; //столбец с номером телефона
            var pas = PasStaffTextBox.Text; //столбец с паролем
            var log = LogStaffTextBox.Text; //столбец с логином

            var addQuery = $"insert into staff (name, post, salary, date_of_hiring, mail, phone, password, login)" +
                $" values ('{name}','{post}','{salary}','{date}','{mail}','{phone}','{pas}','{log}')"; //SQL запрос
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
