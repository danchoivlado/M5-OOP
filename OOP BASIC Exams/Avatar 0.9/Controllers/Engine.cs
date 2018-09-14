using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Engine
    {
        private NationsBuilder nationsBuilder;

        public Engine()
        {
            this.nationsBuilder = new NationsBuilder();
        }

       public void Run()
        {
            while (true)
            {
                var comand = Console.ReadLine().Split().ToList();
                switch (comand[0])
                {
                    case "Bender":
                        nationsBuilder.AssignBender(comand.Skip(1).ToList());
                        break;
                    case "Monument":
                        nationsBuilder.AssignMonument(comand.Skip(1).ToList());
                        break;
                    case "Status":
                        Console.WriteLine(nationsBuilder.GetStatus(comand[1]));
                        break;
                    case "War":
                        nationsBuilder.IssueWar(comand[1]);
                        break;
                    case "Quit":
                        Console.WriteLine(nationsBuilder.GetWarsRecord());
                        return;
                }
            }
        }
    }
    

