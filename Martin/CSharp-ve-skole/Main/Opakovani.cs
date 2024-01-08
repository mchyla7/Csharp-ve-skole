using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole
{
    class Opakovani
    {
        // Program načte číslo. 
        // Pokud byla zadána nečíselná hodnota, oznámí to a zeptá se znovu
        // Metoda zobrazí druhou mocninu čísla

        public static void ProgramNacteCislo()
        {
            float cislo;
            while (true)
            {
                Console.WriteLine("Zadejte číslo: ");
                if (!float.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Nezadal jsi číslo :(");
                }
                else
                {
                    Console.WriteLine("Výsledek je {0}", Math.Pow(cislo, 2));
                    Console.ReadLine();
                    break;
                }

            }
        }

        //
    }
}
