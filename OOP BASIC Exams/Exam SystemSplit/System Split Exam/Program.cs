using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
    public static class Console
    {
        public static void WriteLine(object text)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(text.ToString());
            System.Console.ResetColor();
        }

        public static void Write(object text)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(text.ToString());
            System.Console.ResetColor();
        }

        public static string ReadLine()
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            return System.Console.ReadLine();
        }
    }

