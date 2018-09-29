using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    class Gpu : Product
    {
        public Gpu(double Price) : base(Price, 0.7)
        {
        }
    }
}
