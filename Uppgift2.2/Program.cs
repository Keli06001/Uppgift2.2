using System;

namespace Uppgift2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin mätt i meter?");
            string meterText = Console.ReadLine();
            int meter = int.Parse(meterText);
            Console.WriteLine("Hur långt hoppade Alma mätt i meter?");
            string meteText = Console.ReadLine();
            int mete = int.Parse(meteText);
            int skillnad = meter - mete;
            Console.WriteLine("Elin hoppade " + skillnad + "m längre än Alma");

        }
    }
}
