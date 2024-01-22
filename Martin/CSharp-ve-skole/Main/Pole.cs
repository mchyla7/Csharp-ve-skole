using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole
{
    class Pole
    {
        public static void PoleJedna()
        {
            Random random = new Random();
            // Vytvoření pole desetinných čísel o 10 prvních
            // Pole obsahuje prvky pole[0] až pole[9]
            float[] cisla = new float[10];

            // cisla.Lenght - vrací délku pole
            // Načtení náhodných čísel

            for (int i = 0; i < cisla.Length; i++)
                cisla[i] = random.Next(-100, 100);

            // Výpis hodnot pomocí cyklu for
            // pole.Lenght - délka pole

            for (int i = 0; i < cisla.Length; i++)
                Console.WriteLine(cisla[i]);
            
            // Výpis hodnot pomocí cyklu foreach
            // Cyklus nelze použít pro úpravu hodnot poli

            foreach (float cislo in cisla)
                Console.WriteLine(cislo);
        }

        // Vytvořenáí a naplnění pole hodnotami z kodu

        public static void PoleSVlastnimSeznamem()
        {
            int[] cislaPole = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < cislaPole.Length; i++)
                Console.WriteLine(cislaPole[i]); // Zobrazí obsah pole
            Console.ReadLine();
        }

        // Vytvořte pole, které bude obsahovat názvy ročních období
        // Prvky pole vypište

        public static void PoleSObdobim()
        {
            string[] obdobiPole = { "Jaro", "Léto", "Podzim", "Zima" };

            foreach (string Pole in obdobiPole)
                Console.WriteLine(Pole);
            
            Console.ReadLine();
        }

        // Vytvořte program, který 10x náhodně zobrazí ročního období

        public static void RandomPoleSObdobim()
        {
            Random random = new Random();
            string[] obdobiPole = { "Jaro", "Léto", "Podzim", "Zima" };

            for (int i = 0; i < 10; i++)
                Console.WriteLine(obdobiPole[random.Next(4)]);

            Console.ReadLine();
        }


        public static void NaceteniNahodnychCiselPole()
        { 
            int dolniHranice = -10000;
            int horniHranice = 10000;

            Console.WriteLine("Zadej počet generovaných čísel: ");
            int pocet = int.Parse(Console.ReadLine());
            int[] Pole = new int[pocet]; //deklarace pole
            Random generovaniCisla = new Random();

            for (int i = 0; i < Pole.Length; i++)
                Pole[i] = generovaniCisla.Next(dolniHranice, horniHranice + 1);

            foreach (int cislo in Pole)
                Console.WriteLine(cislo);

            Console.WriteLine("Maximální hodnota je {0}", Pole.Max());
            Console.WriteLine("Minimální hodnota je {0}", Pole.Min());
            Console.WriteLine("Průměrná hodnota je {0}", Pole.Average());
            
            // Program zobrazí nadprůměrné hodnoty



            Console.ReadLine();
        }

        // Program generuje n čísel v intervalu(-100,100)
        // Na n se program zeptá
        // Záporné hodnoty program uloží do pole1 a kladné do pole2
        // Poté program nejprve vypíše hodnoty z pole1 a potom z pole2

        public static void MinusStoAzPlusSto()
        {
            Random Random = new Random();
            Console.WriteLine("Zadej počet generovaných čísel: ");
            int n = int.Parse(Console.ReadLine());
            int[] Pole1 = new int[n];
            int[] Pole2 = new int[n];
            int ik = 0;
            int iz = 0;

            for (int i = 0; i <= n; i++)
            {
                int cislo = Random.Next(-100, 100);
                if (cislo > 0)
                {
                    Pole1[ik] = cislo;
                    ik++;
                }
                if (cislo < 0)
                {
                    Pole1[iz] = cislo;
                    iz++;
                }
            }

            Console.WriteLine("Kladné hodnoty");
            for (int i = 0; i <= ik-1; i++)
                Console.Write(Pole1[i] + ";");

            Console.WriteLine("\n\nZáporné hodnoty");
            for (int i = 0; i <= iz-1; i++)
                Console.Write(Pole2[i] + ";");

            Console.ReadLine();
        }


    }
}