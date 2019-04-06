using System;
using System.Collections.Generic;

namespace HardwareStore.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Invoice = new HashSet<Invoice>();
            LastLogin = new HashSet<LastLogin>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int DutyId { get; set; }
        public int TownId { get; set; }

        public virtual Duties Duty { get; set; }
        public virtual Towns Town { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<LastLogin> LastLogin { get; set; }
    }
}
