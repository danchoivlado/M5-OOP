using DungeonsAndCodeWizards.Entities.Characters;
using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Bags
{
    public abstract class Bag
    {
        public int Capacity { get; private set; } //def 100
        private int Load => this.items.Sum(se => se.Weight);
        private readonly List<Item> items;

        public  IReadOnlyCollection<Item> Items
        {
            get { return this.items; }
        }

        
        
        //public void RemoveItem(Item item)
        //{
        //    this.items.Remove(item);
        //}
        protected Bag(int capacity=100)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity) throw new InvalidOperationException("Bag is full!");
            this.items.Add(item);
        }
        public Item GetItem(string name)
        {
            if (this.items.Count == 0) throw new InvalidOperationException("Bag is empty!");
            if (!this.items.Any(se => se.GetType().Name == name)) throw new ArgumentException
                    ($"No item with name {name} in bag!");
            Item CurrItem = this.items.First(se => se.GetType().Name == name);
            this.items.Remove(CurrItem);
            return CurrItem;
        }
    }
}
