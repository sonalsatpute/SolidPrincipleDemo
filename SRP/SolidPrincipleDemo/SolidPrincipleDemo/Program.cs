using System;

namespace SolidPrincipleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            report.Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPress any key to exit.... ... .. .");
            Console.ReadLine();
        }
    }
}
