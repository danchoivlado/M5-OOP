using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Contracts;
using DungeonsAndCodeWizards.Entities.Items;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction) : base(name, 50, 25, 40, new Backpack(), faction)
        {

        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            Item.ValidateDoubleChar(this, character);
            Item.HealValidation(this, character);
            character.Health += this.AbilityPoints;
        }
    }
}
