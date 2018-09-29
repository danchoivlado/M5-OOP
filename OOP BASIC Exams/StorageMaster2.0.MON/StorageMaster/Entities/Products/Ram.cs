using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    class Ram : Product
    {
        public Ram(double Price) : base(Price, 0.1)
        {
        }
    }
}
