using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole
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

        public static void email()
        {
            Console.WriteLine("Zadejte Email: ");
            string email = Console.ReadLine();
            if (!email.Contains("@") || email.StartsWith("@") || email.EndsWith("@"))
            {
                Console.WriteLine("V emailu je chyba");
            }
            else
            {
                Console.WriteLine("Email je vpořádku");
            }
        }

        // Program načte text
        // Prochází znak po znaku
        // Sudé písmeno bude velkým písmem a liché malým
        //
        // Vstup: ABcdeFGh
        // Výstup: aBcDeFgH
        // Použít:  ToUpper();
        //          ToLower();

        public static void sudoliche()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();

            for (int i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(text[i].ToString().ToUpper());
                }
                else
                {
                    Console.WriteLine(text[i].ToString().ToLower());
                }
            }
            Console.ReadLine();

        }

        // Program načte text
        // a zobrazí první znak velkým, ostatní malým
        // Vstup:    miREK
        // Výstup:   Mirek

        public static void Mirek()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();

            text = text.ToUpper()[0] + text.ToLower().Substring(1);
            Console.WriteLine(text);
        }

        // Program načte text
        // Poté zobrazí volbu:
        // 1. Poslední znak velkým
        // 2. Všechny znaky bez posledního
        // 3. První a poslední znak velkým, ostatní znaky malé
        // 4. Konec

        public static void program()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            string upravenyText = "";

            while (true)
            {
                Console.WriteLine("Zvolte operaci:");
                Console.WriteLine("1. Poslední znak velkým");
                Console.WriteLine("2. Všechny znaky bez posledního");
                Console.WriteLine("3. První a poslední znak velkým, ostatní znaky malé");
                Console.WriteLine("4. Konec");

                int volba = int.Parse(Console.ReadLine());

                if (volba == 1 && text.Length > 0)
                {
                    upravenyText = text.Substring(0, text.Length - 1) + text[text.Length - 1].ToString().ToUpper();
                }
                else if (volba == 2 && text.Length > 0)
                {
                    upravenyText = text.Substring(0, text.Length - 1);
                }
                else if (volba == 3)
                {
                    if (text.Length > 1)
                    {
                        upravenyText = text[0].ToString().ToUpper() + text.Substring(1, text.Length - 2).ToLower() + text[text.Length - 1].ToString().ToUpper();
                    }
                    else if (text.Length == 1)
                    {
                        upravenyText = text.ToUpper();
                    }
                }
                else if (volba == 4)
                {
                    break;
                }
                if (upravenyText != "")
                {
                    Console.WriteLine(upravenyText);
                }
            }
        }

        // Program načte text
        // Odstraní mezery před a za textem
        // Uvnitř nahradí mezery znakem "_"
        // Vstup:   "   a b c      "
        // Výstup:  "a_b_c"

        public static void HodneMezer()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();

            text = text.Trim();
            text = text.Replace(" ", "_");
            Console.WriteLine(text);
        }

        // Vytvořte program který načte text
        // Odstraní mezery před a za textem
        // Pokud text obsahuje " " pak vrátí text před mezerou a na dalším řádku za mezerou
        // Pokud neobsahuje " ", pak to oznámí

        // text.Contains(" ") vrátí true pokud text obsahuje mezeru
        // Vstup     "    abc cde      "
        // Výstup    "abc"
        //           "cde"


        static void Containsss()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();

            string bezmezertext = text.Trim();

            if (!bezmezertext.Contains(" "))
            {
                Console.WriteLine("Text neobsahuje mezeru.");
                return;
            }
            else
            {
                Console.WriteLine(bezmezertext.Substring(0, bezmezertext.IndexOf(" ")));
                Console.Write(bezmezertext.Substring(bezmezertext.IndexOf(" ") + 1));
            }
            Console.Read();
        }

        // Načte emailovu adresu petr.novake@cez.cz
        // Vypíše jméno

        public static void mail()
        {
            Console.WriteLine("Zadejte emailovu adresu: ");
            string text = Console.ReadLine();
            string jmeno = text.Substring(text.IndexOf(".") + 1);

            Console.Write(jmeno);
            Console.ReadLine();
        }

        // Načte emailovu adresu petr.novake@cez.cz
        // Pokud adresa obsahuje znak "." a zároveň tímto znakem nezačíná, potom program vypíše text před tečkou

        public static void emailyy()
        {
            Console.WriteLine("Zadejte email: ");
            string email = Console.ReadLine();

            if (email.IndexOf(".") > 0)
            {
                string jmeno = email.Substring(0, email.IndexOf("."));
            }
            else
            {
                Console.WriteLine("Emailová adresa neobsahuje tečku.");
            }

            Console.ReadLine();
        }

        // Program načte emailovou adresu
        // Pokud adresa obsahuje znak "." a zároveň znakem nezačíná, dále text obsahuje @ a "." je před @
        // Metoda vypíše text před tečkou

        public static void wtf()
        {
            Console.WriteLine("Zadejte email: ");
            string text = Console.ReadLine();

            if (text.IndexOf(".") > 0 && text.IndexOf("@")>text.IndexOf("."))
            {
                string jmeno = text.Substring(0, text.IndexOf("."));
            }
            else
            {
                Console.WriteLine("Emailová adresa neobsahuje tečku.");
            }

            Console.ReadLine();
        }

        // Vypište příjmení

        public static void prijmeni()
        {
            Console.WriteLine("Zadejte email: ");
            string text = Console.ReadLine();

            Console.WriteLine(text.Substring(text.IndexOf("."), text.IndexOf("@")));
            Console.ReadLine();
        }

        // Program načte text a zkontroluje jestli tam jsou české znaky
        // "ěščřžýáíé"

        public static void czech()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            string ceskeZnaky = "ěščřžýáíé";

            int obsahuje = 0;

            foreach (char znak in text)
            {
                if (ceskeZnaky.IndexOf(znak) >= 0)
                {
                    obsahuje++;
                    break;
                }
            }

            if (obsahuje > 0)
            {
                Console.WriteLine("Text obsahuje české znaky.");
            }
            else
            {
                Console.WriteLine("Text neobsahuje české znaky.");
            }
     
        }
    
        // Program načte text, nahradí diakritiku
        // Vstup: "řešeto"
        // Výstup: "reseto"

        public static void cestina()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            string cznaky = "ěščřžýáíéňďťúůĚŠČŘŽÝÁÍÉŇĎŤÚŮ";  // ĚŠČŘŽÝÁÍÉŇĎŤÚŮ
            string aznaky = "escrzyaiendtuuESCRZYAIENDTUU";   // ESCRZYAIENDTUU

            for (int i = 0; i < cznaky.Length; i++)
            {
                text = text.Replace(cznaky[i], aznaky[i]);
            }

            Console.WriteLine(text);
            Console.ReadLine();

        }

        // char.IsUpper(znak) vrací true pokued je znak velké písmeno

        // Program načte text a zobrazí počet velkých písmen v textu
        // Zobrazí počet malých a velkých písmen

        public static void PocetVelkychPismen()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            int pocetVelkych = 0; 
            int pocetMalych = 0; 

            foreach (char znak in text)
            {
                if (char.IsUpper(znak) == true)
                {
                    pocetVelkych++;
                }
                else if (char.IsLower(znak) == true)
                {
                    pocetMalych++;
                }
        
            }

            Console.WriteLine("Malých znaků je {0} a velkých je {1}", pocetMalych, pocetVelkych);
            Console.ReadLine();
        }

        // Program převede velká písmena na malá a malá na velká
        // Vstup: "ABC12cba"
        // Výstup: "abc12CBA"

        public static void VelkeNaMalaMalaNaVelka()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            string vystup = "";
            
            foreach (char znak in text)
            {
                if (char.IsUpper(znak))
                {
                    vystup += znak.ToString().ToLower();
                }
                else
                {
                    vystup += znak.ToString().ToUpper();
                }
            }

            Console.WriteLine(vystup);
            Console.ReadLine();
        }

        // Směs všech příkladů

        public static void Vse()
        {
            Console.WriteLine("Zadejte text: ");
            string text = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("1. Odstraní mezery před a za textem, nahradí mezery znakem _, 2. Věk/nPříjmení/nJméno, 3. Konec");
                string otazka = Console.ReadLine();
                if (otazka == "1")
                {
                    Console.WriteLine(text);
                    text = text.Trim();
                    text = text.Replace(" ", "_");
                    Console.WriteLine(text);
                }
                if (otazka == "2")
                {
                    int prvnicarka = text.IndexOf(',');
                    int druhacarka = text.IndexOf(',', prvnicarka + 1); 
                    string jmeno = text.Substring(0, prvnicarka);
                    string prijmeni = text.Substring(prvnicarka + 1, druhacarka - prvnicarka - 1);
                    string vek = text.Substring(druhacarka + 1);
                    int vek2 = int.Parse(vek);

                    Console.WriteLine(vek2);
                    Console.WriteLine(prijmeni.ToUpper()[0] + prijmeni.Substring(1).ToLower());
                    Console.WriteLine(jmeno);
                }
                if (otazka == "3")
                {
                    break;
                }

            }

        }

        // done
    }
}