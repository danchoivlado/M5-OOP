using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Animals
{
    class Dog : Animal
    {
        public Dog(string Name, int Age,int AmountofCommands,string defcenter) 
            : base(Name, Age,defcenter)
        {
            this.AmountofCommands = AmountofCommands;
        }

        public int AmountofCommands { get;private set; }

    }
}
