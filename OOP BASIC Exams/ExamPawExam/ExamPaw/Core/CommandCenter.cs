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
        private List<CastrationCenter> CastrationCentersLis;
        private List<string> Castrated;
        
        public CommandCenter()
        {
            this.AdoptionCenterlis = new List<AdoptionCenter>();
            this.CleansingCenterlis = new List<CleansingCenter>();
            this.CastrationCentersLis = new List<CastrationCenter>();
            this.Castrated = new List<string>();
            this.adopted = new List<string>();
            this.AllCleansedAnimals = new List<string>();
          //  this.animals = new List<Animal>();
        }

        public void RegisterCastrationCenter(string[] arr)
        {
            string name = arr[1];
            this.CastrationCentersLis.Add(new CastrationCenter(name));
        }

        public void SendForCastration(string[] arr)
        {
            string adoptionCenterName = arr[1];
            string castrationCenterName = arr[2];
            AdoptionCenter CurrAdop = this.AdoptionCenterlis.Where(se => se.Name == adoptionCenterName).First();
            CastrationCenter CurrCastr = this.CastrationCentersLis.Where(se => se.Name == castrationCenterName).First();
            CurrAdop.Send4Cast(CurrCastr);
        }

        public void Castrate(string[] arr)
        {
            string name = arr[1];
            CastrationCenter CurrCenter = this.CastrationCentersLis.First(se => se.Name == name);
            foreach (var animal in CurrCenter.animals)
            {
                CurrCenter.Castrate(this.AdoptionCenterlis.Find(se => se.Name == animal.DefCenter), animal);
                this.Castrated.Add(animal.Name);
            }
            foreach (var animal in this.Castrated)
            {
                CurrCenter.animals.Remove(CurrCenter.animals.First(se=>se.Name==animal));
            }
            
        }
        public string CastrationStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Paw Inc. Regular Castration Statistics");
            sb.AppendLine($"Castration Centers: {this.CastrationCentersLis.Count}");
            if (Castrated.Count == 0) sb.AppendLine($"Castrated Animals: None");
            else sb.AppendLine($"Castrated Animals: {string.Join(", ", Castrated.OrderBy(se => se))}");
            return sb.ToString().Trim();
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
            if (this.adopted.Count == 0) sb.AppendLine("Cleansed Animals: None");
            else sb.AppendLine($"Adopted Animals: {string.Join(", ", this.adopted.OrderBy(se=>se))}");
            if (this.AllCleansedAnimals.Count == 0) sb.AppendLine($"Cleansed Animals: None");
            else sb.AppendLine($"Cleansed Animals: {string.Join(", ", this.AllCleansedAnimals.OrderBy(se=>se))}");
            sb.AppendLine($"Animals Awaiting Adoption: {this.AdoptionCenterlis.Sum(se=> se.WaitAdob())}");
            sb.AppendLine($"Animals Awaiting Cleansing: {this.CleansingCenterlis.Sum(se=>se.WaitClean())}");
            return sb.ToString().Trim();
        }
    }
}
