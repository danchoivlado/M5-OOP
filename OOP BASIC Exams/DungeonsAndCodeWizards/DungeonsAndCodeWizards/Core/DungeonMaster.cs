using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizards.Entities.Factories;
using DungeonsAndCodeWizards.Entities.Characters;
using DungeonsAndCodeWizards.Entities.Items;
using DungeonsAndCodeWizards.Entities.Contracts;

namespace DungeonsAndCodeWizards.Core
{
    class DungeonMaster
    {
        private List<Character> charactersPool;
        private List<Item> itemsPool;
        private int lastSurvivorRounds;

        public DungeonMaster()
        {
            this.charactersPool = new List<Character>();
            this.itemsPool = new List<Item>();
        }
        public string JoinParty(string[] args)
        {
            Character Cur = CharacterFac.CreateCharacter(args);
            this.charactersPool.Add(Cur);
            return $"{Cur.Name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            Item cur = ItemFac.Createitem(args);
            this.itemsPool.Add(cur);
            return $"{cur.GetType().Name} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[1];
           

            Character Curcharacter = this.charactersPool.FirstOrDefault(se => se.Name == characterName);
            Item Curitem = this.itemsPool.LastOrDefault();
            if (Curcharacter == null) throw new ArgumentException($"Character {characterName} not found!");
            if (Curitem == null) throw new InvalidOperationException("No items left in pool!");
            Curcharacter.ReceiveItem(Curitem);
            this.itemsPool.Remove(itemsPool.Last());
            return $"{characterName} picked up {Curitem.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[1];
            string itemName = args[2];

            Character Cur = this.charactersPool.FirstOrDefault(se => se.Name == characterName);
            if (Cur == null) throw new ArgumentException($"Character {characterName} not found!");
            Cur.UseItem(Cur.Bag.GetItem(itemName));
            return $"{Cur.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[1];
            string receiverName = args[2];
            string itemName = args[3];

            Character giver = this.charactersPool.FirstOrDefault(se => se.Name == giverName);
            Character receiver = this.charactersPool.FirstOrDefault(se => se.Name == receiverName);
            Item item = giver.Bag.GetItem(itemName);

            if (giver == null) throw new ArgumentException($"Character {giverName} not found!");
            if (receiver == null) throw new ArgumentException($"Character {receiverName} not found!");

            giver.UseItemOn(item, receiver);

            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[1];
            string receiverName = args[2];
            string itemName = args[3];

            Character giver = this.charactersPool.FirstOrDefault(se => se.Name == giverName);
            Character receiver = this.charactersPool.FirstOrDefault(se => se.Name == receiverName);
            Item item = giver.Bag.GetItem(itemName);

            if (giver == null) throw new ArgumentException($"Character {giverName} not found!");
            if (receiver == null) throw new ArgumentException($"Character {receiverName} not found!");

            giver.GiveCharacterItem(item, receiver);
            
            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Final stats:");
            foreach (var character in this.charactersPool.OrderByDescending(a=>a.IsAlive==true).ThenBy(s=>s.Health))
            {
                string str;
                if (character.IsAlive == true) str = "Alive";
                else str = "Dead";
                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {str}");
            }
            return sb.ToString().Trim();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[1];
            string receiverName = args[2];

            var attacker =(IAttackable) this.charactersPool.FirstOrDefault(se => se.Name == attackerName);
            Character receiver =this.charactersPool.FirstOrDefault(se => se.Name == receiverName);

            if(attacker==null) throw new ArgumentException($"Character {attackerName} not found!");
            if(receiver == null) throw new ArgumentException($"Character {receiverName} not found!");

            try
            {
                attacker.Attack(receiver);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"{attackerName} cannot attack!");
            }
            catch(InvalidOperationException)
            {
                throw new ArgumentException($"{attackerName} cannot attack!");
            }
            var sb = new StringBuilder();
            Character casted = (Character)attacker;
            sb.Append($"{attackerName} attacks {receiverName} for {casted.AbilityPoints} hit points! ");
            sb.Append($"{receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and ");
            sb.Append($"{receiver.Armor}/{receiver.BaseArmor} AP left!");
            if (receiver.IsAlive == false)
            {
                sb.AppendLine();
                sb.AppendLine($"{receiver.Name} is dead!");
            }
            return sb.ToString().Trim();
        }

        public string Heal(string[] args)
        {
            string healerName = args[1];
            string healingReceiverName = args[2];

            var attacker = (IHealable)this.charactersPool.FirstOrDefault(se => se.Name == healerName);
            Character receiver = this.charactersPool.FirstOrDefault(se => se.Name == healingReceiverName);

            if (attacker == null) throw new ArgumentException($"Character {healerName} not found!");
            if (receiver == null) throw new ArgumentException($"Character {healingReceiverName} not found!");

            try
            {
                attacker.Heal(receiver);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }
            catch (InvalidOperationException)
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }
            var sb = new StringBuilder();
            Character casted = (Character)attacker;
            sb.AppendLine
                ($"{casted.Name} heals {receiver.Name} for {casted.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!");
            return sb.ToString().Trim();
        }

        public string EndTurn(string[] args)
        {
            var sb = new StringBuilder();
            var sorted = this.charactersPool.Where(se => se.IsAlive == true);
            foreach (var character in sorted)
            {
                double bef = character.Health;
                character.Rest();
                sb.AppendLine($"{character.Name} rests ({bef} => {character.Health})");
            }
            if (this.charactersPool.Where(se=>se.IsAlive==true).Count() <= 1)
            {
                this.lastSurvivorRounds++;
            }
            return sb.ToString().Trim();
        }

        public bool IsGameOver()
        {
            var oneOrZeroSurvivorsLeft = this.charactersPool.Count(c => c.IsAlive) <= 1;
            var lastSurviverSurvivedTooLong = this.lastSurvivorRounds > 1;

            return oneOrZeroSurvivorsLeft && lastSurviverSurvivedTooLong;
        }

    }
}
