using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test05._023
{
    class Chyla
    {
        // Skupina A
        // Program se zeptá na počet čísel
        // Pokud nebyla zadána celočíselná hodnota, program to upozorní a znova se zeptá
        // Po zadání hodnoty program vygeneruje daný počet čísel v intervalu -100 až 100 a vloží je do pole
        // Program potom zobrazí nabídku: 1. Výpis hodnot seřazených vzestupně, 2. Maximální hodnota a počet kladných čísel, 3. Konec

        public static void chyla()
        {
            Random random = new Random();
            Console.WriteLine("Zadej počet generovaných čísel: ");
            int n = int.Parse(Console.ReadLine());
            int[] Pole = new int[n];

            for (int i = 0; i < n; i++)
                Pole[i] = random.Next(-100, 100);


            while (true)
            {
                Console.WriteLine("1. Výpis hodnot seřazených vzestupně, 2. Maximální hodnota a počet kladných čísel, 3. Konec");
                int odpoved = int.Parse(Console.ReadLine());

                if (odpoved == 1)
                {
                    Array.Sort(Pole);
                    Console.WriteLine("\nSeřazené pole vzestupně");
                    foreach (int i in Pole)
                        Console.WriteLine(i);
                }
                else if (odpoved == 2)
                {
                    int max = Pole.Max();
                    int pocet = Pole.Count(x => x > 0);
                    Console.WriteLine("Maximální hodnota: {0}", max);
                    Console.WriteLine("Počet kladných čísel: {0}", pocet);
                }
                else if (odpoved == 3)
                {
                    break;
                }
            }
        }
    }
}
