using System;
using DungeonsAndCodeWizards.Models.Items;

namespace DungeonsAndCodeWizards.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string itemType)
        {
            Item item = null;
            switch (itemType)
            {
                case "HealthPotion":
                    return item = new HealthPotion();
                case "PoisonPotion":
                    return item = new PoisonPotion();
                case "ArmorRepairKit":
                    return item = new ArmorRepairKit();
                    default:
                    throw new ArgumentException(string.Format(OutputMessages.InvalidItemType), itemType);
            }
        }
    }
}
