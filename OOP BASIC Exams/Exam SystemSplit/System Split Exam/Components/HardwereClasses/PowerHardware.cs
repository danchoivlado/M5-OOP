using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PowerHardware : Hardware
    {
        public PowerHardware(string Name, int MaxMemory, int MaxCapacity) : base(Name, MaxMemory + ((MaxMemory*3)/4), MaxCapacity - ((MaxCapacity * 3) / 4))
        {
        }

        public override string Type => "PowerHardware";
    }

