using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chyla
{
    class Chila
    {

        // Program načte data a zobrazí volbu:
        // 1. Zobrazí data seřazená vzestupně
        // 2. Zobrazí data tak že první je jméno a potom příjmení a bude to oddělené mezerou Začátky budou velkým písmem
        // 3. Konec

        public static void Test()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text.txt";
            string[] soubor = File.ReadAllLines(cesta);

            while (true)
            {
                Console.WriteLine("1. Zobrazí data seřazená vzestupně | 2. Jméno a příjmení | 3. Konec  : ");
                string odpoved = Console.ReadLine();

                if (odpoved == "1")
                {
                    Array.Sort(soubor);
                    Console.WriteLine(soubor);
                    Console.ReadLine();
                }
                else if (odpoved == "2")
                {
                    foreach (string radek in soubor)
                    {
                        string jmeno = radek.Substring(radek.IndexOf("_"));
                        string prijmeni = radek.Substring(radek.IndexOf("_") + 1);
                        Console.WriteLine(jmeno.Substring(0, 1).ToUpper() + jmeno.Substring(1).ToLower() + " " + prijmeni.Substring(0, 1).ToUpper() + prijmeni.Substring(1).ToLower());
                    }

                }
                else if (odpoved == "3")
                {
                    break;
                }
            }
        }
    }
}
