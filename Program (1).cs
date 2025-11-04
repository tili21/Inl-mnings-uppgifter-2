using System;

namespace Uppgift_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur långt hoppade Elin (meter)? ");
            int elin = int.Parse(Console.ReadLine());

            Console.Write("Hur långt hoppade Alma (meter)? ");
            int alma = int.Parse(Console.ReadLine());

            int skillnad = elin - alma;

            Console.WriteLine($"Elin hoppade {skillnad} meter längre än Alma.");

            
            Console.ReadKey();
        }
    }
}
