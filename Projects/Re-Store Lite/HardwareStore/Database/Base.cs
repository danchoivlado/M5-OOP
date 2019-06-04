using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.Database
{
    class Base
    {
        public string GetPasswordIfExists(string name)
        {
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            using (MySqlConnection con = new MySqlConnection(str))
            {
                con.Open();
                string sqlText = $"SELECT Password FROM employees WHERE First_Name = \"{name}\"; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                try
                {
                   command.ExecuteScalar().ToString();
                }
                catch
                {
                    return String.Empty;
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                    }
                    
                }
            }
            return String.Empty;
        }
    }
}
