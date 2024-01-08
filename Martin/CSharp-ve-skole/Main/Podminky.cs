using System;

namespace CSharp_ve_skole
{
    class Podmínky
    {
        public static void Podminka1()
        {
            Console.Write("Zadejte hodnotu: ");
            float a = float.Parse(Console.ReadLine());
            if (a > 0)
            {//Pokud je v závorce true, pak se provede tento blok
                Console.WriteLine("Kladné číslo");
                Console.WriteLine("Je větší > 0");
            }
            else
            {
                Console.WriteLine("Nekladné číslo");
                Console.WriteLine("Je menší než > 0");
            }
            Console.ReadLine();
        }

        public static void Podminka2()
        {
            Console.Write("Zadejte číslo: ");
            float a = float.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Kladné číslo");
                Console.ReadLine();
            }
            else if (a == 0)
            {
                Console.WriteLine("Nula");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Záporné");
                Console.ReadLine();
            }
        }


        //Načtete 2 čísla a následně je vypište vzestupně

        public static void Podminka3()
        {
            Console.Write("Zadejte první číslo: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadejte druhé číslo: ");
            float h2 = float.Parse(Console.ReadLine());
            if (h1 > h2)
                Console.WriteLine("{0} > {1}", h1, h2);
            else
                Console.WriteLine("{0} > {1}", h2, h1);
            Console.ReadLine();
        }


        //Vytvořte metodu, která načte 2 čísla, poté zobrazí telaci mezi čísly
        //např. vstup: 1 , 2 Výstup: "1 < 2"
        //např. vstup: 3 , 3 Výstup: "3 = 3"
        //např. vstup: 3 , 1 Výstup: "3 < 1"

        public static void Podminka4()
        {
            Console.Write("Zadejte první číslo: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadejte druhé číslo: ");
            float h2 = float.Parse(Console.ReadLine());
            if (h1 > h2)
                Console.WriteLine("{0} > {1}", h1, h2);
            else
                Console.WriteLine("{0} > {1}", h2, h1);
        }


        // Vytvořte program, který načte dvě čísla a nasledně zobrazí nabídku
        // 1. Zobrazí maximum (největší číslo)
        // 2. Zobrazí min
        // 3. Porovná čísla (vypíše například 3>2)
        // 4. Průměrná hodnota
        // Pokud zadáte špatnou volbu, program to oznámí

        public static void MinMaxPorovPrumer()
        {
            Console.Write("Zadej první číslo: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            float h2 = float.Parse(Console.ReadLine());

            float max = Math.Max(h1, h2);
            float min = Math.Min(h1, h2);

            Console.WriteLine("1. Maximum, 2. Minimum, 3. Porovnání, 4. Průměrná hodnota");
            string volba = Console.ReadLine();

            if (volba == "1")
                Console.WriteLine("Maximum je: {0}", max);
            else if (volba == "2")
                Console.WriteLine("Minimum je: {0}", min);
            else if (volba == "3")
                Console.WriteLine("{0} > {1}", h1, h2);
            else if (volba == "4")
                Console.WriteLine("Průměrná hodnota je: {0}", (h1 + h2) / 2);
            else
                Console.WriteLine("Špatná volba");

            Console.ReadLine();
        }
    }
}
