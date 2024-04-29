using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Class1
    {
        // 1.
        // Program bude načítat texty
        // Po načtení se zeptá zda má načítání ukončit
        // Po ukončení načítání program zobrazí volbu
        // 1. Výpis textů - každý text na samostatném řádku, odstraněny mezery
        // 2. Celkový počet znaků bez mezer
        // 3. Konec

        public static void jedna()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            string pokracovani = "";
            string text2 = "";
            while (true)
            {
                Console.WriteLine("Chcete pokračovat? Y/N");
                pokracovani = Console.ReadLine();
                if (pokracovani == "Y")
                {
                    Console.WriteLine("Zadejte další text: ");
                    text2 = text + "/n" + Console.ReadLine();
                }
                else if (pokracovani == "N")
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("1. Výpis textu, 2. Celkový počet znaků bez mezer, 3. Konec   : ");
                string otazka = Console.ReadLine();

                if (otazka == "1")
                {
                    if (pokracovani == "Y")
                    {
                        Console.WriteLine(text2.Trim());
                        Console.ReadLine();
                    }
                    else if (pokracovani == "N")
                    {
                        Console.WriteLine(text.Trim());
                        Console.ReadLine();
                    }
                }
                else if (otazka == "2")
                {
                    if (pokracovani == "Y")
                    {
                        Console.WriteLine(text2.Trim().Length);
                        Console.ReadLine();
                    }
                    else if (pokracovani == "N")
                    {
                        Console.WriteLine(text.Trim().Length);
                        Console.ReadLine();
                    }
                }
                else if (otazka == "3")
                {
                    break;
                }
            }
        }

        // 2. 
        // Program načte text ve formátu "Jméno příjmení"
        // Pokud uvnitř textu nebude mezera, tak se program ukončí
        // Pokud bude mezera
        // Program nejdříve zobrazí Příjmení a potom jméno

        public static void dvojka()
        {
            string jmeno = "";
            string prijmeni = "";
            string text = "";

            Console.WriteLine("Zadejte jméno a příjmení: ");
            text = Console.ReadLine();

            if (text.Contains(" ") == true)
            {
                jmeno = text.Substring(0, text.IndexOf(" ")).ToUpper();
                prijmeni = text.Substring(text.IndexOf(" ") + 1).ToUpper();
                Console.WriteLine(prijmeni);
                Console.WriteLine(jmeno);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Text neobsahuje mezeru");
                Console.ReadLine();
            }
        }
    }
}