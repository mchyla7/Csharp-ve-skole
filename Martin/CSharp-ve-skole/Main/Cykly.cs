using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ve_skole
{
    internal class Cykly
    {

        //while(podminka)
        public static void VypisCisel()
        {
            int a = 2;
            do
            {
                Console.WriteLine(a);
                a += 2;
            } while (a <= 100);
            Console.ReadLine();
        }


        // Program vypíše čísla do 1000

        public static void VypisCisel2()
        {
            int i = 1;
            while (true)
            {
                Console.WriteLine(i);
                if (i == 1000) break;
                i++;
            }

        }

        // Program načte dvě hodnoty, a zobrazí nabídku
        // 1. Součet
        // 2. Součin
        // 3. Konec
        // Dokud uživatel nezadá "3" program se stále ptá na volbu
        // 
        public static void PrvniVolby()
        {
            Console.Write("Zadej hodnotu a:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Zadej hodnotu b:");
            float b = float.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Zadejte operaci - 1. Součet, 2. Součin, 3. Konec");
                string volba = Console.ReadLine();
                if (volba == "1")
                    Console.WriteLine("Váš součet je {0}", a + b);
                else if (volba == "2")
                    Console.WriteLine("Váš součin je {0}", a * b);
                else if (volba == "3") break;

            }
        }
        
    }
}
