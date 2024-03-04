using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole.Main
{
    class Práce_s_Textem
    {
        // Ukázka průchodu textu po jednotlivých znacích
        // Jednotlivé znaky jsou datového typu char

        public static void Vypis()
        {
        string text = Console.ReadLine();
        foreach (char znak in text)
            Console.WriteLine(znak);
        Console.ReadLine();
        }

        public static void Vypisy()
        {
            Console.Write("Zadejte text: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }

        Console.ReadLine();
        }

        // Program načte text
        // Následně jej zobrazí tak, že mezi každým znakem bude mezera
        // Vstup "abc"
        // Výstup " a b c "

        public static void Vystup3()
        {
            Console.Write("Zadejte text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
                Console.WriteLine(text[i] + " ");
            Console.ReadLine();
        }

        // Program načte text
        // Následně se bude ptát na číslo znaku, po jeho zadání znak zobrazí
        // Po zadání nečíselné hodnoty se program ukončí
        // V programu je testováno zda daná pozice znaku existuje

        // Vstup: "abcd"
        // Pozice znaku: 1
        // Výstup "a"

        public static void Pozicovac()
        {
            Console.Write("Zadejte text: ");
            string text = Console.ReadLine();
            while (true)
            {
                int i;
                Console.Write("Číslo znaku");
                if (!int.TryParse(Console.ReadLine(), out i)) return;
                if (i > 0 && i <= text.Length) Console.WriteLine(text[i - 1]);
                else Console.WriteLine("Špatné číslo");
            }
        }

        // Program načte text
        // Následně zobrazí:
        // Počet znaků
        // Počet mezer
        // První a poslední znak

        public static void NacteText()
        {
            Console.Write("Zadejte text: ");
            string text = Console.ReadLine();
            int pocetZnaku = text.Length;
            int pocetMezer = 0;
            foreach (char znak in text)
            {
                if (znak == ' ')
                {
                    pocetMezer++;
                }
            }
            char prvniZnak = text[0];
            char posledniZnak = text[text.Length - 1];

            Console.WriteLine("Počet znaků: ",pocetZnaku);
            Console.WriteLine("Počet mezer: ", pocetMezer);
            Console.WriteLine("První znak: ", prvniZnak);
            Console.WriteLine("Poslední znak: ", posledniZnak);
            Console.ReadLine();
        }

        
        // Program načte text
        // Poté se bude ptát na znak
        // Program zjístí počet výskytu zadaného znaku v textu
        // Vstup "abcda"
        // Znak a
        // Výstup: "2 Výskyty"

        public static void  ZnakOtaznik()
        {
            Console.Write("Zadej text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Zadej hledaný znak");
            char znak = Console.ReadKey().KeyChar;
            //string znak1 = Console.ReadLine();
            int pocet = 0; int pozice = 0; string poziceTisk = "";
            foreach (char z in text)
            {
                if (z == znak)
                {
                    pocet++;
                    poziceTisk += pozice + ";";
                }
                pozice++;
            }
            Console.WriteLine("\nPočet znaků , v textu: {0}", pocet);
            if (poziceTisk != "") Console.WriteLine(poziceTisk);
            Console.ReadLine();
        }

        // Program načte text
        // Následně jej zobrazí tak, že mezi každým znakem bude znak "*"
        // Vstup "abc"
        // Výstup "a*b*c"

        public static void Hvezdicka()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                if (i < text.Length - 1)
                {
                    Console.Write("*");
                }    
            }
            Console.WriteLine();
        }

        // Program načte text
        // Následně zobrazí tak, že před každým znakem bude jeho pořadové číslo
        // Vstup "abc"
        // Výstup "1.a 2.b 3.c"

        public static void Ciselka()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("{0}.{1} ", i + 1, text[i]);
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        // Program načte text
        // Následně jej zobrazí tak, že budou 3 znaky na řádku
        // Vstup: "abcdefg"
        // Výstup: "abc"
        //         "def"
        //         "g"

        public static void TriZnak()
        {
            string text2 = "";
            int novyRadek = 0;

            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                text2 += text[i];
                novyRadek++;
                if (novyRadek == 3)
                {
                    text2 += "/n";
                    novyRadek = 0;
                }
            }
            Console.Write(text2);
            Console.ReadLine();
        }


    }
}
