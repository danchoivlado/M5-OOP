using System;
using System.Collections.Generic;

namespace App1.Models
{
    public partial class Duties
    {
        public Duties()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string Duty { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
