using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirBender : Bender
    {
        private double aerialIntegrity;

        public double AerialIntegrity 
        {
            get { return aerialIntegrity; }
            set { aerialIntegrity = value; }
        }

        public AirBender(string name, int Power,double AerialIntegrity) : base(name, Power)
        {
            this.AerialIntegrity = AerialIntegrity;
        }

        public override double GetTotalPower()
        {
            return base.Power * AerialIntegrity;
        }

        public override string ToString()
        {
            return $"{base.Name}, Power: {base.Power}, Aerial Integrity: {aerialIntegrity:f2}";
        }
    }

