using System;

namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen? ");
            int dagar = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många kilometer ska du köra? ");
            int km = int.Parse(Console.ReadLine());

            int kostnad = 300 + km * 1 + (dagar - 1) * 500;

            Console.WriteLine($"Totala hyran blir {kostnad} kr.");

            Console.ReadKey();
        }
    }
}
