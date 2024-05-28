using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Graduate_work
{
    internal class DBClass 
    {
        MySqlConnection conn = new MySqlConnection(@"server=localhost;port=3306;username=root;password=root;database=graduate_workdb");

        public void ConnectionDB()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CleseDB() //метод для выхода из бд
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        } 

        public MySqlConnection getConnection() //метод возвращает строку подключения
        {
            return conn;
        }

        /*
        static string DBConnect = "server=localhost;port=3306;username=root;password=root;database=graduate_workdb"; //подключение к бд
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myconnect;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB() //метод для подключения к бд
        {
            try
            {
                myconnect = new MySqlConnection(DBConnect);
                myconnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myconnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных!");
                return false;
            }
        }
        */
    }
}
