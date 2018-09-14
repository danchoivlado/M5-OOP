using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Engine
    {
        private DraftManager draft;
        public Engine()
        {
            this.draft = new DraftManager();
        }
        public void Run()
        {
            while (true)
            {
                
                List<string> command = Console.ReadLine().Split().ToList();
                switch (command[0])
                {
                    case "RegisterHarvester":
                        Console.WriteLine(draft.RegisterHarvester(command.Skip(1).ToList()));
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(draft.RegisterProvider(command.Skip(1).ToList()));
                        break;
                    case "Day":
                        Console.WriteLine(draft.Day());
                        break;
                    case "Mode":
                        Console.WriteLine(draft.Mode(command.Skip(1).ToList()));
                        break;
                    case "Check":
                        Console.WriteLine(draft.Check(command.Skip(1).ToList()));
                        break;
                    case "Shutdown":
                        Console.WriteLine(draft.ShutDown());
                        return;
                    default:
                        Console.WriteLine("somehtingWrong");
                        break;
                }
            }



        }
    }

