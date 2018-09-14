using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class Provider : Identificator
    {
        private double energyoutput;

        protected Provider(string Id,double EnergyOutput) : base(Id)
        {
            this.EnergyOutput = EnergyOutput;
        }

        public double EnergyOutput
        {
            get { return energyoutput; }
            set
            {
                if (value < 0 || value >= 10000) throw new ArgumentException
                              ($"Provider is not registered, because of it's EnergyOutput");
                energyoutput = value;
            }
        }
        public override string ToString()
        {
            return $"{Type} Provider - {Id}" + Environment.NewLine +
                $"Energy Output: {this.energyoutput}";
        }
    }

