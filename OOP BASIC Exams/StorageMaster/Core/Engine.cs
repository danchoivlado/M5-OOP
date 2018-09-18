using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Engine
{
    private StorageMaster StorageMaster;
    public Engine()
    {
        this.StorageMaster = new StorageMaster();
    }
    public void Run()
    {

        while (true)
        {
            var comand = Console.ReadLine().Split().ToArray();
            switch (comand[0])
            {
                case "AddProduct":
                    {
                        try
                        {
                            Console.WriteLine(this.StorageMaster.AddProduct(comand[1], double.Parse(comand[2])));
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                case "RegisterStorage":
                    {
                        try
                        {
                            Console.WriteLine(this.StorageMaster.RegisterStorage(comand[1], comand[2]));
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                case "SelectVehicle":
                    {
                        try
                        {
                            Console.WriteLine(this.StorageMaster.SelectVehicle(comand[1], int.Parse(comand[2])));
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                case "LoadVehicle":
                    {
                        try
                        {
                            Console.WriteLine(this.StorageMaster.LoadVehicle(comand.Skip(1)));
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                case "SendVehicleTo":
                    {
                        try
                        {
                            Console.WriteLine(this.StorageMaster.SendVehicleTo(comand[1], int.Parse(comand[2]), comand[3]));
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                case "UnloadVehicle":
                    {
                        try
                        {
                            Console.WriteLine((this.StorageMaster.UnloadVehicle(comand[1], int.Parse(comand[2]))));
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                case "GetStorageStatus":
                    {
                        try
                        {
                            Console.WriteLine(this.StorageMaster.GetStorageStatus(comand[1]));
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                default:
                    try
                    {
                        Console.WriteLine(this.StorageMaster.GetSummary());
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    return;
            }
        }
    }
}

