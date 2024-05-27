using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Graduate_work
{
    internal class HashingClass
    {
        public string Hash(string input)
        {
            using (var sha256 = SHA1.Create())
            {
                byte[] passwordByte = Encoding.UTF8.GetBytes(input); //преобразование строки в байты
                byte[] hash = sha256.ComputeHash(passwordByte); //хеширование
                return Convert.ToBase64String(hash); //возвращаем
            }
        }
    }
}
