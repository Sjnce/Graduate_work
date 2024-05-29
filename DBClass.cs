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
        MySqlConnection conn = new MySqlConnection(@"server=localhost;port=3306;username=root;password=root;database=graduate_workdb"); //подключение к бд
        // @"server=147.45.239.24;port=3306;username=dvorn1234;password=oj=FtQGU~!J8n.;database=Dvorniy"
        public void ConnectionDB() //метод для подключение к бд
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

        public MySqlConnection GetConnection() //метод возвращает строку подключения
        {
            return conn;
        }
    }
}
