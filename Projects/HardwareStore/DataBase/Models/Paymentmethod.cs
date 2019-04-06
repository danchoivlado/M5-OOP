using System;
using System.Collections.Generic;

namespace HardwareStore.Models
{
    public partial class Paymentmethod
    {
        public Paymentmethod()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Method { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
