using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public class UltrasoftTyre : Tyre
    {
        public double Grip { get;  }

        public UltrasoftTyre( double hardness, double grip) : base( hardness)
        {
            base.Name = "Ultrasoft";
            this.Grip = grip;
        }

        public override double Degradation
        {
            get { return base.Degradation; }
            protected set
            {
                if (value < 30)
                {
                    throw new ArgumentException("Blown Tyre");
                }
                base.Degradation = value;

            }
        }
        public override void Degradate()
        {
            base.Degradation -= base.Hardness + this.Grip;
        }
    }
}
