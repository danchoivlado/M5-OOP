using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public abstract class Nameble
    {
        public string Name { get; private set; }
        public abstract double GetTotalPower();

        public Nameble(string name)
        {
            this.Name = name;
        }
        public abstract override string ToString();
    }

