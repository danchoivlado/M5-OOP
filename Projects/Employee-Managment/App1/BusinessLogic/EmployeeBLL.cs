
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

        /// <summary>
        /// Create Employee and ADDS it to DATABASE
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="SecondName"></param>
        /// <param name="LastName"></param>
        /// <param name="EGN"></param>
        /// <param name="Duty"></param>
        /// <param name="Town"></param>
        /// <param name="TelephoneNumber"></param>
        /// <param name="ScannerCardNumber"></param>
        /// <returns></returns>
        public Employees CreateEmployee(string FirstName, string SecondName, string LastName, string EGN, string Duty,
            string Town, string TelephoneNumber, string ScannerCardNumber)
        {
            //Check if there is already town & Duty in the database
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

            if (CurDuty == null)
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
            //Gets the selected Employee
            var SelectedEmployee = Database.Employees.First(x => x.Egn == employee.EGN);
            //Get the employee from Employeegraph
            Employeegraph EmployeeFromToday = Database.Employeegraph.FirstOrDefault(x => x.EmployeeId == SelectedEmployee.Id);
            //Used to Store all the Employees camo from this monght in Employeegraphmounght
            List<Employeegraphmounght> AllEmployeesFromEmployeeGraph = new List<Employeegraphmounght>();

            if (EmployeeFromToday != null)
                this.Database.Employeegraph.Remove(EmployeeFromToday);

            //Check if there is any employee in the database
            if (this.Database.Employeegraphmounght.Count()!=0)
            {
                foreach (var emp in this.Database.Employeegraphmounght.Where(x=>x.EmployeeId==SelectedEmployee.Id))
                {
                    //Removes and from database and add it to the list
                    AllEmployeesFromEmployeeGraph.Add(emp);
                    this.Database.Employeegraphmounght.Remove(emp);
                }
            }

            this.Database.Employees.Remove(SelectedEmployee);
            this.Database.SaveChanges();


            var NewEmp = CreateEmployee(employee.FirstName, employee.SecondName, employee.LastName, employee.EGN,
               employee.Duty, employee.Town, employee.TelephoneNumber, employee.ScannerCardNumber);

            //Changes All the Employee from Employeegraph TABLE
            if (EmployeeFromToday != null)
            {
                EmployeeFromToday.EmployeeId = NewEmp.Id;
                this.Database.Employeegraph.Add(EmployeeFromToday);
                this.Database.SaveChanges();
            }
            //Changes All the Employee from Employeegraphmounght TABLE 
            if (this.Database.Employeegraphmounght.Count() != 0)
            {
                foreach (var emp in AllEmployeesFromEmployeeGraph)
                {
                    emp.EmployeeId = NewEmp.Id;
                    this.Database.Employeegraphmounght.Add(emp);
                }
                    this.Database.SaveChanges();
                
            }
        }

        /// <summary>
        /// Deletes Employee from DataBase
        /// </summary>
        /// <param name="employee">Selected Employee</param>
        public void DeleteEmployee(EmployeeInfo employee)
        {
            //Gets the selected Employee
            var CurEmployee = Database.Employees.First(x => x.Egn == employee.EGN);
            //Get the employee from Employeegraph
            Employeegraph CurEmplGraph = Database.Employeegraph.FirstOrDefault(x => x.EmployeeId == CurEmployee.Id);
            //Used to Store all the Employees camo from this monght in Employeegraphmounght
            List<Employeegraphmounght> CurEmpsMongh = new List<Employeegraphmounght>();

            //Remove Employee from Employeegraph
            if (CurEmplGraph != null)
                this.Database.Employeegraph.Remove(CurEmplGraph);

            //Remove Employee from Employeegraphmounght
            if (this.Database.Employeegraphmounght.Count() != 0)
            {
                foreach (var emp in this.Database.Employeegraphmounght.Where(x => x.EmployeeId == CurEmployee.Id))
                {
                    this.Database.Employeegraphmounght.Remove(emp);
                }
            }

            this.Database.Employees.Remove(CurEmployee);
            this.Database.SaveChanges();
        }
    }
}
