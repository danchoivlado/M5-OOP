using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Contracts;
using DungeonsAndCodeWizards.Entities.Items;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction) : base(name, 100, 50, 40, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            Item.ValidateDoubleChar(this, character);
            Item.AttackValidation(this, character);
            character.TakeDamage(this.AbilityPoints);
            Item.IsDead(character);
        }
    }
}
