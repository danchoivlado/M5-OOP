using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storage;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Core
{
    class StorageMaster
    {
        private List<Product> Productslis;
        private List<Storage> Storageslis;
        private Vehicle SelectedVehicle;

        public StorageMaster()//TODO
        {
            this.Productslis = new List<Product>();
            this.Storageslis = new List<Storage>();
            this.SelectedVehicle = null;
        }

        public string AddProduct(string type, double price)
        {
            string endline = $"Added {type} to pool"; 

            switch (type)
            {
                case "Gpu":
                    this.Productslis.Add(new Gpu(price));
                    return endline;
                case "HardDrive":
                    this.Productslis.Add(new HardDrive(price));
                    return endline;
                case "Ram":
                    this.Productslis.Add(new Ram(price));
                    return endline;
                case "SolidStateDrive":
                    this.Productslis.Add(new SolidStateDrive(price));
                    return endline;
                default:
                    throw new InvalidOperationException("Invalid product type!");
            }


        }



        public string RegisterStorage(string type, string name)
        {
            string Endline = $"Registered {name}";

            switch (type)
            {
                case "AutomatedWarehouse":
                    this.Storageslis.Add(new AutomatedWarehouse(name));
                    return Endline;
                case "DistributionCenter":
                    this.Storageslis.Add(new DistributionCenter(name));
                    return Endline;
                case "Warehouse":
                    this.Storageslis.Add(new Warehouse(name));
                    return Endline;
                default:
                    throw new InvalidOperationException("Invalid storage type!");
            }


        }



        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage CurrStorage = this.Storageslis.First(se => se.Name == storageName);
            //if (SelectedVehicle == null) throw new ArgumentException("SelecedStorage is null");
            this.SelectedVehicle= CurrStorage.GetVehicle(garageSlot);

            return $"Selected {CurrStorage.GetVehicle(garageSlot).GetType().Name}";
        }



        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;
            foreach (var name in productNames)
            {
                if (!this.Productslis.Any(se => se.GetType().Name == name))
                    throw new InvalidOperationException($"{name} is out of stock!");
                Product Currproduct = this.Productslis.Last(se=>se.GetType().Name==name);
                if (SelectedVehicle.IsFull) break; //ZA da ne garmi 
                this.Productslis.Remove(Currproduct);
                this.SelectedVehicle.LoadProduct(Currproduct);
                loadedProductsCount++;
            }
            return $"Loaded {loadedProductsCount}/{productNames.Count()} products into {this.SelectedVehicle.GetType().Name}";
        }



        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage SourceStorage = this.Storageslis.FirstOrDefault(se => se.Name == sourceName);
            Storage DesStorage = this.Storageslis.FirstOrDefault(se => se.Name == destinationName);

            if (SourceStorage == null) throw new InvalidOperationException("Invalid source storage!");
            if (DesStorage == null) throw new InvalidOperationException("Invalid destination storage!");

            Vehicle CurrVeh = SourceStorage.GetVehicle(sourceGarageSlot);
            int DesFreeSlot = SourceStorage.SendVehicleTo(sourceGarageSlot,DesStorage);

            return $"Sent {CurrVeh.GetType().Name} to {destinationName} (slot {DesFreeSlot})";
        }

     
            
        

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage CurrStorage = this.Storageslis.First(se => se.Name == storageName);
            int productsInVehicle = CurrStorage.GetVehicle(garageSlot).Trunk.Count;
            int unloadedProductsCount = CurrStorage.UnloadVehicle(garageSlot);


            return $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
        }



        public string GetStorageStatus(string storageName)
        {
            Storage storage= this.Storageslis.First(se => se.Name == storageName);
            var sb = new StringBuilder();
            sb.AppendLine(storage.GetProductInf());
            sb.AppendLine(storage.GetGarageInf());
            return sb.ToString().Trim();

        }



        public string GetSummary()
        {
            var sb = new StringBuilder();
            foreach (var storage in this.Storageslis.OrderByDescending(se=>se.Products.Sum(s=>s.Price)))
            {
                sb.AppendLine($"{storage.Name}:");
                sb.AppendLine($"Storage worth: ${storage.Products.Sum(se => se.Price):F2}");
            }
            return sb.ToString().Trim();

        }
    }
}
