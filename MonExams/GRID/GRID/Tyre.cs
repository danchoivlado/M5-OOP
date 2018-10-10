using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public abstract class Tyre
    {
        public string Name { get; protected set; }
        public double Hardness { get; }
        private double degradation;

        protected Tyre(double hardness)
        {
            this.Hardness = hardness;
            this.Degradation += 100;
        }

        public virtual double Degradation   
        {
            get { return  degradation; }
            protected set
            {
                if ( value < 0)
                {
                    throw new ArgumentException("Blown Tyre");
                }
                degradation = value;

            }
        }
        public virtual void Degradate()
        {
            this.Degradation -= this.Hardness;
        }
    }
}
