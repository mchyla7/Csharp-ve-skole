using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole
{
    class Chyla
    {
        // Program načte jednu hodnotu
        // Poté zobrazí, zda se jední o text nebo o číslo.
        // Program načte druhou hodnotu
        // Poté zobrazí jestli se jedná o text nebo o číslo
        // Pokud jsou obě hodnoty číselné tak zobrazí volbu:
        // 1. Vypsat kladné hodnoty, 2. Nejprve vypsat menší pak větší

        public static void chylovoVypracovani()
        {
            float h1;
            float h2;
            Console.WriteLine("Zadejte hodnotu 1 : ");
            if (!float.TryParse(Console.ReadLine(), out h1))
            {
                Console.WriteLine("Zadal jste text");
            }
            else
            {
                Console.WriteLine("Zadal jste číslo");
            }
            Console.WriteLine("Zadejte hodnotu 2 : ");
            if (!float.TryParse(Console.ReadLine(), out h2))
            {
                Console.WriteLine("Zadal jste text");
            }
            else
            {
                Console.WriteLine("Zadal jste číslo");
            }
            float otazka;
            if (float.TryParse(Console.ReadLine(), out otazka))
            {
                Console.WriteLine("1. Vypsat kladné hodnoty, 2. Nejprve vypsat menší pak větší");
                Console.ReadLine();
                if (otazka == 1)
                {
                    if (h1 > 0)
                    {
                        Console.WriteLine(h1);
                        Console.ReadLine();
                    }
                    if (h2 > 0)
                    {
                        Console.WriteLine(h2);
                        Console.ReadLine();
                    }
                }
                else if (otazka == 2)
                {
                    if (h1 < h2)
                    {
                        Console.WriteLine("{0} < {1}", h1, h2);
                    }
                    else
                    {
                        Console.WriteLine("{0} > {1}", h1, h2);
                    }
                }
            }

        }

    }
}