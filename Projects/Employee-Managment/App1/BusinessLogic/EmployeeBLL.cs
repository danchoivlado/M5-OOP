using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.BusinessLogic
{
    class EmployeeBLL
    {
        employeemanagementContext Database;

        public EmployeeBLL()
        {
            this.Database = new employeemanagementContext();
        }


        public void CreateEmployee(string FirstName, string SecondName, string LastName, string EGN, string Duty,
            string Town, string TelephoneNumber, string ScannerCardNumber)
        {
            var CurTown = this.Database.Towns.FirstOrDefault(x => x.Name == Town);
            var CurDuty = this.Database.Duties.FirstOrDefault(x => x.Duty == Duty);

            if (CurTown == null)
            {
                CurTown = new Towns()
                {
                    Name = Town
                };
                this.Database.Towns.Add(CurTown);
            }

            if (CurDuty==null)
            {
                CurDuty = new Duties()
                {
                    Duty = Duty
                };
                this.Database.Duties.Add(CurDuty);
            }

            var NewEmployee = new Employees()
            {
                FirstName = FirstName,
                SecondName = SecondName,
                LastName = LastName,
                Egn = EGN,
                DutyId = CurDuty.Id,
                TownId = CurTown.Id,
                TelephoneNumber = TelephoneNumber,
                ScannerCardNumber = ScannerCardNumber

            };

            this.Database.Employees.Add(NewEmployee);
            this.Database.SaveChanges();



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
            return EmployeeList;
        }

        public void EditEmployee(EmployeeInfo employee)
        {
            var CurEmployee = Database.Employees.First(x => x.Egn == employee.EGN);
            this.Database.Employees.Remove(CurEmployee);
            this.Database.SaveChanges();
            

            CreateEmployee(employee.FirstName, employee.SecondName, employee.LastName, employee.EGN,
                employee.Duty, employee.Town, employee.TelephoneNumber, employee.ScannerCardNumber);
        }

        public void DeleteEmployee(EmployeeInfo employee)
        {
            var CurEmployee = Database.Employees.First(x => x.Egn == employee.EGN);
            this.Database.Employees.Remove(CurEmployee);
            this.Database.SaveChanges();
        }
    }
}
