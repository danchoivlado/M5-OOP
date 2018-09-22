using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaw.Core
{
    public class Engine
    {
        private CommandCenter cm;
        public Engine()
        {
            this.cm = new CommandCenter();
        }
        public void Run()
        {

            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] {'|',' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "RegisterCastrationCenter":
                        cm.RegisterCastrationCenter(command);
                        break;
                    case "SendForCastration":
                        cm.SendForCastration(command);
                        break;
                    case "Castrate":
                        cm.Castrate(command);
                        break;
                    case "CastrationStatistics":
                        Console.WriteLine(cm.CastrationStatistics());
                        break;
                    case "RegisterCleansingCenter":
                        cm.RegisterCleansingCenter(command);
                        break;
                    case "RegisterAdoptionCenter":
                        cm.RegisterAdoptionCenter(command);
                        break;
                    case "RegisterDog":
                        cm.RegisterDog(command);
                        break;
                    case "RegisterCat":
                        cm.RegisterCat(command);
                        break;
                    case "SendForCleansing":
                        cm.SendForCleansing(command);
                        break;
                    case "Cleanse":
                        cm.Cleanse(command);
                        break;
                    case "Adopt":
                        cm.Adopt(command);
                        break;
                    case "Paw":
                         Console.WriteLine(cm.PawPawPawah());
                        return;
                    default:
                        Console.WriteLine("Diddng recognise command");
                        break;
                }
            }
        }
    }
}
