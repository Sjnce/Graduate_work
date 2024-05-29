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
    public partial class StaffForm : Form
    {

        DBClass dbclass = new DBClass(); //используем методы из класса DBClass
        int selectedRow;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void CreateColumns() //столбцы таблицы из бд в датагриде
        {
            dataGridView1.Columns.Add("id_staff", "ID");
            dataGridView1.Columns.Add("name", "Ф.И.О.");
            dataGridView1.Columns.Add("post", "Должность");
            dataGridView1.Columns.Add("salary", "Зарплата");
            dataGridView1.Columns.Add("date_of_hiring", "Дата найма");
            dataGridView1.Columns.Add("mail", "Электронная почта");
            dataGridView1.Columns.Add("phone", "Номер телефона");
            dataGridView1.Columns.Add("password", "Пароль");
            dataGridView1.Columns.Add("login", "Логин");
            dataGridView1.Columns.Add("IsNew", string.Empty); //пустая строка
        }

        private void ClearFields()
        {
            IDStaffTextBox.Text = "";
            NameStaffTextBox.Text = "";
            PostTextBox.Text = "";
            SalaryTextBox.Text = "";
            Date_of_hiringTextBox.Text = "";
            MailStaffTextBox.Text = "";
            PhoneStaffTextBox.Text = "";
            PasStaffTextBox.Text = "";
            LogStaffTextBox.Text = "";
        }
        private void ReadSingRow(DataGridView dgv, IDataRecord record) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), 
                record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv) //столбцы таблицы из бд в датагриде
        {
            dgv.Rows.Clear(); //очистка

            string queryString = $"SELECT * FROM staff"; //выбор всех строк в таблице гости

            MySqlCommand command = new MySqlCommand(queryString, dbclass.GetConnection());

            dbclass.ConnectionDB(); //подключение

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgv, reader);
            }
            reader.Close(); //закрытие
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //при нажатии на строку в таблице, инормация из таблицы появляется в текстбоксах
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                IDStaffTextBox.Text = row.Cells[0].Value.ToString(); //ID
                NameStaffTextBox.Text = row.Cells[1].Value.ToString(); //ф.и.о.
                PostTextBox.Text = row.Cells[2].Value.ToString(); //должность
                SalaryTextBox.Text = row.Cells[3].Value.ToString(); //зарплата
                Date_of_hiringTextBox.Text = row.Cells[4].Value.ToString(); //дата найма
                MailStaffTextBox.Text = row.Cells[5].Value.ToString(); //электронная почта
                PhoneStaffTextBox.Text = row.Cells[6].Value.ToString(); //номер телефона
                PasStaffTextBox.Text = row.Cells[7].Value.ToString(); //пароль
                LogStaffTextBox.Text = row.Cells[8].Value.ToString(); //логин
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm(); //кнопка "Новая запись" которая открывает другую форму
            addStaffForm.Show();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void Update() //метод сохранения таблицы
        {
            dbclass.ConnectionDB();

            for (int index = 0; index < dataGridView1.Rows.Count; index++) //цикл
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete FROM staff WHERE id_staff = {id}";

                    var command = new MySqlCommand(deleteQuery, dbclass.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var post = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var salary = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var mail = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var pas = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var log = dataGridView1.Rows[index].Cells[8].Value.ToString();

                    var changeQuery = $"update staff set name = '{name}', post = '{post}', salary = '{salary}', date_of_hiring = '{date}' " +
                        $"mail = '{mail}', phone = '{phone}', password = '{pas}', login = '{log}', WHERE id_staff = '{id}'";

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
                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
        }

        private void DelButton_Click(object sender, EventArgs e) //кнопка "Удалить"
        {
            deleteRow();
            ClearFields();
        }
        private void Change() //метод изменения таблицы в датагриде
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = IDStaffTextBox.Text; //столбец с ID
            var name = NameStaffTextBox.Text; //столбец с ф.и.о.
            var post = PostTextBox.Text; //столбец с должностью
            var salary = SalaryTextBox.Text; //столбец с зарплатой
            var date = Date_of_hiringTextBox.Text; //столбец с датой найма
            var mail = MailStaffTextBox.Text; //столбец с электронноц почтой
            var phone = PhoneStaffTextBox.Text; //столбец с номером телефона
            var pas = PasStaffTextBox.Text; //столбец с паролем
            var log = LogStaffTextBox.Text; //столбец с логином

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, post, salary, date, mail, phone, pas, log);
                dataGridView1.Rows[selectedRowIndex].Cells[9].Value = RowState.Modified;
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
        private void Search(DataGridView dgv) //метод поиска в датагриде с помощью текстбокса
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM staff WHERE concat (id_staff, name, post, salary, date_of_hiring, " +
                $"mail, phone, password, login) like '%" + SearchTextBox.Text + "%'";
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
    }
}
