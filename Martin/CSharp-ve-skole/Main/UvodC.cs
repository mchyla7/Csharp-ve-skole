using System;

// float - číselný datový typ
// string - textový datový typ


namespace CSharp_ve_skole
{
    class UvodC
    {
        public static void Pozdrav()
        {
            Console.WriteLine("Ahoj");
            Console.ReadLine();

        }

        public static void JmenoPrijmeni()
        {
            //Poznmka jsou dvě //
            Console.Write("Zadejte jméno: ");
            string h1 = Console.ReadLine();
            Console.Write("Zadejte příjmení: ");
            string h2 = Console.ReadLine();

            //Console.WriteLine(h1+" "+h2);
            Console.WriteLine("Jméno: {0} \nPříjmení: {1}", h1, h2);
            Console.ReadLine();
        }

        public static void Scitani()
        {
            Console.Write("Zadejte 1 číslo: ");
            float h1 = float.Parse(Console.ReadLine());

            Console.Write("Zadejte 2 číslo: ");
            float h2 = float.Parse(Console.ReadLine());

            float soucet = h1 + h2;
            Console.WriteLine("Součet {0}", soucet);
            Console.ReadLine();
        }

        public static void TriCisla()
        {
            Console.Write("Zadejte 1 číslo: ");
            float h1 = float.Parse(Console.ReadLine());

            Console.Write("Zadejte 2 číslo: ");
            float h2 = float.Parse(Console.ReadLine());

            Console.Write("Zadejte 3 Číslo: ");
            float h3 = float.Parse(Console.ReadLine());

            float soucet = h1 + h2 + h3;
            float prumer = (h1 + h2 + h3) / 3;
            Console.WriteLine("\nČíslo 1 je {0}, Číslo 2 je {1}, Číslo 3 je {2}", h1, h2, h3);
            Console.WriteLine("Součet: {0}", soucet);
            Console.WriteLine("Průměr: {0}", prumer);
            Console.ReadLine(); // Přečte text do konzole
        }

        public static void ZobrazeniViceRadku()
        {
            Console.WriteLine(@"
███╗░░██╗███████╗███████╗░█████╗░██████╗░░█████╗░███╗░░░███╗██╗███╗░░██╗███████╗░░░░░██╗████████╗███████╗
████╗░██║██╔════╝╚════██║██╔══██╗██╔══██╗██╔══██╗████╗░████║██║████╗░██║██╔════╝░░░░░██║╚══██╔══╝██╔════╝
██╔██╗██║█████╗░░░░███╔═╝███████║██████╔╝██║░░██║██╔████╔██║██║██╔██╗██║█████╗░░░░░░░██║░░░██║░░░█████╗░░
██║╚████║██╔══╝░░██╔══╝░░██╔══██║██╔═══╝░██║░░██║██║╚██╔╝██║██║██║╚████║██╔══╝░░██╗░░██║░░░██║░░░██╔══╝░░
██║░╚███║███████╗███████╗██║░░██║██║░░░░░╚█████╔╝██║░╚═╝░██║██║██║░╚███║███████╗╚█████╔╝░░░██║░░░███████╗
╚═╝░░╚══╝╚══════╝╚══════╝╚═╝░░╚═╝╚═╝░░░░░░╚════╝░╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░░░░╚═╝░░░╚══════╝

██████╗░██████╗░██╗░░░██╗██████╗░███████╗███████╗███╗░░██╗███████╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔════╝╚════██║████╗░██║██╔════╝
██████╔╝██████╔╝██║░░░██║██████╦╝█████╗░░░░███╔═╝██╔██╗██║█████╗░░
██╔═══╝░██╔══██╗██║░░░██║██╔══██╗██╔══╝░░██╔══╝░░██║╚████║██╔══╝░░
██║░░░░░██║░░██║╚██████╔╝██████╦╝███████╗███████╗██║░╚███║███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚═════╝░╚═════╝░╚══════╝╚══════╝╚═╝░░╚══╝╚══════╝

██╗░░░██╗██╗░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░████████╗
██║░░░██║██║░██╔╝██║░░░░░██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝
██║░░░██║█████═╝░██║░░░░░███████║██║░░██║███████║░░░██║░░░
██║░░░██║██╔═██╗░██║░░░░░██╔══██║██║░░██║██╔══██║░░░██║░░░
╚██████╔╝██║░╚██╗███████╗██║░░██║██████╔╝██║░░██║░░░██║░░░
░╚═════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░"); //Pokud mám zavináč tak tam mohu psát co chci, jak dlouhého chci
            Console.ReadLine();
        }
    }
}
