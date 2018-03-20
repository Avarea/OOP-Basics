using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Models.Bags
{
    public abstract class Bag
    {
        private int load;

        protected Bag(int capacity)
        {
            this.Capacity = 100;
            this.Items = new List<Item>();
        }

        public int Capacity { get; protected set; }
        public List<Item> Items { get;}

        public int Load
        {
            get { return load; }
            set { load = value + this.Items.Sum(e => e.Weight); }
        }

        public void AddItem(Item item)
        {
            if (item.Weight + this.Load > this.Capacity)
            {
                throw new InvalidOperationException(OutputMessages.NotEnoughSpace);
            }
            this.Items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.Capacity == 0)
            {
                throw new InvalidOperationException(OutputMessages.BagIsEmpty);
            }

            foreach (var item in Items)
            {
                bool isPresent = item.GetType().Name == name;
                if (isPresent)
                {
                    Items.Remove(item);
                    return item;
                }
            }
            throw new ArgumentException(string.Format(OutputMessages.ItemNotExisting), name);
        }
    }
}
