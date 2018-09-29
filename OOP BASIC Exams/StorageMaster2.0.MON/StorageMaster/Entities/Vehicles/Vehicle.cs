using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Products;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        public int Capacity { get; }
        private readonly List<Product> trunk; //TODO
        public bool IsFull => this.trunk.Sum(se => se.Weight) >= this.Capacity == true;
        public bool IsEmpty => this.trunk.Count == 0 == true;

        public IReadOnlyCollection<Product> Trunk
        {
            get { return this.trunk; }
        }

        protected Vehicle(int capacity)
        {
            this.trunk = new List<Product>();
            this.Capacity = capacity;
        }

        public void LoadProduct(Product product)
        {
            if (this.IsFull) throw new InvalidOperationException("Vehicle is full!");
            this.trunk.Add(product);
        }
        public Product Unload()
        {
            if (this.IsEmpty) throw new InvalidOperationException("No products left in vehicle!");
            Product pr = this.trunk.Last();
            this.trunk.Remove(this.trunk.Last());
            return pr;
        }
    }
}
