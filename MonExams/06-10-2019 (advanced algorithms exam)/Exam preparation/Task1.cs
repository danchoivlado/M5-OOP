using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonExam_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            var solutions = new List<int>();
			
			//Greedy Algorithm
            while (true)
            {
                if (days - 5 <= 0)
                {
                    if (days - 5 == 0)
                        solutions.Add(Math.Abs(1));
                    else
                        solutions.Add(Math.Abs(days));

                    break;
                }
                else
                {
                    solutions.Add(1);
                    days -= 5;
                }
            }

            Console.WriteLine(solutions.Sum());
        }
    }
}