using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole.Main
{
    class MetodyTextu
    {
        public static void textMain()
        {
            string t = "Dobrý den";

            // Vrací True nebo False

            Console.WriteLine(t.StartsWith("Do"));  // Začínáý na "Do"
            Console.WriteLine(t[0]);                // Vypíše první znak
            Console.WriteLine(t.Length);            // Délka
            Console.WriteLine(t[t.Length - 1]);     // Vypíše poslední znak
            Console.WriteLine(t.ToUpper());         // Převede na velké písmo
            Console.WriteLine(t.ToLower());         // Převede na malé písmo

            // Odstraní všechny mezery na začátku a na konci

            Console.WriteLine("  asd  ".Trim());


            // Odstraní všechny mezery na začátku

            Console.WriteLine("   a   ".TrimStart());


            // Odstraní všechny mezery na konci

            Console.WriteLine("   x    ".TrimEnd());


            // Replace - nahrazení

            t = "Dobrý den";

            // Nahradí v t Dobrý za Krásný

            string t2 = t.Replace("Dobrý", "Krásný");


            // Substring - vrátí část podřetězce 
            // Pokud není druhý parametr, pak až do konce.

            Console.WriteLine(t.Substring(6));  // Vrátí všechny znaky od pozice 6

            // "abcd".Substring(1)      vystup"bcd"

            // Vrátí 3 znaky od pozice 6 (počítá se od 0 tj. pozice 7)

            Console.WriteLine(t.Substring(6, 3));


            // Vrátí 2 znak

            Console.WriteLine(t.Substring(1, 1));


            // "abcd".Substring(1,1)    vystup"b"

            // text.Substring(text.Length-1 ,1) poslední znak


            // IndexOf - vrátí pozici prvního výskytu daného řetězce v určeném řetězci
            // na jaké první pozici řetězce t se vyskytuje "D", rozeznává velká a malá písmena

            Console.WriteLine(t.IndexOf("D"));

            // "ABCDED".IndexOf("D") vrátí 3
            // "ABCDED".IndexOf("D",4) vrátí 5      

            Console.Read();        

        }

        // Program načte Jméno a Příjmení, Potom vrátí iniciály
        // Vstup: "Petr"
        //        "Novák"
        // Výstup: "P.N"

        public static void inicialy()
        {
            Console.WriteLine("Zadejte jméno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();

            string inicialy;
            inicialy = jmeno[0] + "." + prijmeni[0] + ".";
            inicialy = inicialy.ToUpper();

            Console.Write(inicialy);
            Console.ReadLine();
        }

        // Program načte text a vrátí první a poslední znak
        // Znaky převede na malá písmena

        public static void MalaPismena()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();

            text = text.ToLower();
            string prvniZnak = text[0].ToString();
            string posledniZnak = text[text.Length - 1].ToString();

            Console.WriteLine(prvniZnak + posledniZnak);
            Console.ReadLine();
            
        }

        // Program načte text
        // Vrátí první a poslední znak, místo ostatních znaků vloží "*"
        // Znaky převede na malé písmena
        // Vstup: "ABCD"
        // Výstup "a**d"

        public static void metoda()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            string prvni = text[0].ToString();
            string posledni = text[text.Length - 1].ToString();
            int pocetHvezd = text.Length - 2;
            string hvezdy = "";

            for (int i = 1; i <= pocetHvezd; i++)
            {
                hvezdy += "*";
            }

            Console.WriteLine((prvni + pocetHvezd + posledni).ToLower());
            Console.ReadLine();
        }
 
        // Program testuje zda zadaný text je mailova adresa
        // Podmínka: obsahuje @ a zároveň jim nezačíná ani nekončí
        // Program zobrazí: "V pořádku" nebo "Chyba"

        // Containd("@")
        // StartsWith("@")
        // EndsWith("@")
    }
}
