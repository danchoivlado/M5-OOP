using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    public abstract class Character
    {
        private string name;
        public double BaseHealth { get; }
        private double health;
        public double BaseArmor { get; }
        private double armor;
        public double AbilityPoints { get; }
        public Bag Bag { get;  }
        public Faction Faction ;
        public bool IsAlive { get; set; } //Def True
        public virtual double RestHealMultiplier  { get;private set; }

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;

            this.BaseHealth = health;
            this.Health = health;

            this.BaseArmor = armor;
            this.Armor = armor;

            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.RestHealMultiplier = 0.2;
            this.IsAlive = true;
        }

        public void TakeDamage(double hitPoints)
        {
            Item.ValidateChar(this);
            double Cur = Math.Abs(this.armor - hitPoints);
            this.armor=Math.Max(this.armor - hitPoints, 0);
            if (this.armor == 0) this.Health -= Cur;
            Item.IsDead(this);
        }
        public void Rest()
        {
            Item.ValidateChar(this);
            this.Health += (this.BaseHealth * this.RestHealMultiplier);
        }

        public void UseItem(Item item)
        {
            Item.ValidateChar(this);
            item.AffectCharacter(this);
            Item.IsDead(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            Item.ValidateDoubleChar(this, character);
            item.AffectCharacter(character);
            Item.IsDead(character);
        }
        public void GiveCharacterItem(Item item, Character character)
        {
            Item.ValidateDoubleChar(this, character);
            character.Bag.AddItem(item);
           // this.Bag.RemoveItem(item);
        }
        public void ReceiveItem(Item item)
        {
            Item.ValidateChar(this);
            this.Bag.AddItem(item);
        }
        public double Armor
        {
            get { return armor; }
             set
            {
                var c = Math.Max(0, value);
                armor = Math.Min(c, this.BaseArmor);
            }
        }
        public double Health
        {
            get { return health; }
            set
            {
                var c = Math.Max(0, value);
                health = Math.Min(c, this.BaseHealth);
            }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be null or whitespace!");
                name = value;
            }
        }
        
    }
    public enum Faction
    {
        CSharp, Java
    }

}
