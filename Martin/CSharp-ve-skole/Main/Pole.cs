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

    }
}
