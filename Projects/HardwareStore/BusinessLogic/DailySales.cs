using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.BusinessLogic
{
   public class DailySales
    {
        public string ProductNumber { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double SinglePrice { get; set; }
        public double Total { get; set; }

        public DailySales()
        {

        }
    }
}
