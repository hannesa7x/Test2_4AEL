using System;

namespace Test4AEL
{

    //Konvertierung von Zahlensystemen
    class Program
    {
        static void Main(string[] args)
        {
            Titel("Das ist ein Test", ConsoleColor.Red);
            Console.ReadLine();
        }

        static void Titel(string titel, ConsoleColor texfarbe)
        {
            int laengeWindow = Console.WindowWidth;
            int laengeTitel = titel.Length;

            ConsoleColor aktTextFarbe = Console.ForegroundColor; //aktuelle Textfarbe zwischenspeichern
            Console.Clear();           

            Console.ForegroundColor = texfarbe;
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
            Console.ForegroundColor = aktTextFarbe;
        }
    }
}
