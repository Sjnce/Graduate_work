using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Graduate_work
{
    internal class AuthorizationClass
    {
        static public string post, name, user;

        static public void Authorization(string log, string pass)
        {
            DBClass dbclass = new DBClass(); //используем методы из класса DBClass
            using (MySqlConnection connection = dbclass.GetConnection()) //используем метод GetConnection() из класса DBClass
            {
                string query = "SELECT login, password FROM staff WHERE login = @login and password = @password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", log);
                command.Parameters.AddWithValue("@password", pass);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        post = result.ToString();
                        user = log;
                    }
                    else
                    {
                        post = null;
                        name = null;
                    }
                }
                catch (Exception ex)
                {
                    post = user = null;
                    MessageBox.Show("Ошибка при авторизации: " + ex.Message);
                }
            }
        }

        static public string AuthorizationName(string login)
        {
            DBClass dbclass = new DBClass(); //используем методы из класса DBClass
            using (MySqlConnection connection = dbclass.GetConnection()) //используем метод GetConnection() из класса DBClass
            {
                string query = "SELECT name FROM staff WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    name = result.ToString();
                    return name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при получении имени: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
