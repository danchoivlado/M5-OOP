using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LightSoftware : Software
    {
        public LightSoftware(string Name, int CapConsuption, int MemConsuption) :
            base(Name, CapConsuption+((CapConsuption*2)/4), MemConsuption-(MemConsuption*2)/4)
        {
        }

        public override string Type => "LightSoftware";
    }

