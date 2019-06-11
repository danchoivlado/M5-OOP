
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
        DBContext Database;

        public EmployeeBLL()
        {
            this.Database = new DBContext();
        }


        public Employees CreateEmployee(string FirstName, string SecondName, string LastName, string EGN, string Duty,
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
            return NewEmployee;
        }

       

       

        public void EditEmployee(EmployeeInfo employee)
        {
            var CurEmployee = Database.Employees.First(x => x.Egn == employee.EGN);
            Employeegraph CurEmplGraph = Database.Employeegraph.First(x => x.EmployeeId == CurEmployee.Id);
            this.Database.Employeegraph.Remove(CurEmplGraph);
            this.Database.Employees.Remove(CurEmployee);
            this.Database.SaveChanges();
            

             var NewEmp = CreateEmployee(employee.FirstName, employee.SecondName, employee.LastName, employee.EGN,
                employee.Duty, employee.Town, employee.TelephoneNumber, employee.ScannerCardNumber);
            CurEmplGraph.EmployeeId = NewEmp.Id;
            this.Database.Employeegraph.Add(CurEmplGraph);
            this.Database.SaveChanges();
        }

        public void DeleteEmployee(EmployeeInfo employee)
        {
            var CurEmployee = Database.Employees.First(x => x.Egn == employee.EGN);
            Employeegraph CurEmplGraph = Database.Employeegraph.First(x => x.EmployeeId == CurEmployee.Id);
            this.Database.Employeegraph.Remove(CurEmplGraph);
            this.Database.Employees.Remove(CurEmployee);
            this.Database.SaveChanges();
        }
    }
}
