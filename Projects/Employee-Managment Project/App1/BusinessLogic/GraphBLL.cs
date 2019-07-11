using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;

namespace App1.BusinessLogic
{
    class GraphBLL
    {
        DBContext Database;
        public GraphBLL()
        {
            this.Database = new DBContext();
        }

        /// <summary>
        /// Gets The Last Code from Database and Removes it
        /// </summary>
        /// <returns>Code of Card</returns>
        public string GetLast()
        {
            var LastScanedEmployee = this.Database.Lastscaned.LastOrDefault();
            if (LastScanedEmployee == null)
            {
                return "";
            }
            this.Database.Lastscaned.Remove(LastScanedEmployee);
            this.Database.SaveChanges();
            return LastScanedEmployee.ScannerCardNumber;
        }

        /// <summary>
        /// Gets All The Employees
        /// </summary>
        /// <returns>List<EmployeeInfo></returns>
        public List<EmployeeInfo> GetAllEmployeeInfo()
        {
            var EmployeeList = new List<EmployeeInfo>();

            foreach (var emp in this.Database.Employees)
            {
                var CurTown = this.Database.Towns.First(x => x.Id == emp.TownId);
                var CurDuty = this.Database.Duties.First(x => x.Id == emp.DutyId);

                EmployeeInfo CurEmployee = new EmployeeInfo();
                CurEmployee.FirstName = emp.FirstName;
                CurEmployee.SecondName = emp.SecondName;
                CurEmployee.LastName = emp.LastName;
                CurEmployee.EGN = emp.Egn;
                CurEmployee.Town = CurTown.Name;
                CurEmployee.Duty = CurDuty.Duty;
                CurEmployee.TelephoneNumber = emp.TelephoneNumber;
                CurEmployee.ScannerCardNumber = emp.ScannerCardNumber;

                EmployeeList.Add(CurEmployee);
            }
            return EmployeeList.OrderBy(x => x.FirstName).ToList();
        }

        /// <summary>
        /// Gets ALl the Employees Came to Work Today
        /// And Calculate How Many Hours they Worked 
        /// </summary>
        /// <returns>List<EmployeeGraphInfo></returns>
        public List<EmployeeGraphInfo> GetEmployeeGraph()
        {
            var EmployeeList = new List<EmployeeGraphInfo>();

            foreach (var emp in Database.Employeegraph.Where(x => x.CurrentDate == $"{DateTime.Now.Day}:{DateTime.Now.Month}"))
            {
                var CurEmployee = this.Database.Employees.First(x => x.Id == emp.EmployeeId);
                string CurDuty = this.Database.Duties.First(x => x.Id == CurEmployee.DutyId).Duty;

                EmployeeGraphInfo CurGraph = new EmployeeGraphInfo();
                CurGraph.FirstName = CurEmployee.FirstName;
                CurGraph.LastName = CurEmployee.LastName;
                CurGraph.Duty = CurDuty;
                CurGraph.PhoneNumber = CurEmployee.TelephoneNumber;
                CurGraph.CameWork = emp.CameWork;
                CurGraph.LeavedWork = emp.LeaveWork;
                //If Employee is NOT the Building
                if (emp.LeaveWork != "Didnt Leave")
                {
                    //Calculates the Hours Worked
                    TimeSpan duration = DateTime.Parse(emp.LeaveWork).Subtract(DateTime.Parse(emp.CameWork));
                    CurGraph.HoursWorked = duration.ToString().Substring(0, 5);
                }
                else
                    CurGraph.HoursWorked = "Didnt Leave";



                EmployeeList.Add(CurGraph);
            }
            return EmployeeList;
        }

        /// <summary>
        /// Gets All Employees Came this Monght  
        /// And Calculates how many hours they worked this Monght
        /// </summary>
        /// <returns>List<EmployeeGraphInfo></returns>
        public List<EmployeeGraphInfo> GetEmployeeGraphMounght()
        {
            var EmployeeList = new List<EmployeeGraphInfo>();

            foreach (var emp in Database.Employeegraphmounght)
            {
                //Checks if the Employee Monght is the SAME as this Monght
                if (emp.CurrentDate.Split(new string[] { ":" }, StringSplitOptions.None).Last() == $"{DateTime.Now.Month}")
                {
                    var CurEmployee = this.Database.Employees.First(x => x.Id == emp.EmployeeId);
                    string Duty = this.Database.Duties.First(x => x.Id == CurEmployee.DutyId).Duty;

                    //Create EmployeeGraphInfo object
                    EmployeeGraphInfo CurGraph = new EmployeeGraphInfo();
                    CurGraph.FirstName = CurEmployee.FirstName;
                    CurGraph.LastName = CurEmployee.LastName;
                    CurGraph.Duty = Duty;
                    CurGraph.PhoneNumber = CurEmployee.TelephoneNumber;
                    CurGraph.CameWork = "Month";
                    CurGraph.LeavedWork = "Timeline";

                    //Gets from Database Employee
                    var AlreadyHaveEmp = EmployeeList.FirstOrDefault(x => x.PhoneNumber == CurEmployee.TelephoneNumber);
                    if (AlreadyHaveEmp != null)
                    {
                        EmployeeList.Remove(AlreadyHaveEmp);

                        double hours = double.Parse(emp.HoursWorked.Split(new string[] { ":" }, StringSplitOptions.None).First());
                        double minutes = double.Parse(emp.HoursWorked.Split(new string[] { ":" }, StringSplitOptions.None).Last());


                        var FirstHour =double.Parse(AlreadyHaveEmp.HoursWorked.Split(new string[] { ":" }, StringSplitOptions.None).First())+hours;
                        var FirstMinute = (double.Parse(AlreadyHaveEmp.HoursWorked.Split(new string[] { ":" }, StringSplitOptions.None).Last()) + minutes)/60;

                        CurGraph.HoursWorked = $"{Math.Floor(FirstHour+FirstMinute)}";
                    }
                    else
                    {
                        CurGraph.HoursWorked = emp.HoursWorked;
                    }


                    EmployeeList.Add(CurGraph);
                }
                else
                {
                    //Removes Outdated Employees :(
                    this.Database.Employeegraphmounght.Remove(emp);
                }
            }
            return EmployeeList;
        }
        
    }

}
