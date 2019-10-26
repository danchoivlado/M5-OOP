using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_06_19_2019
{
    class Program
    {
        public static List<int> combos = new List<int>();
        public static int subCounter = 0;
        static void Main(string[] args)
        {
            string r = Console.ReadLine();

            int n = int.Parse(r);

            int[] arr = new int[n];

            Generate(n, arr, 0);
            Console.Write(combos.Count());
            Console.WriteLine();
        }

        static void Generate(int n,
                            int[] arr, int i)
        {
            if (subCounter!=n)
            {
                subCounter++;
            }

            if (i == n)
            {
                printIfPossible(arr, n);
                return;
            }
            
            arr[i] = 0;
            Generate(n, arr, i + 1);

            arr[i] = 1;
            Generate(n, arr, i + 1);
        }

        static void printIfPossible(int[] arr, int n)
        {
            var ps = arr;
            int counter = n;
            combos.Add(counter);
        }
    }


}



