using DungeonsAndCodeWizards.Entities.Characters;
using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Bags
{
    class PoisonPotion : Item
    {
        public PoisonPotion() : base(5)
        {
        }
        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health -= 20;
            Item.IsDead(character);
        }
    }
}
