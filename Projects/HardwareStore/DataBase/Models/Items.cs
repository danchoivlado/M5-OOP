using System;
using System.Collections.Generic;

namespace HardwareStore.Models
{
    public partial class Items
    {
        public Items()
        {
            InvoiceItems = new HashSet<InvoiceItems>();
        }

        public string Id { get; set; }
        public string ProductName { get; set; }
        public double OriginalPrice { get; set; }
        public double SalesPrice { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
    }
}
