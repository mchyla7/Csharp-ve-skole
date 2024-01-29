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

        // Vytvoření a naplnění pole hodnotami z kodu

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
        
        // Program se zeptá na číslo dne v týdnu, následně zobrazí jeho název
        // Načítání bude ukončeno, pokud zadáte nečíselnou hodnotu

        public static void DnyVTydnu()
        {
            string[] dnyPole = { "Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle" };
            while (true)
            { 
            Console.WriteLine("Zadej den v týdnu: ");

            int cisloDne = 0;
            if(!int.TryParse(Console.ReadLine(),out cisloDne)) break;
            if (cisloDne > 0 && cisloDne > 8) Console.WriteLine(dnyPole[cisloDne - 1 ]);

            Console.WriteLine("Číslo musí být 1-7");
            }

        }

        // Program se zeptá na číslo měsíce v roce, následně zobrazí jeho název
        // Načítání bude ukončeno, pokud zadáte nečíselnou hodnotu

        public static void MesiceVRoce()
        {
            string[] MesicePole = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec"};
            while (true)
            {
                Console.WriteLine("Zadej měsíc v roce: ");

                int cisloMesice = 0;
                if (!int.TryParse(Console.ReadLine(), out cisloMesice)) break;
                if (cisloMesice > 0 && cisloMesice > 13) Console.WriteLine(MesicePole[cisloMesice - 1]);

                Console.WriteLine("Číslo musí být 1-12");
            }

        }

        // Program náhodně vygeneruje den a měsíc v jakémkoliv počtu

        public static void MesicADen()
        {
            string[] MesicePole = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
            string[] dnyPole = { "Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle" };

            Random random = new Random();

            for (int i = 0; i < 10; i++)
                Console.WriteLine(dnyPole[random.Next(6)] + " " + MesicePole[random.Next(11)]);
                Console.ReadLine();
        }

        // Program se zeptá na hodnotu N = počet hodnot
        // Program vyheneruje N čísel do pole, následně je vypíše a zobrazí
        // dále zobrazí průměrnou a minimální hodnotu

        public static void HodnotaN()
        {
            Random random = new Random();
            Console.WriteLine("Zadej počet generovaných čísel: ");
            int n = int.Parse(Console.ReadLine());
            int[] Pole = new int[n];

            for (int i = 0; i < n; i++)
                Pole[i] = random.Next();

            foreach (int i in Pole)
            Console.WriteLine(i);

            Console.WriteLine("Minimální hodnota je {0}", Pole.Min());
            Console.WriteLine("Průměrná hodnota je {0}", Pole.Average());
            Console.ReadLine();

            //  Seřazené pole

            Array.Sort(Pole);
            Console.WriteLine("\n\nSeřazené pole vzestupně");
            foreach (int i in Pole)
            Console.WriteLine(i);
            
            // Seřazené pole sestupně
            Console.WriteLine("\n\nSeřazené pole vzestupně");
            Array.Reverse(Pole); // Prvky pole se seřadí opačně
            foreach (int i in Pole)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        // Program vzgeneruje N čísel do pole, poté zobrazí volbu
        // 1. Výpis seřazený vzestupně
        // 2. Výpis seřazený sestupně
        // 3. Nejmenší hodnota (min), Největší hodnota (max), Průměrná hodnota
        // 4. Konec

        public static void KalkulackaN()
        {
            Random random = new Random();
            Console.WriteLine("Zadej počet generovaných čísel: ");
            int n = int.Parse(Console.ReadLine());
            int[] Pole = new int[n];

            for (int i = 0; i < n; i++)
                Pole[i] = random.Next();

            foreach (int i in Pole)
                Console.WriteLine(i);
            Console.WriteLine("1. Výpis seřazený vzestupně, 2. Výpis seřazený sestupně, 3. Nejmenší hodnota (min), Největší hodnota (max), Průměrná hodnota, 4. Konec");
            int odpoved = int.Parse(Console.ReadLine());
            while (true)
            {
                if (odpoved == 1)
                {
                    Array.Sort(Pole);
                    Console.WriteLine("\n\nSeřazené pole vzestupně");
                    foreach (int i in Pole) Console.WriteLine(i);
                }
                else if (odpoved == 2)
                {
                    Console.WriteLine("\n\nSeřazené pole vzestupně");
                    Array.Sort(Pole);
                    Array.Reverse(Pole);
                    foreach (int i in Pole)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                }
                else if (odpoved == 3)
                {
                    Console.WriteLine("Minimální hodnota je {0}", Pole.Min());
                    Console.WriteLine("Maximální hodnota je {0}", Pole.Max());
                    Console.WriteLine("Průměrná hodnota je {0}", Pole.Average());
                    Console.ReadLine();
                }
                else if (odpoved == 4)
                {
                    break;
                }
            }
        }

        // Program vzgeneruje N čísel do pole, poté zobrazí volbu
        // 1. Výpis seřazený vzestupně
        // 2. Výpis seřazený sestupně
        // 3. Nejmenší hodnota (min), Největší hodnota (max), Průměrná hodnota
        // 4. Nadprůměrné hodnoty
        // 5. Vygenerování nových hodnot
        // 6. Konec

        public static void KalkulackaN2()
        {
            Random random = new Random();
            Console.WriteLine("Zadej počet generovaných čísel: ");
            int n = int.Parse(Console.ReadLine());
            int[] Pole = new int[n];

            for (int i = 0; i < n; i++)
                Pole[i] = random.Next();

            foreach (int i in Pole)
                Console.WriteLine(i);
            

            while (true)
            {
                Console.WriteLine("1. Výpis seřazený vzestupně, 2. Výpis seřazený sestupně, 3. Nejmenší hodnota (min), Největší hodnota (max), Průměrná hodnota, 4. Nadprůměrné hodnoty, 5. Vygenerování nových hodnot, 6. Konec");
                string odpoved = Console.ReadLine();
                if (odpoved == "1")
                {
                    Array.Sort(Pole);
                    Console.WriteLine("\n\nSeřazené pole vzestupně");
                    foreach (int i in Pole) Console.WriteLine(i);
                }
                else if (odpoved == "2")
                {
                    Console.WriteLine("\n\nSeřazené pole vzestupně");
                    Array.Sort(Pole);
                    Array.Reverse(Pole);
                    foreach (int i in Pole)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                }
                else if (odpoved == "3")
                {
                    Console.WriteLine("Minimální hodnota je {0}", Pole.Min());
                    Console.WriteLine("Maximální hodnota je {0}", Pole.Max());
                    Console.WriteLine("Průměrná hodnota je {0}", Pole.Average());
                    Console.ReadLine();
                }
                else if (odpoved == "4")
                {
                    // 4. Nadprůměrné hodnoty
                    Console.WriteLine("Nadprůměrné hodnoty");
                    foreach (int i in Pole)
                    {
                        if (i > Pole.Average())
                            Console.WriteLine(i);
                    }
                    Console.ReadLine();

                }
                else if (odpoved == "5")
                {
                    // 5. Vygenerování nových hodnot
                    Console.WriteLine("Zadej počet generovaných čísel: ");
                    n = int.Parse(Console.ReadLine());
                    Pole = new int[n];

                    for (int i = 0; i < n; i++)
                        Pole[i] = random.Next();

                    foreach (int i in Pole)
                        Console.WriteLine(i);
                    Console.ReadLine();
                }
                else if (odpoved == "6")
                {
                    break;
                }
            }
        }

    }
}