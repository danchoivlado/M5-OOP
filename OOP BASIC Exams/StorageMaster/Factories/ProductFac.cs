using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class  ProductFac
{
    public static Product CreatProduct(string type ,double price)
    {
        switch (type)
        {
            case "Gpu":
                return new Gpu(price);
            case "HardDrive":
                return new HardDrive(price);
            case "Ram":
                return new Ram(price);
            case "SolidStateDrive":
                return new SolidStateDrive(price);
            default:
                throw new InvalidOperationException("Invalid product type!");
        }
    }
}

