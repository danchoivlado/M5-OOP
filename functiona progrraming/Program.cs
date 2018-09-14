using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiona_progrraming
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            nums = nums.Select(x => x * 20).ToArray();
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
