using System;
using System.Collections.Generic;

namespace HardwareStore.Models
{
    public partial class LastLogin
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? DateLimeLogined { get; set; }

        public virtual Employees Employee { get; set; }
    }
}
