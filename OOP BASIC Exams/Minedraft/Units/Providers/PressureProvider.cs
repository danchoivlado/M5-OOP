using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PressureProvider : Provider
    {
        public PressureProvider(string Id, double EnergyOutput)
            : base(Id, EnergyOutput*1.5)
        {
        }

        public override string Type => "Pressure";
    }

