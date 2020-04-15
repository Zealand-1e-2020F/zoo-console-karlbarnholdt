using System;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dyr elefant = new Dyr("Elefant");

            Console.WriteLine(elefant.DyreNavn);

        }
    }
}
