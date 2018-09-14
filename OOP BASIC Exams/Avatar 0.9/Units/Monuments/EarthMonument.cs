using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class EarthMonument:Monument
    {
        private int earthAffinity;

        public EarthMonument(string name,int EarthAffinity) : base(name)
        {
            this.EarthAffinity = EarthAffinity;
        }

        public int EarthAffinity 
        {
            get { return earthAffinity; }
            set { earthAffinity = value; }
        }

        public override double GetTotalPower() => EarthAffinity;

        public override string ToString()
        {
            return $"{base.Name}, Earth Affinity: {earthAffinity}";
        }
    }
