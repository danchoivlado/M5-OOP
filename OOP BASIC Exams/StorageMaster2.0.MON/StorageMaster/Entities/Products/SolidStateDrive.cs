using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    class SolidStateDrive : Product
    {
        public SolidStateDrive(double Price) : base(Price, 0.2)
        {
        }
    }
}
