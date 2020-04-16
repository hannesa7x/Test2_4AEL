using System;

namespace Test4AEL
{

    //Konvertierung von Zahlensystemen
    class Program
    {
        static void Main(string[] args)
        {
            Titel("Das ist ein Test");
            Console.ReadLine();
        }

        static void Titel(string titel)
        {
            int laengeWindow = Console.WindowWidth;
            int laengeTitel = titel.Length;
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < (laengeWindow-laengeTitel)/2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
