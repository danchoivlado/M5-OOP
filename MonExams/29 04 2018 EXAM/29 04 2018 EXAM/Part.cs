using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_04_2018_EXAM
{
    class Part
    {
        private string name;
        private double price;

        public Part(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Part(string name)
        {
            this.Name = name;
            Price = 25;
        }
        public override string ToString()
        {
            return $"-> {this.name} - {this.price:f2}";
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value<0.00)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                price = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<5)
                {
                    throw new ArgumentException("Invalid part name!");
                }
                name = value;
            }
        }
    }
}
