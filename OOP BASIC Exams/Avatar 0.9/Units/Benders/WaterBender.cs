using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class WaterBender:Bender
    {
        private double waterClarity;

        public WaterBender(string name, int Power,double WaterClarity) : base(name, Power)
        {
            this.WaterClarity = WaterClarity;
        }

        public double WaterClarity 
        {
            get { return waterClarity; }
            set { waterClarity = value; }
        }

        public override double GetTotalPower()
        {
            return base.Power * this.WaterClarity;
        }

        public override string ToString()
        {
            return $"{base.Name}, Power: {base.Power}, Water Clarity: {waterClarity:f2}";
        }
    }

