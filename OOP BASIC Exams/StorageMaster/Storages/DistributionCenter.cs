using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DistributionCenter : Storage
    {
        public DistributionCenter(string Name) : base(Name, 2, 5, new Vehicle[3] {new Van(),new Van(),new Van() })
        {
        }
    }

