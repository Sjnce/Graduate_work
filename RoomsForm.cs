using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduate_work
{
    public partial class RoomsForm : Form
    {

        DBClass dbclass = new DBClass(); //используем методы из класса DBClass
        int selectedRow;

        public RoomsForm()
        {
            InitializeComponent();
        }

        private void CreateColumns() //столбцы таблицы из бд в датагриде
        {
            dataGridView1.Columns.Add("id_rooms", "ID");
            dataGridView1.Columns.Add("type", "Тип");
            dataGridView1.Columns.Add("сost", "Цена");
            dataGridView1.Columns.Add("availability", "Доступность");
            dataGridView1.Columns.Add("places", "На сколько человек");
            dataGridView1.Columns.Add("IsNew", string.Empty); //пустая строка
        }
        private void ClearFields()
        {
            IDRoomsTextBox.Text = "";
            TypeRoomsTextBox.Text = "";
            CostRoomsTextBox.Text = "";
            AvailabilityRoomsTextBox.Text = "";
            PlacesRoomsTextBox.Text = "";
        }
        private void ReadSingRow(DataGridView dgv, IDataRecord record) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), 
                record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Clear(); //очистка

            string queryString = $"SELECT * FROM rooms"; //выбор всех строк в таблице гости

            MySqlCommand command = new MySqlCommand(queryString, dbclass.GetConnection());

            dbclass.ConnectionDB(); //подключение

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgv, reader);
            }
            reader.Close(); //закрытие
        }

        private void Search(DataGridView dgv) //метод поиска в датагриде с помощью текстбокса
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM rooms WHERE concat (id_rooms, type, сost, availability, places) like '%" + SearchTextBox.Text + "%'";
            MySqlCommand com = new MySqlCommand(searchString, dbclass.GetConnection());
            dbclass.ConnectionDB();

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ReadSingRow(dgv, reader);
            }
            reader.Close();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) //текстбокс для поиска в датагриде
        {
            Search(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //при нажатии на строку в таблице, инормация из таблицы появляется в текстбоксах
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                IDRoomsTextBox.Text = row.Cells[0].Value.ToString(); //ID
                TypeRoomsTextBox.Text = row.Cells[1].Value.ToString(); //тип
                CostRoomsTextBox.Text = row.Cells[2].Value.ToString(); //цена
                AvailabilityRoomsTextBox.Text = row.Cells[3].Value.ToString(); //доступность
                PlacesRoomsTextBox.Text = row.Cells[4].Value.ToString(); //на сколько человек
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            AddRoomsForm addRoomsForm = new AddRoomsForm(); //кнопка "Новая запись" которая открывает другую форму
            addRoomsForm.Show();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Update() //метод сохранения таблицы
        {
            dbclass.ConnectionDB();

            for (int index = 0; index < dataGridView1.Rows.Count; index++) //цикл
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete FROM rooms WHERE id_rooms = {id}";

                    var command = new MySqlCommand(deleteQuery, dbclass.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var сost = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var availability = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var places = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update rooms set type = '{type}', сost = '{сost}', " +
                        $"availability = '{availability}', places = '{places}', WHERE id_rooms = '{id}'";

                    var command = new MySqlCommand(changeQuery, dbclass.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            dbclass.CleseDB();
        }

        private void SaveButton_Click(object sender, EventArgs e) //кнопка "Сохранить"
        {
            Update();
        }
        private void deleteRow() //метод удаления из датагрида
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void DelButton_Click(object sender, EventArgs e) //кнопка "Удалить"
        {
            deleteRow();
            ClearFields();
        }
        private void Change() //метод изменения таблицы в датагриде
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = IDRoomsTextBox.Text; //столбец с ID номера
            var type = TypeRoomsTextBox.Text; //столбец с типом номера
            var сost = CostRoomsTextBox.Text; //столбец с ценой номера
            var availability = AvailabilityRoomsTextBox.Text; //столбец с информацией о доступности номера
            var places = PlacesRoomsTextBox.Text; //столбец с информацией на сколько номер человек

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, type, сost, availability, places);
                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
        }

        private void EditButton_Click(object sender, EventArgs e) //кнопка "Изменить"
        {
            Change();
            ClearFields();
        }

        private void UpdateButton_Click(object sender, EventArgs e) //обновление отображения таблиц в датагриде
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void ClearButton_Click(object sender, EventArgs e) //кнопка чистки тесктбоксов
        {
            ClearFields();
        }
    }
}
