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
    public partial class AddRoomsForm : Form
    {
        DBClass dbclass = new DBClass(); //используем методы из класса DBClass

        public AddRoomsForm()
        {
            InitializeComponent();
        }

        private void AddRoomsForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //кнопка закрытия текущей формы
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) //кнопка свёртывания окна
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dbclass.ConnectionDB(); //открытие подключения с бд

            var type = TypeRoomsTextBox.Text; //столбец с типом номера
            var сost = CostRoomsTextBox.Text; //столбец с ценой номера
            var availability = AvailabilityRoomsTextBox.Text; //столбец с информацией свободен номер или нет
            var places = PlacesRoomsTextBox.Text; //столбец с информацией сколько человек в нем может поместиться

            var addQuery = $"insert into rooms (type, сost, availability, places)" +
                $" values ('{type}','{сost}','{availability}','{places}')"; //SQL запрос
            var command = new MySqlCommand(addQuery, dbclass.GetConnection()); //SQL комманды для запроса
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана");

            dbclass.CleseDB(); //закрытие подключения с бд
        }
    }
}
