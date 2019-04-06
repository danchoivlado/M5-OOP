using System;
using System.Collections.Generic;

namespace HardwareStore.Models
{
    public partial class InvoiceItems
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public double SinglePrice { get; set; }
        public double Total { get; set; }
        public int InvoiceId { get; set; }

        public virtual Items Item { get; set; }
    }
}
