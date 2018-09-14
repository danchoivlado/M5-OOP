using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class Bender : Nameble
    {
        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

      
            

        protected Bender(string name,int Power) : base(name)
        {
            this.Power = Power;
        }
    }

