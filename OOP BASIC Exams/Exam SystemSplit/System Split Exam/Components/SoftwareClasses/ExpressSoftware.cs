using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ExpressSoftware : Software
    {
        public ExpressSoftware(string Name, int CapConsuption, int MemConsuption) : base(Name, CapConsuption, MemConsuption*2)
        {
        }

        public override string Type => "ExpressSoftware";
    }

