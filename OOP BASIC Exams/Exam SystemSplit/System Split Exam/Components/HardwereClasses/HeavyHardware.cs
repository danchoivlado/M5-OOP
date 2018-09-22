using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HeavyHardware : Hardware
    {
        public HeavyHardware(string Name,  int MaxMemory, int MaxCapacity) : base(Name, MaxMemory - (MaxMemory / 4) , MaxCapacity * 2)
        {
        }

        public override string Type => "HeavyHardware";
    }

