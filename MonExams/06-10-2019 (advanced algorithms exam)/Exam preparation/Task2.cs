using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonExam_Task_2
{
    class Program
    {
        public static int endSum;

        static void Main(string[] args)
        {
            while (true)
            {
                var nums = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                endSum = new Int32();
                Generate(nums[0], nums[1]);

                Console.WriteLine(endSum);
            }
        }

        private static void Generate(int m,int n)
        {
            if (n == 1)
            {
                endSum += m;
                return;
            }

            endSum += m;
            Generate(m, n - 1);
        }
    }
}