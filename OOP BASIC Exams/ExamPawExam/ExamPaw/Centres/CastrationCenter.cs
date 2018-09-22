using ExamPaw.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Centres
{
    class CastrationCenter : Center
    {
       

        public CastrationCenter(string Name) : base(Name)
        {
        }

        public void Castrate(AdoptionCenter cur,Animal animal)
        {
            cur.AddAnimal(animal);
            //base.animals.Remove(animal);
        }

        public void AcceptAnimals(List<Animal> animals)
        {
            base.animals.AddRange(animals);
        }

    }
}
