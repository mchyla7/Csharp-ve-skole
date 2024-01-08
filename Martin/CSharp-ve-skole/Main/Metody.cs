using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole.Main
{
	class Metody
	{
        public static void soucetM()
        {
            Console.Write("a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.ReadLine();
        }

        public static float souecetM1v2(float a, float b)
        {
            return a + b;
        }

        public static float rozdil1v2(float a, float b)
        {
            return a - b;
        }

        public static void ahoj()
        {
            Console.Write("a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b: ");
            float b = float.Parse(Console.ReadLine());
        }

        public static void ForVypis()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void ForVypissude()
        {
            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void forvypiskokos()
        {
            Random generator = new Random();
            string tisk = "";
            Console.Write("Zadej pocet cisel:");
            int pocet = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pocet; i++)
            {
                int cislo = generator.Next(100);
                tisk += cislo + ";";
            }
            Console.WriteLine(tisk);
            Console.ReadLine();
        }

	}
}
