using System;
using System.Collections.Generic;

namespace App1.Models
{
    public partial class Admins
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ScannerCardNumber { get; set; }
    }
}
