using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Software
    {
        public string Name { get;private set; }
        public int CapConsuption { get;private set; }
        public abstract string Type { get; }
        public int MemConsuption { get;private set; }

        public string SoftwereType()
        {
            return this.Type;
        }

        protected Software(string Name,int CapConsuption,int MemConsuption)
        {
            this.Name = Name;
            this.CapConsuption = CapConsuption;
            this.MemConsuption = MemConsuption;
        }
    }

