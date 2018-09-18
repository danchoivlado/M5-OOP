using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Warehouse : Storage
    {
        public Warehouse(string Name) : base(Name, 10, 10, new Vehicle[3] { new Semi(), new Semi(), new Semi() })
        {
        }
    }

