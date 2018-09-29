using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Core;

namespace StorageMaster.Core
{
    class Engine
    {
        private StorageMaster cm;
        public Engine()
        {
            this.cm = new StorageMaster();
        }

        public void Run()
        {
            string[] command = Console.ReadLine().Split(new char[] {' ','(',')'},StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                try
                {
                    Console.WriteLine(RealiseCommand(command));
                    if (command[0] == "END") return;
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    
                }
                command = Console.ReadLine().Split();
                
            }



        }

        private string RealiseCommand(string[] arr)
        {
            switch (arr[0])
            {
                case "AddProduct":
                    return cm.AddProduct(arr[1], double.Parse(arr[2]));
                case "RegisterStorage":
                    return cm.RegisterStorage(arr[1], arr[2]);
                case "SelectVehicle":
                    return cm.SelectVehicle(arr[1], int.Parse(arr[2]));
                case "LoadVehicle":
                    return cm.LoadVehicle(arr.Skip(1));
                case "SendVehicleTo":
                    return cm.SendVehicleTo(arr[1],int.Parse(arr[2]), arr[3]);
                case "UnloadVehicle":
                    return cm.UnloadVehicle(arr[1],int.Parse(arr[2]));
                case "GetStorageStatus":
                    return cm.GetStorageStatus(arr[1]);
                case "END":
                    return cm.GetSummary();
                default:
                    throw new ArgumentException("Didn Realise Command");
            }
        }
    }
}
