using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Animals
{
    class Cat : Animal
    {
        public Cat(string Name, int Age,int IQ,string deffCenter) : base(Name, Age,deffCenter)
        {
            this.IQ = IQ;
        }

        public int IQ { get;private set; }
    }
}
