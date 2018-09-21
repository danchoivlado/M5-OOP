using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Animals
{
    public abstract class Animal
    {
        public string Name { get;private set; }
        public int Age { get;private set; }
        public bool IsCleaned { get; set; } = false;
        public string DefCenter { get;private set; }
        protected Animal(string Name,int Age,string DefCenter)
        {
            this.Name = Name;
            this.Age = Age;
            this.DefCenter = DefCenter;
        }
    }
}
