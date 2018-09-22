using ExamPaw.Animals;
using ExamPaw.Centres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Core
{
    class CommandCenter
    {
        private List<AdoptionCenter> AdoptionCenterlis;
        private List<CleansingCenter> CleansingCenterlis;
        //private List<Animal> animals;
        private List<string> adopted;

        public List<string> AllCleansedAnimals { get; private set; }

        public CommandCenter()
        {
            this.AdoptionCenterlis = new List<AdoptionCenter>();
            this.CleansingCenterlis = new List<CleansingCenter>();
          //  this.animals = new List<Animal>();
        }

        public void RegisterCleansingCenter(string[] arr)
        {
            string name = arr[1];
            this.CleansingCenterlis.Add(new CleansingCenter(name));
        }
        public void RegisterAdoptionCenter(string[] arr)
        {
            string name = arr[1];
            this.AdoptionCenterlis.Add(new AdoptionCenter(name));
        }
        public void RegisterDog(string[] arr)
        {
            string name = arr[1];
            int age = int.Parse(arr[2]);
            int learnedcomands = int.Parse(arr[3]);
            string ACN = arr[4];
            if (this.AdoptionCenterlis.Any(se => se.SeeName() == ACN))
            {
                Center curcenter = this.AdoptionCenterlis.
                    Where(se => se.SeeName() == ACN).First();
                curcenter.AddAnimal(new Dog(name, age, learnedcomands,ACN));
            }
            else
            {
                Center Currcenter = this.CleansingCenterlis.
                    Where(se => se.SeeName() == ACN).First();
                Currcenter.AddAnimal(new Dog(name, age, learnedcomands,ACN));
            }

        }
        public void RegisterCat(string[] arr)
        {
            string name = arr[1];
            int age = int.Parse(arr[2]);
            int IQ = int.Parse(arr[3]);
            string ACN = arr[4];
            if (this.AdoptionCenterlis.Any(se=>se.SeeName()==ACN))
            {
                Center currcenter = this.AdoptionCenterlis.
                    Where(se => se.SeeName() == ACN).First();
                currcenter.AddAnimal(new Cat(name, age, IQ,ACN));
            }
            else
            {
                Center currcenter = this.CleansingCenterlis.
                    Where(se => se.SeeName() == ACN).First();
                currcenter.AddAnimal(new Cat(name, age, IQ,ACN));
            }
        }
        public void SendForCleansing(string[] arr)
        {
            string adoptionCenterName = arr[1];
            string cleansingCenterName = arr[2];

            AdoptionCenter CurrAdoptionCenter = this.AdoptionCenterlis.
                Where(se => se.SeeName() == adoptionCenterName).First();
            CleansingCenter CurrCleansingCenter = this.CleansingCenterlis.
                Where(se => se.SeeName() == cleansingCenterName).First();

            CurrAdoptionCenter.Cleanse(CurrCleansingCenter);
        }
        public void Cleanse(string[] arr)
        {
            string cleansingCenterName = arr[1];
            CleansingCenter CurrCleansingCenter = this.CleansingCenterlis.
                Where(se => se.SeeName() == cleansingCenterName).First();
            CurrCleansingCenter.Cleanse();
            AllCleansedAnimals = CurrCleansingCenter.animals.Select(se=>se.Name).ToList();
            foreach (var animal in CurrCleansingCenter.animals)
            {
                AdoptionCenter curr = AdoptionCenterlis.
                    Where(se => se.SeeName() == animal.DefCenter).First();
                curr.AddAnimal(animal);
            }
        }
        public void Adopt(string[] arr)
        {
            string adoptionCenterName = arr[1];
            AdoptionCenter curr = this.AdoptionCenterlis.
                Where(se=>se.SeeName()==adoptionCenterName).First();
            this.adopted=curr.Adoptation().Select(se=>se.Name).ToList();
        }
        public string PawPawPawah()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Paw Incorporative Regular Statistics");
            sb.AppendLine($"Adoption Centers: {this.AdoptionCenterlis.Count}");
            sb.AppendLine($"Cleansing Centers: {this.CleansingCenterlis.Count}");
            if (this.adopted.Count == 0) sb.AppendLine("None");
            else sb.AppendLine($"Adopted Animals: {string.Join(", ", this.adopted.OrderBy(se=>se))}");
            if (this.CleansingCenterlis.Count == 0) sb.AppendLine($"None");
            else sb.AppendLine($"Cleansed Animals: {string.Join(", ", this.AllCleansedAnimals.OrderBy(se=>se))}");
            sb.AppendLine($"Animals Awaiting Adoption: {this.AdoptionCenterlis.Sum(se=> se.WaitAdob())}");
            sb.AppendLine($"Animals Awaiting Cleansing: {this.CleansingCenterlis.Sum(se=>se.WaitClean())}");
            return sb.ToString().Trim();
        }
    }
}
