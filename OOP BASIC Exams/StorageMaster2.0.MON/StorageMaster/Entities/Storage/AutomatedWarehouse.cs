using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    class AutomatedWarehouse : Storage
    {

        public AutomatedWarehouse(string name) : base(name, 1, 2, new Vehicle[] { new Truck() })
        {
        }
    }
}
