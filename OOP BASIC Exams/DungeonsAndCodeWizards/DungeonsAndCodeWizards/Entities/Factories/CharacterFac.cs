using DungeonsAndCodeWizards.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards.Entities.Factories
{
    public static class CharacterFac
    {
        public static Character CreateCharacter(string[] arr)
        {
            string faction = arr[1];
            string characterType = arr[2];
            string name = arr[3];
            if(!Enum.TryParse<Faction>(faction,out var parsed))
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }

            switch (characterType)
            {
                case "Warrior":
                    return new Warrior(name, parsed);
                case "Cleric":
                    return new Cleric(name, parsed);
                default:
                    throw new ArgumentException($"Invalid character type \"{ characterType }\"!");
            }
        }

    }
}
