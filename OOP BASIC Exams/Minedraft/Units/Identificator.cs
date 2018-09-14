using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Identificator
    {
        public string Id { get;private set; }
        public abstract string Type { get; }
        protected Identificator(string Id)
        {
            this.Id = Id;
        }
    }

