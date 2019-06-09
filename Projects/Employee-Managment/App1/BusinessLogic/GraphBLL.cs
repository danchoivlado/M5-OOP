using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;

namespace App1.BusinessLogic
{
    class GraphBLL
    {
        DBContext dBContext;
        public GraphBLL()
        {
            this.dBContext = new DBContext();
        }

        public string GetLast()
        {
            var LastScaned = this.dBContext.Lastscaned.LastOrDefault();
            if (LastScaned == null)
            {
                return "";
            }
            this.dBContext.Lastscaned.Remove(LastScaned);
            this.dBContext.SaveChanges();
            return LastScaned.ScannerCardNumber;
        }
    }
}
