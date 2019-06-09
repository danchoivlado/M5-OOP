using System;
using System.Collections.Generic;

namespace App1.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Employeegraph = new HashSet<Employeegraph>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Egn { get; set; }
        public int DutyId { get; set; }
        public int TownId { get; set; }
        public string TelephoneNumber { get; set; }
        public string ScannerCardNumber { get; set; }

        public virtual Duties Duty { get; set; }
        public virtual Towns Town { get; set; }
        public virtual ICollection<Employeegraph> Employeegraph { get; set; }
    }
}
