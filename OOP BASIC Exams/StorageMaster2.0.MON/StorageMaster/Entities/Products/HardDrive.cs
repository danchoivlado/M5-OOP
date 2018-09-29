using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    class HardDrive : Product
    {
        public HardDrive(double Price) : base(Price, 1d)
        {
        }
    }
}
