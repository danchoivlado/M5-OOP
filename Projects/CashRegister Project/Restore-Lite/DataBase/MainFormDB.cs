using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.Database
{
    class MainFormDB
    {
        private static string ConectionString = @"Server=localhost;database=OfficeStore;port=3306;user=root;password=3073";

        public MainFormDB()
        {
             
        }
        
        public int GetInvoiceId()
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT COUNT(*) FROM invoice; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());
                        //read the Count of the Invoices
                    }
                    return -1;
                }
            }
        }

        public void UpdateQuantity(int ItmeQuantity,string ItemName)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"UPDATE items SET Quantity=Quantity-{ItmeQuantity} WHERE Product_Name =\"{ItemName}\";";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteNonQuery();
            }
        }

        public void InserIntoInvoiceItems(int ItemBarcode, int Quantity,double Single_Price, double Total,int Invoice_Id)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"INSERT INTO invoice_items (Item_Id,Quantity,Single_Price,Total,Invoice_Id)  VALUE({ItemBarcode}, {Quantity},{Single_Price}, {Total}, {Invoice_Id});";
                MySqlCommand command = new MySqlCommand(sqlText, con);
               // Console.WriteLine(Single_Price);
                command.ExecuteNonQuery();
            }
        }

        public double GetItemSinglePrice(int ItemBarcode)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Single_Price  FROM items WHERE Id ={ItemBarcode};";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return double.Parse(reader[0].ToString());
                        //read the Count of the Invoices
                    }
                    return -1;
                }
            }
        }

        public string GetItemName(int ItemBarcode)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Product_Name  FROM items WHERE Id ={ItemBarcode};";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                        //read the Count of the Invoices
                    }
                    return String.Empty;
                }
            }
        }

        public int GetEmployeeId(string EmployeeName)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Id FROM employees WHERE First_Name = \"{EmployeeName}\"; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());
                        //return the Id of Employee
                    }
                    return -1;
                }
            }
        }

        public double GetTotal(int InvoiceId)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT SUM(Total) FROM invoice_items WHERE Invoice_Id = {InvoiceId}; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return double.Parse(reader[0].ToString());
                        //return the Id of Employee
                    }
                    return -1;
                }
            }
        }

        public void InsertInvoice(int InvoiceNumber,string Date,string Time,int EmployeeId,double Total)
        {

            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"INSERT INTO invoice(Order_No, Date, Time, Employee_Id, Total, Payment_Method_Id,Store_Info_Id) VALUE({InvoiceNumber},\"{Date}\",\"{Time}\",{ EmployeeId},{Total},1,1); ";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                command.ExecuteNonQuery();
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

        public string GetDate(int OrderNumber)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT date FROM invoice WHERE Id =  {OrderNumber};";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                        //read the Count of the Invoices
                    }
                    return String.Empty;
                }
            }
        }

        public string GetTime(int OrderNumber)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT time FROM invoice WHERE Id =  {OrderNumber};";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                        //read the Count of the Invoices
                    }
                    return String.Empty;
                }
            }
        }

        public int GetCountOfItems(int OrderNumber)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT COUNT(i.Product_Name) FROM items AS i INNER JOIN invoice_items AS it ON it.Item_Id = i.id WHERE Invoice_Id = {OrderNumber}; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());
                        //read the Count of the Invoices
                    }
                    return -1;
                }
            }
        }

        public List<string[]> InvoiceItems(int CountOfInvoiceItems)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                List<string[]> InvoiceItems = new List<string[]>();
                string[] ItemInfo = new string[4];
                con.Open();
                string sqlText = $"SELECT i.Product_Name, it.Quantity, i.Single_Price, it.Total FROM items AS i INNER JOIN invoice_items AS it ON it.Item_Id = i.id WHERE Invoice_Id = {CountOfInvoiceItems}; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemInfo[0] = reader[0].ToString();
                        ItemInfo[1] = reader[1].ToString();
                        ItemInfo[2] = reader[2].ToString();
                        ItemInfo[3] = reader[3].ToString();
                        InvoiceItems.Add(ItemInfo);
                        ItemInfo = new string[4];
                        //read the Count of the Invoices
                    }
                    return InvoiceItems;
                }
            }
        }
    }
}
