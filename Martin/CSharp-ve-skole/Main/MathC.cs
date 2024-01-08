using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole
{
    class MathC
    {
        public static void matematickéFunkce()
        {
            Console.WriteLine("Absolutní hodnota 10: " + Math.Abs(-10));
            Console.WriteLine("Maximální hodnota z 10 a 2: " + Math.Max(10, 2));
            Console.WriteLine("Třetí mocnina dvou: " + Math.Pow(2, 3));
            Console.WriteLine("Zaokrouhlení 1.2356 na 1 desetiné místo: " + Math.Round(1.2356, 1));
            Console.WriteLine("Druhá odmocnina z 9: " + Math.Sqrt(9));
        }

        // Vytvořte metodu, která načte 3 čísla a zjístí maximální hodnotu

        public static void zeTriMaximalniHodnota()
        {
            Console.Write("Zadej první číslo: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            float h2 = float.Parse(Console.ReadLine());
            Console.Write("Zadej třetí číslo: ");
            float h3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Maximální hodnota je: " + Math.Max(h1, Math.Max(h2, h3)));
            Console.ReadLine();
        }

        // Program načte odvěsny pravoúhlého trojuhelníku => Program zobrazí velikost přepony

        public static void vypocetPrepony()
        {
            Console.Write("Zadej první odvěsnu: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadej druhou odvěsnu: ");
            float h2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Velikost přepony je: " + Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(h2, 3)));
            Console.ReadLine();
        }

        // Varienta předchozího - zajistěte, aby vstupní hodnoty byly kladné čísla
        // Výsledek zaokrouhlený na dvě desetinná místa

        // && operátor AND
        // || operátor OR

      //public static void vypocetPreponyMitKladneCisla();
      //{
      //    Console.Write("Zadej první odvěsnu: ");
      //    float h1 = float.Parse(Console.ReadLine());
      //    Console.Write("Zadej druhou odvěsnu: ");
      //    float h2 = float.Parse(Console.ReadLine());

          //if (h1>0 && h2 > 0)
          //{
          //    Console.WriteLine("Velikost přepony je: " + Math.Round(Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(h2, 3)), 2));
          //    Console.ReadLine();
          //}
          //else
          //{
          //    Console.WriteLine("Zadejte kladná čísla");
          //    Console.ReadLine();
          //}
      //}

        // Program načte hodnotu h1 a hodnotu h2 pokud je h2 == 0 => program vypíše "Nulou nelze dělit" a ukončí se
        // Jinak provede podíl a zaokrouhlí výsledek na 2 desetinná místa

     // public static void deleni():
     // {
     //     Console.Write("Zadej první číslo: ");
     //     float h1 = float.Parse(Console.ReadLine());
     //     Console.Write("Zadej druhé číslo: ");
     //     float h2 = float.Parse(Console.ReadLine());
        //
        //  if (h2 == 0)
       //   {
       //       Console.WriteLine("Nulou nelze dělit");
       //       Console.ReadLine();
       //   }
       //   else
       //   {
       //       Console.WriteLine("Výsledek je: " + Math.Round(h1 / h2, 2));
       //       Console.ReadLine();
       //   }
     // }



        // ! Zakodovano několik řádku protože tady v tomto je hromada chyb (fucking github copilot)





        // Program načte dvě čísla pokud jsou stejné tka je vypíše
        // Pokud ne , pak větší číslo vydělí menším. Pokud je menší číslo nula, progrma to oznámí a ukončí se.

        public static void nacitacDvouCiselSDivnymAlgoritmem()
        {
            Console.Write("Zadej první číslo: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            float h2 = float.Parse(Console.ReadLine());

            if (h1 == h2)
            {
                Console.WriteLine("Výpis {0} {1}", h1, h2);
                Console.ReadLine();
            }
            else
            {
                if (h1 > h2)
                {
                    if (h2 == 0)
                    {
                        Console.WriteLine("Nulou nelze dělit");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Výsledek je: " + Math.Round(h1 / h2, 2));
                        Console.ReadLine();
                    }
                }
                else
                {
                    if (h1 == 0)
                    {
                        Console.WriteLine("Nulou nelze dělit");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Výsledek je: " + Math.Round(h2 / h1, 2));
                        Console.ReadLine();
                    }
                }
            


            }
        }

        // (h1*h1) / (h2*h2)
        // program načte dvě hodnoty h1 a h2 a vypočítá podíl jejich druhých mocnin
        // pokud je jmenovatel nula, program vypíše "Nulou nelze dělit" a ukončí se

        public static void mocniny()
        {
            Console.Write("Zadej první číslo: ");
            float h1 = float.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            float h2 = float.Parse(Console.ReadLine());

            if (h2 == 0)
            {
                Console.WriteLine("Nulou nelze dělit");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Výsledek je: " + Math.Round((Math.Pow(h1, 2) / Math.Pow(h2, 2)), 2));
                Console.ReadLine();
            }
        }


            public static void TryprseVysvetleni()
            {
                Console.Write("Zadejte hodnotu: ");
                // Metoda TryParse()
                // Vrací True pokud lze převést na daný typ / False pokud nelze
                // Do proměnné v druhé parametru vloží předefinovanou hodnotu
                string hodnota = Console.ReadLine();
                float cislo;

                if(float.TryParse(hodnota, out cislo))
                // Pokud lze obsah proměnné hodnota převést na float
                // pak metodat vrátí true a do proměnné číslo vloží
                // Převedenou hodnotu
                    Console.WriteLine("Hodnota {0} je číslo", cislo);
                else
                    Console.WriteLine("Nezadal jste číslo");
                Console.ReadLine();     
            }

            // Program načte hodnotu, pokud se nejedná o číslo program to oznámí a ukončí se
            // Pokud se jedná o číslo, pak program  vrátí jeho durhou a třetí mocninu

            public static void VypocetDruheATretiMocniny()
            {
                Console.Write("Zadejte hodnotu: ");
                string hodnota = Console.ReadLine();
                float cislo;

                if(!float.TryParse(hodnota, out cislo))
                    Console.WriteLine("Druhá mocnina {0} a Třetí mocnina {1}",Math.Pow(cislo, 2),Math.Pow(cislo, 3));
                else
                    Console.WriteLine("Nezadal jste číslo");
                    Console.ReadLine();
            }

            //Program se zeptá na věk a vypíše cenu vstupenky
            //Pokud za věk nezadáte číslo, program se ukončí
            // Vstupné 30 věk do 6
            // Vstupné 80 věk od 7 do 18
            // Vstupné 200 věk od 18 do 70
            // Vstupn= 80 věk nad 70
            // Pokud je věk mimo realný život pak to program oznámí

            public static void Vstupenky()
            {
               Console.Write("Zadejte váš věk: ");
               string hodnota = Console.ReadLine();
               float vek;

               if (!float.TryParse(hodnota, out vek))
               Console.WriteLine("Nezadal jste číslo!");
               else
               {
                if (vek < 0 || vek > 130)
                    Console.WriteLine("Neplatný věk");
                else if (vek <= 6)
                    Console.WriteLine("Vstupenka stojí 30,-");
                else if (vek <= 18)
                    Console.WriteLine("Vstupenka stojí 70,-");
                else if (vek <= 70)
                    Console.WriteLine("Vstupenka stojí 200,-");
                else
                    Console.WriteLine("Vstupenka stojí 80,-");
               }
               Console.ReadLine();
            }

            // Program načte dvě čísla a zeptá se
            // Jakou operaci s nimi má provést (+,-,*,/)
            // Program zobrazí výsledek, pozor na dělení nulou.
            // Pokud dojde k zadání chbného čísla operace, program to oznámí
            // Ošetřete stav, kdy nebyla zadána číselná hodnota

            public static void kakulacka()
            {
                Console.WriteLine("Zadej první číslo: ");
                float h1;
                if (!float.TryParse(Console.ReadLine(), out h1)) return;

                Console.WriteLine("Zadej druhé číslo: ");
                float h2;
                if (!float.TryParse(Console.ReadLine(), out h2)) return;

                Console.WriteLine("1. + | 2. - | 3. * | 4. /");
                string volba = Console.ReadLine();

                float soucet = h1 + h2;
                float odcet = h1 - h2;
                float nasobek = h1 * h2;

                if (volba == "1")
                    Console.WriteLine("{0} + {1} = {2}", h1, h2, soucet);
                else if (volba == "2")
                    Console.WriteLine("{0} - {1} = {2}", h1, h2, odcet);
                else if (volba == "3")

                    Console.WriteLine("{0} * {1} = {2}", h1, h2, nasobek);
                else if (volba == "4")
                    {
                    if (h2 == 0)
                        {
                            Console.WriteLine("Nulou nelze dělit");
                            Console.WriteLine("{0} / {1} = {2}", h1, h2, h1 / h2);
                        }
                    }
                else
                    Console.WriteLine("Chyba ve volbě");

                Console.ReadLine();
                
            }
        }   

    }

