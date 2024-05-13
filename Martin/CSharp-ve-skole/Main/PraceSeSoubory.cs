using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;    // Musíme přidat

namespace CSharp_ve_skole
{
    class PraceSeSoubory
    {
        public static void CteniZeSouboru()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\text.txt";
            // string dokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text.txt";

            string t = File.ReadAllText(cesta);

            Console.WriteLine(t);
            Console.ReadLine();
        }

        // Program načte text ze souboru
        // Program vrátí počet znaků v textu, ale bez mezer

        public static void PocetZnakuvSouboru()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\text.txt";

            string t = File.ReadAllText(cesta);

            Console.WriteLine(t.Replace(" ", "").Length);
            Console.ReadLine();
        }

        // Program načte soubor
        // Soubor zjístí počet výskytů znaků "@"

        public static void PocetZavinacuVSouboru()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\text.txt";
            string text = File.ReadAllText(cesta);
            int pocet = 0;

            foreach (char znak in text)
            {
                if (znak == '@')
                {
                    pocet++;
                }
            }

            Console.WriteLine("Počet @ je {0}", pocet);
            Console.ReadLine();
        }

        public static void CteniZeSouboruDoPole()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\cisla.txt";
            string[] soubor = File.ReadAllLines(cesta);

            // Zobrazení hodnot pole
            foreach (string radek in soubor)
            {
                Console.WriteLine(radek);
            }
            Console.ReadLine();
        }

        // Program načte hodnoty ze souboru do pole
        // Hodnoty převede na čísla a zobraí jejich součet, průměr a minimum

        public static void HodnotyZeSouboru()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\cisla.txt";
            string[] soubor = File.ReadAllLines(cesta);
            double[] cisla = new Double[soubor.Length];
            double cislo;
            int i = 0;

            foreach (string radek in soubor)
            {
                if (double.TryParse(radek, out cislo))
                {
                    cisla[i] = cislo;
                    i++;
                }
            }

            Array.Resize(ref cisla, i);

            Console.WriteLine("Součet:  {0}", cisla.Sum());
            Console.WriteLine("Průměr: {0}", cisla.Average()); // Formátování s 2 desetinnými místy
            Console.WriteLine("Minimum: {0}", cisla.Min());
            Console.ReadLine();
        }

        // V souboru jsou uloženy data, na řádku je jedna hodnota
        // Program data(texty) načte vzestupně seřadí a zobrazí
        // Dále zobrazí počet textů, které obsahují uvnitř mezeru

        public static void HodnotyZeSouboru()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\cisla.txt";
            string[] soubor = File.ReadAllLines(cesta);
            Array.Sort(soubor);
            int pocetMezer = 0;
            foreach (string hodnota in soubor)
                {
                    Console.WriteLine(hodnota);
                    if (hodnota.Trim().Contains(" "))
                    {
                        pocetMezer++;
                    }
                }
            Console.WriteLine("Počet textů s mezerou uvnitř {0}", pocetMezer);
            Console.ReadLine();
        }

        // Fromat souboru - na každém řádku jedno slovo (řetězec)
        // Program načte data ze souboru
        // Program se zeptá na řetězec a vypíše všechna slova obsahující daný řetězec

        // Soubor:
        // ffgtt
        // abcd
        // abfffff
        // sab
        // cccccc

        // Zadám ff, program vypíše ffgtt a abffff

        public static void Retezec()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\retezce.txt";
            string[] soubor = File.ReadAllLines(cesta);

            Console.WriteLine("Zadejte hledaný text: ");
            string hledani = Console.ReadLine();

            foreach (string radek in soubor)
            {
                if (radek.Contains(hledani))
                {
                    Console.WriteLine(radek);
                }
            }
            Console.ReadLine();
        }

        // Data: text cislo
        // Program zobrazí hodnoty z druhého sloupce
        // Pokud tabulka obsahuje v druhém sloupci nečíselnou hodnotu, program to oznámí a ukončí
        // Program zobrazí součet čísel a maximum z číselných hodnot

        public static void TextCislo()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\Tabulka.txt";
            string[] soubor = File.ReadAllLines(cesta);
            double soucet = 0;
            double max = double.MinValue;
            double cislo;

            foreach (string radek in soubor)
            {
                if (!double.TryParse(radek.Substring(radek.IndexOf(' ') + 1), out cislo))
                {
                    Console.Write("Chyba v datech!");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(cislo);
                if (cislo > max)
                {
                    max = cislo;
                }
            }
            Console.WriteLine("\nSoučet " + soucet);
            Console.WriteLine("\nMaximum " + max);
            Console.ReadLine();
        }

        // Data: text cislo
        // Program zobrazí hodnoty z druhého sloupce
        // Pokud tabulka obsahuje v druhém sloupci nečíselnou hodnotu, program to oznámí a ukončí
        // Program zobrazí součet čísel a maximum z číselných hodnot

        public static void TextCislo()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\Tabulka.txt";
            string[] soubor = File.ReadAllLines(cesta);
            double soucet = 0;
            double max = double.MinValue;
            double cislo;

            foreach (string radek in soubor)
            {
                if (!double.TryParse(radek.Substring(radek.IndexOf(' ')+1), out cislo))
                {
                    Console.Write("Chyba v datech!");
                    Console.ReadLine() ;
                    return;
                }
                Console.WriteLine(cislo);
                if (cislo > max)
                {
                    max = cislo;
                }
            }
            Console.WriteLine("\nSoučet " + soucet);
            Console.WriteLine("\nMaximum " + max);
            Console.ReadLine();
        }
    }
}
