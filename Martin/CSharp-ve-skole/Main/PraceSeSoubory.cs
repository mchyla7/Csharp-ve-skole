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


    }
}
