using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private DungeonMaster cm;
        public Engine()
        {
            cm = new DungeonMaster();
        }
        public void Run()
        {
            while (cm.IsGameOver() == false)
            {
                string[] line = Console.ReadLine().Split().ToArray();

                try
                {
                    Console.WriteLine(ProcesCommand(line));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"ArgumentException: {ex.Message}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"InvalidOperationException: {ex.Message}");
                }
            }
            Console.WriteLine(cm.GetStats());
        }

        public string ProcesCommand(string[] arr)
        {
            switch (arr[0])
            {
                case "JoinParty":
                    return cm.JoinParty(arr);
                case "AddItemToPool":
                    return cm.AddItemToPool(arr);
                case "PickUpItem":
                    return cm.PickUpItem(arr);
                case "UseItem":
                    return cm.UseItem(arr);
                case "UseItemOn":
                    return cm.UseItemOn(arr);
                case "GiveCharacterItem":
                    return cm.GiveCharacterItem(arr);
                case "GetStats":
                    return cm.GetStats();
                case "Attack":
                    return cm.Attack(arr);
                case "Heal":
                    return cm.Heal(arr);
                case "EndTurn":
                    return cm.EndTurn(arr);

                default:
                    throw new ArgumentNullException("NE VLEZE");
            }
        }

    }
}
