using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var engine = new Engine();
            int i = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            engine.CreateTower(i, l);
            engine.Run();
        }
    }
}

