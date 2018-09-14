using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_04_2018_EXAM
{
    class Car
    {
        private string manufacturer;
        private string model;
        private double loadCapacity;
        private List<Part> parts;
        private double fuel;
        private static int odrdersCount;

        public Car(string manufacturer, string model, double loadCapacity)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.LoadCapacity = loadCapacity;
            parts = new List<Part>();
            fuel = 100;
            ordersCount++;
        }
        public void AddMultipleParts(List<Part> passedParts)
        {
            foreach (var par in passedParts)
            {
                parts.Add(par);
            }
        }
        public void RemovePartByName(string name)
        {
            foreach (var part in this.parts)
            {
                if (name == part.Name)
                {
                    parts.Remove(part);
                    break;
                }
            }
        }
        public void AddPart(Part part)
        {
            parts.Add(part);

        }
        public override string ToString()
        {
            if (parts.Count == 0)
            {
                return $"{this.model.ToUpper()} made by {this.manufacturer}\n" +
                       $"Available parts:\n" +

                       $"With total price of: {parts.Sum(ba => ba.Price):f2} lv.";
            }
            else
            {
                return $"{this.model.ToUpper()} made by {this.manufacturer}\n" +
                   $"Available parts:\n" +
                   $"{string.Join("\n", parts)}\n" +
                   $"With total price of: {parts.Sum(ba => ba.Price):f2} lv.";
            }



        }
        public double GetCarPrice()
        {
            return parts.Sum(ba => ba.Price);
        }
        public bool ContainsPart(string partName)
        {
            foreach (var part in parts)
            {
                if (part.Name == partName)
                {
                    return true;
                }
            }
            return false;
        }
        public void Drive(double distance)
        {
            var prove = this.fuel -= (loadCapacity * 0.2 * distance);
            if (prove < 0)
            {
                throw new ArgumentException("Drive not possible!");
            }
            else
            {
                this.fuel -= (loadCapacity * 0.2 * distance);

            }
        }
        public Part GetMostExpensivePart()
        {
            return parts.OrderByDescending(ba => ba.Price).First();
        }
        public List<Part> GetPartsWithPriceAbove(double price)
        {
            List<Part> be = parts.Where(ba => ba.Price > price).ToList();
            return be;
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {

                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid manufacturer name!");
                }
                manufacturer = value;

            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid model name!");
                }
                model = value;
            }
        }
        public double LoadCapacity
        {
            get { return loadCapacity; }
            set
            {
                if (value < 0.00)
                {
                    throw new ArgumentException("Invalid load capacity!");
                }
                loadCapacity = value;
            }
        }
        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public static int OrdersCount
        {
            get { return ordersCount; }
        }

        public List<Part> Parts
        {
            get { return parts; }
        }

    }
}
