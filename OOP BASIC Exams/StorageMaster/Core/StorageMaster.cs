using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StorageMaster
{
    private List<Product> products;//TODO
    private List<Storage> storages;
    private Vehicle SelectedVehicle;

    public StorageMaster()
    {
        this.products = new List<Product>();
        this.storages = new List<Storage>();
    }

    public string AddProduct(string type, double price)
    {
        products.Add(ProductFac.CreatProduct(type, price));
        return $"Added {type} to pool";
    }

    public string RegisterStorage(string type, string name)
    {
        storages.Add(StorageFak.CreateFac(type, name));
        return $"Registered {name}";
    }

    public string SelectVehicle(string storageName, int garageSlot)
    {
        this.SelectedVehicle = this.storages.Where(st => st.Name == storageName).First().GetVehicle(garageSlot);
        return $"Selected {SelectedVehicle.GetType().ToString()}";

    }

    public string LoadVehicle(IEnumerable<string> productNames)
    {
        var couner = 0;
        foreach (var name in productNames)
        {
            Product curr = this.products.FirstOrDefault(pa => pa.GetType().Name == name);
            if (curr == null)
            {
                throw new InvalidOperationException($"{name} is out of stock!");
            }
            var torem = this.products.Last(pa => pa.GetType().Name == name);
            this.products.Remove(torem);
            if (this.SelectedVehicle.IsFull())
            {
                return $"Loaded {couner}/{productNames.ToList().Count} products into {this.SelectedVehicle.GetType().Name}";
            }
            this.SelectedVehicle.LoadProduct(torem);
            couner++;
        }
        return $"Loaded {couner}/{productNames.ToList().Count} products into {this.SelectedVehicle.GetType().Name}";
    }

    public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
    {
        Storage source = this.storages.FirstOrDefault(pa => pa.Name == sourceName);
        Storage destination = this.storages.FirstOrDefault(pa => pa.Name == destinationName);
        if (source == null)
            throw new InvalidOperationException("Invalid source storage!");
        else if (destination == null)
            throw new InvalidOperationException("Invalid destination storage!");
        int i= source.SendVehicleTo(sourceGarageSlot, destination);
        //destination.Garage[i] = source.Garage[sourceGarageSlot];
        Vehicle a = source.Garage[sourceGarageSlot];
        source.Garage[sourceGarageSlot] = null;
        return $"Sent {a.GetType().Name} to {destinationName} (slot {i})";
    }

    public string UnloadVehicle(string storageName, int garageSlot)
    {
        Storage curstorage = this.storages.First(pa => pa.Name == storageName);
        var curVeh = curstorage.Garage[garageSlot].Trunk.Count;
        int i = curstorage.UnloadVehicle(garageSlot);
        return $"Unloaded {i}/{curVeh} products at {storageName}";

    }

    public string GetStorageStatus(string storageName)
    {
        StringBuilder sb = new StringBuilder();
        Storage currstorage = this.storages.Find(se => se.Name == storageName);
        Vehicle[] currgarage = currstorage.Garage;
        List<string> join= currstorage.Products.GroupBy(se => se.GetType().Name).OrderByDescending(se=>se.Count()).ThenBy(se=>se.Key).Select(se => $"{se.Key} ({se.Count()})").ToList();

        sb.AppendLine($"Stock ({currstorage.Products.Sum(se => se.Weight)}/{currstorage.Capacity}): [{string.Join(", ", join)}]");
        List<Vehicle> lis1 = currgarage.Where(se => se == null).ToList();
        List<Vehicle> lis2 = currgarage.Where(se => se != null).ToList();
        var re= lis2.Select(se => se.GetType().Name).Concat(lis1.Select(se => "empty"));
        sb.AppendLine($"Garage: [{string.Join("|", re)}]");
        return sb.ToString().Trim();
    }

    public string GetSummary()
    {
        StringBuilder sb = new StringBuilder();

        
        foreach (var storage in this.storages.OrderByDescending(se => se.Products.Sum(sex => sex.Price)))
        {
            sb.AppendLine($"{storage.Name}:");
            sb.AppendLine($"Storage worth: ${storage.Products.Sum(se=>se.Price):f2}");
        }
        return sb.ToString().Trim();
    }

}

