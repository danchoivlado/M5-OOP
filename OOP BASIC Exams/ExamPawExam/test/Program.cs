using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(se=>int.Parse(se)).ToList();
            var t = arr.RemoveAt(2);
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
