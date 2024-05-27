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
            try
            {
                DBClass.msCommand.CommandText = @"SELECT * FROM staff WHERE login = '" + log + "' and password = '" + pass + "'"; //ВЫДАЁТ ОШИБКУ
                Object result = DBClass.msCommand.ExecuteScalar();
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
            catch
            {
                post = user = null;
                MessageBox.Show("Ошибка при авторизации!");
            }
        }
        static public string AuthorizationName(string login)
        {
            try
            {
                DBClass.msCommand.CommandText = @"SELECT name FROM staff WHERE login = '" + login + "'";
                Object result = DBClass.msCommand.ExecuteScalar();
                name = result.ToString();
                return name;
            }
            catch
            {
                return null;
            }
        }
    }
}
