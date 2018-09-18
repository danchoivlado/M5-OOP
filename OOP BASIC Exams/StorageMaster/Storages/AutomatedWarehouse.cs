using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class AutomatedWarehouse : Storage
    {
        public AutomatedWarehouse(string Name) : base(Name, 1, 2, new Vehicle[1] {new Truck()})
        {
        }
    }

