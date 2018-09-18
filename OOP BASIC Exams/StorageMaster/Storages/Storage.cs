using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class Storage
    {
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int GarageSlots { get; private set; }
        public Vehicle[] Garage;
        public readonly List<Product> Products;

        protected Storage(string Name, int Capacity, int GarageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = Name;
            this.Capacity = Capacity;
            this.Garage = new Vehicle[GarageSlots];
            this.GarageSlots = GarageSlots;
            this.Initialize(vehicles);
        this.Products = new List<Product>();
            
        }

        public void Validate(int GarageSlot)//Double Check
        {
            if(GarageSlot>=this.GarageSlots) throw new InvalidOperationException("Invalid garage slot!");
            if (this.Garage[GarageSlot] == null) throw new InvalidOperationException("No vehicle in this garage slot!");
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            this.Validate(garageSlot);
            return this.Garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            this.Validate(garageSlot);
            Vehicle CurrVehicle = this.Garage[garageSlot];           
            if (!deliveryLocation.Garage.Any(wei => wei == null)) throw new InvalidOperationException("No room in garage!");
            return this.AddVehicle(CurrVehicle, deliveryLocation);
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull()) throw new InvalidOperationException("Storage is full!");
            this.Validate(garageSlot);
            Vehicle CurrVehicle = this.Garage[garageSlot];
            int ret = this.UnloadProducts(CurrVehicle);
            return ret;
        }

        private int UnloadProducts(Vehicle vehicle)
        {
            var products = vehicle.Trunk;
            var index = 0;
            while (true)
            {
            if (this.IsFull() == true || vehicle.IsEmpty() == true || products.Count == index)
            {
                products.RemoveRange(0, index);
                return index;
            }
                this.Products.Add(products[index]);
                //products.re(index);
                index++;
            }
        }

        private int AddVehicle(Vehicle vehicle, Storage deliveryLocation)
        {
            int Index = Array.IndexOf(this.Garage, null);
            deliveryLocation.Garage[Index] = vehicle;
            return Index;
        }

        public bool IsFull()
        {
            var SumWeight = Products.Sum(wei => wei.Weight);
            return SumWeight >= this.Capacity ? true : false;
        }

        

        private void Initialize(IEnumerable<Vehicle> vehicles)
        {
            var gar = 0;
            foreach (var car in vehicles)
            {
                this.Garage[gar] = car;
                gar++;
            }
        }
        
    }

