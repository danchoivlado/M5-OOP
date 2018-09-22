using ExamPaw.Animals;
using ExamPaw.Centres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw
{
    class CleansingCenter : Center
    {
        public CleansingCenter(string Name) : base(Name)
        {
        }
        public void AcceptAnimals(List<Animal> lis)
        {
            base.animals.AddRange(lis);
        }
        public  void Adoptation()
        {
            throw new NotImplementedException();
        }
         
        public int WaitClean()
        {
            return base.animals.Where(se => se.IsCleaned == false).Count();
        }

        public void Cleanse()
        {
            foreach (var animal in base.animals)
            {
                animal.IsCleaned=true; 
            }
            
        }
    }
}
