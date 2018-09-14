using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class AirMonument : Monument
    {
        private int airAffinity;
        public AirMonument(string name,int airAffinity) : base(name)
        {
            this.AirAffinity = airAffinity;
        }
        public int AirAffinity 
        {
            get { return airAffinity; }
            set { airAffinity = value; }
        }

        public override double GetTotalPower()
        {
            return AirAffinity;
        }

        public override string ToString()
        {
            return $"{base.Name}, Air Affinity: {airAffinity}";
        }
    }

