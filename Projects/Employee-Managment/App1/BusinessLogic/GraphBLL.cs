using System;
using System.Collections.Generic;
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

        public string GetLast()
        {
            var LastScaned = this.Database.Lastscaned.LastOrDefault();
            if (LastScaned == null)
            {
                return "";
            }
            this.Database.Lastscaned.Remove(LastScaned);
            this.Database.SaveChanges();
            return LastScaned.ScannerCardNumber;
        }

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

        public List<EmployeeGraphInfo> GetEmployeeGraph()
        {
            var EmployeeList = new List<EmployeeGraphInfo>();

            foreach (var emp in Database.Employeegraph.Where(x=>x.CurrentDate== $"{DateTime.Now.Day}:{DateTime.Now.Month}"))
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
                if (emp.LeaveWork == "Didnt Leave")
                {
                    TimeSpan duration = DateTime.Parse(DateTime.Now.TimeOfDay.ToString()).Subtract(DateTime.Parse(emp.CameWork));
                    CurGraph.HoursWorked = duration.ToString().Substring(0, 5);
                }
                else
                {
                    TimeSpan duration = DateTime.Parse(emp.LeaveWork).Subtract(DateTime.Parse(emp.CameWork));
                    CurGraph.HoursWorked = duration.ToString().Substring(0,5);
                }

                EmployeeList.Add(CurGraph);
            }
            return EmployeeList;
        }
    }

}
