using System;
using System.Collections.Generic;

namespace HardwareStore.Models
{
    public partial class StoreInfo
    {
        public StoreInfo()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
