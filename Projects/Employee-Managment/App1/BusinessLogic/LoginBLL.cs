using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.BusinessLogic
{
    class LoginBLL
    {
        DBContext Database;

        public LoginBLL()
        {
            this.Database = new DBContext();
        }

        /// <summary>
        /// Checks if there is any employee in database with username and password
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <returns>true or false</returns>
        public bool CheckForValidFields(string Username,string Password)
        {
            var HaveAdmin= this.Database.Admins.FirstOrDefault(x => x.Username == Username && x.Password == Password);
            if (HaveAdmin == null)
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Check if code is from the MASTERADMINCARD
        /// </summary>
        /// <param name="AdminCode"></param>
        /// <returns>true or false</returns>
        public bool CheckAdminCode(string AdminCode)
        {
            var AdminUserCode = this.Database.Admins.First(x => x.Id == 1).ScannerCardNumber;
            if (AdminCode == AdminUserCode)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Creates new Admin
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        public void CreateUser(string Username,string Password)
        {
            Admins admins = new Admins()
            {
                Username = Username,
                Password = Password,
                ScannerCardNumber = "User"
            };
            //Adds to DataBase
            this.Database.Admins.Add(admins);
            //Saves changes
            this.Database.SaveChanges();
        }

        /// <summary>
        /// Gets the users count
        /// </summary>
        /// <returns></returns>
        public int GetUsersCount()
        {
            return this.Database.Admins.Count()-1;
        }

        /// <summary>
        /// Deletes all users
        /// </summary>
        public void DeleteAllAdminUsers()
        {
            //foreach all the admins
            foreach (var Admins in this.Database.Admins.Where(x=>x.Id!=1))
            {
                //removes fromm DataBase
                this.Database.Admins.Remove(Admins);
            }
            //Save changes
            this.Database.SaveChanges();
        }
    }
}
