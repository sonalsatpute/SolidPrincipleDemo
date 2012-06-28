using System;

namespace SolidPrincipleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new TabloidReport();
            report.Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Beep();
            Console.WriteLine("\nPress any key to exit.... ... .. .");
            Console.ReadLine();
        }
    }
}
