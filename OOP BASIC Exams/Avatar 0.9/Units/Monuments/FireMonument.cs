using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FireMonument:Monument
    {
        private int fireAffinity;

        public FireMonument(string name,int FireAffinity) : base(name)
        {
            this.FireAffinity = FireAffinity;
        }

        public int FireAffinity 
        {
            get { return fireAffinity; }
            set { fireAffinity = value; }
        }

        public override double GetTotalPower() => FireAffinity;

        public override string ToString()
        {
            return $"{base.Name}, Fire Affinity: {fireAffinity}";
        }
    }

