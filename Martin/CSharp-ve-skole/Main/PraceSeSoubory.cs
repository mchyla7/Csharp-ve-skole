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
            // string dokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Test\\text.txt";

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

        // V souboru jsou uložená čísla, na každém řádku je číslo
        // Program zobrazí záporné hodnoty a seřadí je sestupně

        public static void NegativniCisla()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\cisla.txt";
            string[] soubor = File.ReadAllLines(cesta);
            double[] cisla = new Double[soubor.Length];
            double cislo;
            int i = 0;
            double[] negativni = new Double[cisla.Length];

            foreach (string radek in soubor)
            {
                if (double.TryParse(radek, out cislo))
                {
                    cisla[i] = cislo;
                    i++;
                }
            }

            Array.Sort(cisla);
            Array.Reverse(cisla);
            foreach (double hodnota in cisla)
            {
                if (hodnota < 0)
                {
                    Console.WriteLine("{0} ", hodnota);
                }
            }
            Console.ReadLine();
        }


    }
}
