using ExamPaw.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Centres
{
    public abstract class Center
    {
        public string Name { get; private set; }
        public List<Animal> animals;

        protected Center(string Name)
        {
            this.animals = new List<Animal>();
            this.Name = Name;
        }

        public string SeeName()
        {
            return $"{this.Name}";
        }
        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }
        //public abstract void Cleanse();

        //public abstract void Adoptation();
    }
}
