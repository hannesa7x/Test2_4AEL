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
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
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
