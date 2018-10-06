using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizards.Entities.Bags;

namespace DungeonsAndCodeWizards.Entities.Factories
{
    public static class ItemFac
    {
        public static Item Createitem(string[] arr)
        {
            string ItemName = arr[1];
            switch (ItemName)
            {
                case "ArmorRepairKit":
                    return new ArmorRepairKit();
                case "HealthPotion":
                    return new HealthPotion();
                case "PoisonPotion":
                    return new PoisonPotion();
                default:
                    throw new ArgumentException($"\"Invalid item \"{ItemName}\"!");
            }
        }
    }
}
