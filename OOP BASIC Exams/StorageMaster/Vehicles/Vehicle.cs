
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Vehicle
    {
        public int Capacity { get;private set; }
        public readonly List<Product> Trunk; //TODO

        protected Vehicle(int Capacity)
        {
            this.Capacity = Capacity;
            this.Trunk = new List<Product>();
        }

        public bool IsFull()
        {
            double WeightSum = Trunk.Sum(wei => wei.Weight);
            return WeightSum >= Capacity ? true : false;
        }

        public bool IsEmpty()
        {
            return Trunk.Count == 0 ? true : false; 
        }

        public void LoadProduct(Product product)
        {
            if (IsFull()) throw new InvalidOperationException("Vehicle is full!");
            this.Trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("No products left in vehicle!");
            Product LastProduct = this.Trunk.Last();
            this.Trunk.Remove(LastProduct);
            return LastProduct;
        }
    }

