using DungeonsAndCodeWizards.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Items
{
    public abstract class Item
    {
        public int Weight { get; }

        protected Item(int weight)
        {
            this.Weight = weight;
        }

        public virtual void AffectCharacter(Character character)
        {
            ValidateChar(character);
        }

        public static void ValidateDoubleChar(Character character1,Character character2)
        {
            if(!character1.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
            if(!character2.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
        }
        public static void ValidateChar(Character character)
        {
            if (!character.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
        }
        public static void IsDead(Character character)
        {
            if (character.Health == 0) character.IsAlive = false;

        }
        public static void AttackValidation(Character character1,Character character2)
        {
            if (character1.Name == character2.Name) throw new InvalidOperationException("Cannot attack self!");
            if (character1.Faction == character2.Faction) 
                throw new ArgumentException($"Friendly fire!Both characters are from { character1.Faction.GetType().Name } faction!");
        }
        public static void HealValidation(Character character1, Character character2)
        {
            if (character1.Faction.GetType().Name != character2.Faction.GetType().Name)
                throw new InvalidOperationException("Cannot heal enemy character!");
            
        }
    }
}
