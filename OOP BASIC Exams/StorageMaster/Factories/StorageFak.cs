using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class StorageFak
{
    public static Storage CreateFac(string type ,string name)
    {
        switch (type)
        {
            case "AutomatedWarehouse":
                return new AutomatedWarehouse(name);
            case "DistributionCenter":
                return new DistributionCenter(name);
            case "Warehouse":
                return new Warehouse(name);
            default:
                throw new InvalidOperationException("Invalid storage type!");
        }
    }
}

