using ExamPaw.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Centres
{
    class AdoptionCenter : Center
    {
        public AdoptionCenter(string Name) : base(Name)
        {
        }

        public int WaitAdob()
        {
            return base.animals.Where(se => se.IsCleaned == true).Count();
        }

        public List<Animal> Adoptation()
        {
            List<Animal> lis = base.animals.Where(se => se.IsCleaned == true).ToList();
            foreach (var animal in lis)
            {
                base.animals.Remove(animal);
            }
            return lis;
        }

        public void Cleanse(CleansingCenter nameCleanse)
        {
            List<Animal> CleanseAnimals = base.animals.
                Where(an => an.IsCleaned == false).ToList();
            nameCleanse.AcceptAnimals(CleanseAnimals);
            //double check 
            foreach (var animal in CleanseAnimals)
            {
                base.animals.Remove(animal);
            }
        }

        public void Send4Cast(CastrationCenter CurrCastrationCenter)
        {
            CurrCastrationCenter.AcceptAnimals(base.animals);
            base.animals.Clear();
        }
    }
}
