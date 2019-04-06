using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.Database
{
    class RegisterLoginInfoDB
    {
        private static string ConectionString= @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";

        string Employee;
        //keeps the Name of the logined Employee

        public RegisterLoginInfoDB()
        {

        }

        public string GetPasswordIfExists(string name)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Password FROM employees WHERE First_Name = \"{name}\"; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                try
                {
                    command.ExecuteScalar().ToString();
                    // Asks if there is Employee with this name 
                    this.Employee = name;
                }
                catch
                {
                    return "-1";
                    //there is no Employee with this name
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                        //read the password of the Employee
                    }

                }
            }
            return "-1";
        }

        public int GetTownsId(string TownName)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT ID FROM towns WHERE Name = \"{TownName}\";";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                try
                {
                    command.ExecuteScalar().ToString();
                    // Asks if there is Town with this name 
                }
                catch
                {
                    //there is no Town with this name
                    sqlText = $"INSERT INTO towns(name) VALUE(\"{TownName}\")";
                    command = new MySqlCommand(sqlText, con);
                    command.ExecuteNonQuery();

                    sqlText = $"SELECT ID FROM towns WHERE Name = \"{TownName}\";";
                    command = new MySqlCommand(sqlText, con);
                    command.ExecuteNonQuery();
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());
                        //return the id from towns
                    }

                }
                return -1;
            }
        }

        public void Register(string FirstName, string LastName, string Password, int TownId)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open(); //open the connection
                string sqlText = $"INSERT INTO employees(First_Name, Last_Name, Password, Duty_id, Town_Id) VALUE(\"{FirstName}\",\"{LastName}\",\"{Password}\",3,{TownId})";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                command.ExecuteNonQuery().ToString();
                //send the querry
            }
        }

        public void SaveInfo(string StoreName, string StoreAddress)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open(); //open the connection
                string sqlText = $"	UPDATE store_info SET name=\"{StoreName}\", address=\"{StoreAddress}\"";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                command.ExecuteNonQuery().ToString();
                //send the querry
            }
        }

        public string GetNameAddressIfExist()
        {
            string NameValue = string.Empty;
            string AddressValue = string.Empty;
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open(); //Opens the connection
                string sqlText = $"SELECT name, address FROM store_info; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NameValue = $"{reader[0]}";
                        AddressValue = $"{reader[1]}";
                        //reads the NameValue and AddressValue from store_info
                    }

                    return $"{NameValue.ToString().Trim()};{AddressValue.ToString().Trim()}";
                }
            }
        }
    }
}
