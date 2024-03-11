using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_ve_skole.Testing
{
	class _11
	{
        public static void TestChyla()
        {
            // Skupina A
            //
            // Program načte text
            // Následně jej změní tak, že první a poslední znak nahradí znakem "?"
            // Dále mezi jednotlivé znaky vloží znak "-"

            Console.Write("Zadejte text: ");
            string text = Console.ReadLine();
            string textHotovy = "";

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (i == 0)
                {
                    textHotovy += "?";
                }
                else
                {
                    textHotovy += text[i];
                }
                textHotovy += "-";
            }

            Console.WriteLine(textHotovy += "?");
            Console.ReadLine();
        }


    }
}