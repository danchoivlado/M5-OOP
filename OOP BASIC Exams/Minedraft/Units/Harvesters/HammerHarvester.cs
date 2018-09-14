using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HammerHarvester : Harvester
    {
        public HammerHarvester(string Id, double OreOutput, double EnergyRequirement)
            : base(Id, OreOutput *3, EnergyRequirement*2)
        { }

        public override string Type => "Hammer";
    }

