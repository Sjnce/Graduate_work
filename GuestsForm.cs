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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class GuestsForm : Form
    {
        DBClass dbclass = new DBClass();

        int selectedRow;

        public GuestsForm()
        {
            InitializeComponent();
        }

        private void CreateColumns() //столбцы таблицы из бд в датагриде
        {
            dataGridView1.Columns.Add("id_сustomers", "ID");
            dataGridView1.Columns.Add("name", "Ф.И.О.");
            dataGridView1.Columns.Add("phone", "Номер телефона");
            dataGridView1.Columns.Add("mail", "Электронная почта");
            dataGridView1.Columns.Add("info", "Информация");
            dataGridView1.Columns.Add("IsNew", string.Empty); //пустая строка
        }

        private void ReadSingRow(DataGridView dgv, IDataRecord record) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Clear();

            string queryString = $"SELECT * FROM сustomers"; //выбор всех строк в таблице гости

            MySqlCommand command = new MySqlCommand(queryString, dbclass.getConnection());

            dbclass.ConnectionDB(); //подключение

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgv, reader);
            }
            reader.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GuestsForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void DelButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
