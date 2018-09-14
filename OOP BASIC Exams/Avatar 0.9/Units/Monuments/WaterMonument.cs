using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class WaterMonument : Monument
    {
        private int waterAffinity;

        public WaterMonument(string name,int WaterAffinity) : base(name)
        {
            this.WaterAffinity = WaterAffinity;
        }
        public int WaterAffinity 
        {
            get { return waterAffinity; }
            set { waterAffinity = value; }
        }

        public override double GetTotalPower() => WaterAffinity;

        public override string ToString()
        {
            return $"{base.Name}, Water Affinity: {waterAffinity}";
        }
    }

