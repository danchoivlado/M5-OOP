using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public class Engine
    {
        RaceTower cm;
        public Engine()
        {
            this.cm = new RaceTower();
        }
        public void CreateTower(int i, int r)
        {
            cm.SetTrackInfo(i, r);
        }
        public void Run()
        {
            List<string> line = Console.ReadLine().Split().ToList();
            while (true)
            {

                switch (line[0])
                {
                    case "RegisterDriver":
                        cm.RegisterDriver(line.Skip(1).ToList());
                        break;
                    case "Leaderboard":

                        Console.WriteLine(cm.GetLeaderboard());
                        break;
                    case "CompleteLaps":
                        try
                        {

                            var get = cm.CompleteLaps(line.Skip(1).ToList());
                            if (!String.IsNullOrWhiteSpace(get))
                                Console.WriteLine(get);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        break;
                    case "Box":
                        cm.DriverBoxes(line.Skip(1).ToList());
                        break;

                    default:
                        break;

                }
                if (cm.IsFinished == true)
                {
                    cm.Finich();
                    break;
                }
                line = Console.ReadLine().Split().ToList();
            }

        }
    }
}
