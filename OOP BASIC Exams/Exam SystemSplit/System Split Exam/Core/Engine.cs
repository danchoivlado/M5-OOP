using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Engine
    {
        public Engine()
        {

        }


        public void Run()
        {
            Controller cm = new Controller();

            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] {'(',')',' ',','},StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Dump":
                        cm.DumpTo(command);
                            break;
                    case "Restore":
                        cm.Restore(command);
                        break;
                    case "Destroy":
                        cm.Destroy(command);
                        break;
                    case "DumpAnalyze":
                        Console.WriteLine(Dump.DumpAnalyze());
                        break;
                    case "RegisterPowerHardware":
                        cm.RegisterPowerHardware(command);
                        break;
                    case "RegisterHeavyHardware":
                        cm.RegisterHeavyHardware(command);
                        break;
                    case "RegisterExpressSoftware":
                        cm.RegisterExpressSoftware(command);
                        break;
                    case "RegisterLightSoftware":
                        cm.RegisterLightSoftware(command);
                        break;
                    case "ReleaseSoftwareComponent":
                        cm.ReleaseSoftwareComponent(command);
                        break;
                    case "Analyze":
                        Console.WriteLine(cm.Analyze());
                        break;
                    case "System":
                        Console.WriteLine(cm.SystemSplit());
                        return;
                    default:
                        break;
                }
            }
        }
    }

