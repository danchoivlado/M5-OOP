using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SonicHarvester:Harvester
    {
        public int SonicFactor  { get; set; }

        public override string Type => "Sonic";

        public SonicHarvester(string Id, double OreOutput, double EnergyRequirement,int SonicFactor)
            : base(Id, OreOutput, EnergyRequirement)
        {
            this.SonicFactor = SonicFactor;
            base.EnergyRequirement = base.EnergyRequirement / SonicFactor;
        }



    }

