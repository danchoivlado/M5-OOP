using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public class HardTyre : Tyre
    {
        public HardTyre( double hardness) : base( hardness)
        {
            base.Name = "Hard";
        }
    }
}
