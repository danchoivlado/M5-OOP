using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Product
    {
        private double price;
        public double Weight { get;protected set; }

        protected Product(double Price, double Weight)
        {
            this.Price = Price;
            this.Weight = Weight;
        }

        public double Price
        {
            get { return price; }
            protected set
            {
                if (value < 0) throw new InvalidOperationException("Price cannot be negative!");
                price = value;
            }
        }

    }

