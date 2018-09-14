using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FireBender:Bender
    {
        private double heatAggression;

        public FireBender(string name, int Power,double HeatAggression) : base(name, Power)
        {
            this.HeatAggression = HeatAggression;
        }

        public double HeatAggression 
        {
            get { return heatAggression; }
            set { heatAggression = value; }
        }

        public override double GetTotalPower()
        {
            return base.Power * this.HeatAggression;
        }

        public override string ToString()
        {
            return $"{base.Name}, Power: {base.Power}, Heat Aggression: {heatAggression:f2}";
        }
    }

