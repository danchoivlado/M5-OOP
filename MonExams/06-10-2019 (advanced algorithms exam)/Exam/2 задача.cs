using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        public static int[] arr;

        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            arr = line.Select(int.Parse).ToArray();

            Console.WriteLine(GCD(arr));
        }

        static int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return
                GCD(b, a % b);
        }
    }
}
