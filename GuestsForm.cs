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

        DBClass dbclass = new DBClass(); //используем методы из класса DBClass
        int selectedRow;

        public GuestsForm()
        {
            InitializeComponent();
        }

        private void CreateColumns() //столбцы таблицы из бд в датагриде
        {
            dataGridView1.Columns.Add("id_customers", "ID");
            dataGridView1.Columns.Add("name", "Ф.И.О.");
            dataGridView1.Columns.Add("phone", "Номер телефона");
            dataGridView1.Columns.Add("mail", "Электронная почта");
            dataGridView1.Columns.Add("info", "Информация");
            dataGridView1.Columns.Add("IsNew", string.Empty); //пустая строка
        }

        private void ClearFields() 
        {
            IDGuestsTextBox.Text = "";
            NameGuestsTextBox.Text = "";
            PhoneGuestsTextBox.Text = "";
            MailGuestsTextBox.Text = "";
            InfoGuestsTextBox.Text = "";
        }

        private void ReadSingRow(DataGridView dgv, IDataRecord record) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), 
                record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Clear(); //очистка

            string queryString = $"SELECT * FROM customers"; //выбор всех строк в таблице гости

            MySqlCommand command = new MySqlCommand(queryString, dbclass.GetConnection());

            dbclass.ConnectionDB(); //подключение

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgv, reader);
            }
            reader.Close(); //закрытие
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //кнопка "Новая запись" которая открывает другую форму
        {
            AddGuestsForm addGuestsForm = new AddGuestsForm();
            addGuestsForm.Show();
        }

        private void GuestsForm_Load(object sender, EventArgs e)
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
                    var deleteQuery = $"delete FROM customers WHERE id_customers = {id}";

                    var command = new MySqlCommand(deleteQuery, dbclass.GetConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var mail = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var info = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update customers set name = '{name}', phone = '{phone}', mail = '{mail}', info = '{info}' WHERE id_customers = '{id}'";

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
            var id = IDGuestsTextBox.Text; //столбец с ID
            var name = NameGuestsTextBox.Text; //столбец с ф.и.о.
            var phone = PhoneGuestsTextBox.Text; //столбец с номером телефона
            var mail = MailGuestsTextBox.Text; //столбец с электронноц почтой
            var info = InfoGuestsTextBox.Text; //столбец с доп. информацией

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, phone, mail, info);
                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
        }

        private void EditButton_Click(object sender, EventArgs e) //кнопка "Изменить"
        {
            Change();
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //при нажатии на строку в таблице, инормация из таблицы появляется в текстбоксах
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                IDGuestsTextBox.Text = row.Cells[0].Value.ToString(); //ID
                NameGuestsTextBox.Text = row.Cells[1].Value.ToString(); //ф.и.о.
                PhoneGuestsTextBox.Text = row.Cells[2].Value.ToString(); //номер телефона
                MailGuestsTextBox.Text = row.Cells[3].Value.ToString(); //электронная почта
                InfoGuestsTextBox.Text = row.Cells[4].Value.ToString(); //дополнительная информация 
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //обновление отображения таблиц в датагриде
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void Search(DataGridView dgv) //метод поиска в датагриде с помощью текстбокса
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM customers WHERE concat (id_customers, name, phone, mail, info) like '%" + SearchTextBox.Text + "%'";
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

        private void ClearButton_Click(object sender, EventArgs e) //кнопка чистки тесктбоксов
        {
            ClearFields();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
