using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class EarthBender:Bender
    {
        private double groundSaturation;

        public EarthBender(string name, int Power,double GroundSaturation) : base(name, Power)
        {
            this.GroundSaturation = GroundSaturation;
        }

        public double GroundSaturation 
        {
            get { return groundSaturation; }
            set { groundSaturation = value; }
        }

        public override double GetTotalPower()
        {
            return base.Power * this.GroundSaturation;
        }

        public override string ToString()
        {
            return $"{base.Name}, Power: {base.Power}, Ground Saturation: {groundSaturation:f2}";
        }
    }

