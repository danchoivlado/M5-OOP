using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SolarProvider : Provider
    {
        public SolarProvider(string Id, double EnergyOutput)
            : base(Id, EnergyOutput)
        { }

        public override string Type => "Solar";
    }

