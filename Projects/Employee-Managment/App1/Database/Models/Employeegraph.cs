﻿using System;
using System.Collections.Generic;

namespace App1.Models
{
    public partial class Employeegraph
    {
        public int Id { get; set; }
        public string CurrentDate { get; set; }
        public int EmployeeId { get; set; }
        public string CameWork { get; set; }
        public string LeaveWork { get; set; }

        public virtual Employees Employee { get; set; }
    }
}
