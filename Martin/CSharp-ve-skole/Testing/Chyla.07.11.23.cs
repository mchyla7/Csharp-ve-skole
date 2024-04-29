using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace testChyla
{
    class Chyla
    {
        public static void test()
        //  Vytvořte program, který načte dvě číselné hodnoty. 
        //  Dále  nabídne možnosti: 1. maximální hodnota, 2. průměrná hodnota, 3. součet druhých mocnin obou čísel. 
        //  Poté zvolenou možnost program zobrazí
        {
            Console.Write("Zadej první číslo: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            float h2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Zvolte možnost: 1. maximální hodnota, 2. průměrná hodnota, 3. součet druhých mocnin obou čísel");
            float volba = float.Parse(Console.ReadLine());

            if (volba == 1)
            {
                Console.WriteLine("Maximální hodnota je: {0}", Math.Max(h1, h2));
            }
            else if (volba == 2)
            {
                Console.WriteLine("Průměrná hodnota je: {0}", (h1 + h2) / 2);
            }
            else if (volba == 3)
            {
                Console.WriteLine("Součet mocnin obou čísel je: {0} ", (Math.Pow(h1, 2) + Math.Pow(h2, 2)));
            }
            else
            {
                Console.WriteLine("Neplatná volba");
            }
            Console.ReadLine();

        }
    }
}
