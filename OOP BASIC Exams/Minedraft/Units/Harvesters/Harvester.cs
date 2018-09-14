using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Harvester : Identificator
    {
        private double oreoutput;
        private double energyreaquirement;

        public  override string ToString()
        {
            return $"{this.Type} Harvester - {Id}" + Environment.NewLine +
                $"Ore Output: {oreoutput}" + Environment.NewLine +
                $"Energy Requirement: {energyreaquirement}";
        }
        protected Harvester(string Id, double OreOutput, double EnergyRequirement)
            : base(Id)
        {
            this.OreOutput = OreOutput;
            this.EnergyRequirement = EnergyRequirement;
        }

        public double OreOutput
        {
            get { return oreoutput; }
            protected set {
                if (value < 0) throw new ArgumentException
                            ($"Harvester is not registered, because of it's OreOutput");
                oreoutput = value;
            }
        }

        public double EnergyRequirement
        {
            get { return energyreaquirement; }
            protected set
            {
                if (value < 0||value> 20000) throw new ArgumentException
                        ($"Harvester is not registered, because of it's EnergyReaquirement");
                energyreaquirement = value;
            }
        }
    }

