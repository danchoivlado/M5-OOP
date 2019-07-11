using System;
using System.Collections.Generic;

namespace App1.Models
{
    public partial class Towns
    {
        public Towns()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
