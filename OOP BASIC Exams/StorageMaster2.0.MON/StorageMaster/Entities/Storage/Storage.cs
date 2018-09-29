using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Entities.Products;

namespace StorageMaster.Entities.Storage
{
    public abstract class Storage
    {
        public string Name { get; }
        public int Capacity { get; } //Max Weight of Products
        public int GarageSlots { get; }
        public bool IsFull => this.products.Sum(se => se.Weight) >= this.Capacity;
        private readonly Vehicle[] garage;
        private readonly List<Product> products;

        public IReadOnlyCollection<Vehicle> Garage
        {
            get { return this.garage; }
        }
        public IReadOnlyCollection<Product> Products
        {
            get { return this.products; }
        }

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            int index = 0;
            this.products = new List<Product>();
            this.garage = new Vehicle[this.GarageSlots];
            foreach (var veh in vehicles)
            {
                this.garage[index] = veh;
                index++;
            }

        }

        public Vehicle GetVehicle(int garageSlot)
        {
            Validate(garageSlot);
            return this.garage[garageSlot];
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Validate(garageSlot);
            Vehicle Currvehicle = this.garage[garageSlot];
            if (!deliveryLocation.garage.Any(se => se == null)) throw new InvalidOperationException("No room in garage!");
            this.garage[garageSlot] = null;
            int index = 0;
            for (int i = 0; i < deliveryLocation.garage.Count(); i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    index = i;
                    deliveryLocation.garage[i] = Currvehicle;
                    break;
                }
            }
            return index;
        }
        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull) throw new InvalidOperationException("Storage is full!");
            Vehicle CurrVehicle = this.GetVehicle(garageSlot);
            int num = 0;
            while (true)
            {
                if (CurrVehicle.IsEmpty || this.IsFull) return num;
                this.products.Add(CurrVehicle.Unload());
                num++;
            }

        }
        private void Validate(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots) throw new InvalidOperationException("Invalid garage slot!");
            if (this.garage[garageSlot] == null) throw new InvalidOperationException("No vehicle in this garage slot!");
        }

        public string GetProductInf()
        {
            List<string> pr= this.products.GroupBy(p => p.GetType().Name).
                OrderByDescending(p=>p.Count()).ThenBy(se=>se.Key).Select(p => $"{p.Key} ({p.Count()})").ToList();
            return $"Stock ({this.products.Sum(s=>s.Weight)}/{this.Capacity}): [{string.Join(", ",pr)}]";
        }

        public string GetGarageInf()
        {
           
            List<string> arr5 = new List<string>();
            for (int i = 0; i < this.garage.Count(); i++)
            {
                if (this.garage[i] == null) arr5.Add("empty");
                else arr5.Add(garage[i].GetType().Name);
            }
            return $"Garage: [{string.Join("|",arr5)}]";
        }
    }
}
