using System;
using System.Collections.Generic;

namespace HardwareStore.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int EmployeeId { get; set; }
        public double Total { get; set; }
        public int PaymentMethodId { get; set; }
        public int StoreInfoId { get; set; }

        public virtual Employees Employee { get; set; }
        public virtual Paymentmethod PaymentMethod { get; set; }
        public virtual StoreInfo StoreInfo { get; set; }
    }
}
