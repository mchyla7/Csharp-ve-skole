using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole.Main
{
    class Procvicovani_Pole
    {
        // Program načte číselné hodnoty, po zadání nečíselné hodnoty se načítání ukončí.
        // Program zobrazí možnosti: 1.výpis v původním pořadí, 2.výpis vzestupně,  3.hledání hodnoty, 4.konec
        // Pokud bude zadaná 3.hledání hodnoty - program se zeptá na hledanou hodnotu, 
        // Poté zjistí zda se v poli vyskytuje

        static double[] pole = new double[10000];
        static int i = 0;

        public static void NacteniDoPole()
        {
            double[] pole = new double[100000];
            int i = 0;
            while (true)
            {
                double cislo;
                Console.WriteLine("Zadej číslo: ");
                if (!double.TryParse(Console.ReadLine(), out cislo)) break;
                pole[i] = cislo;
                i++;
            }
        }


        public static void HlavniProgramPole()
        {
            
            double[] poleNeserazene = new double[i];//vytvoří nové pole s už přesným počtem prvků
            Array.Copy(pole, poleNeserazene, i);//do nového pole zkopíruju zadané hodnoty
            double[] poleSerazene = new double[i];//vytvoří nové pole s už přesným počtem prvků
            Array.Copy(pole, poleSerazene, i);
            Array.Sort(poleSerazene);



            while (true)
            {
                Console.Write("\\n1.výpis v původním pořadí, 2.výpis vzestupně,3.hledání hodnoty, 4.konec");
                string volba = Console.ReadLine();

                if (volba == "1")
                {
                    foreach (double c in poleNeserazene) Console.Write(c + "; ");
                }
                else if (volba == "2")
                {
                    foreach (double c in poleSerazene) Console.Write(c + "; ");
                }
                else if (volba == "3")
                {
                    Console.Write("Zadej hledanou hodnotu: ");
                    double hledane = double.Parse(Console.ReadLine());
                    if (poleNeserazene.Contains(hledane)) Console.WriteLine("Pole hodnotu obsahuje");
                    else Console.WriteLine("Pole hodnotu neobsahuje");
                    Console.ReadLine();
                }
                else if (volba == "4") break;

            }


        }


    }
}
