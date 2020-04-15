using System;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattedyr elefant = new Pattedyr("Elefant", 6000);
            Pattedyr tiger = new Pattedyr("Tiger", 100);
            Pattedyr vildsvin = new Pattedyr("Vildsvin", 45);
            Pattedyr hest = new Pattedyr("Hest", 200);
            Pattedyr ulv = new Pattedyr("Ulv", 40);

            Insekt myg = new Insekt("Myg", 0.001);
            Insekt flue = new Insekt("Flue", 0.002);
            Insekt hveps = new Insekt("Hveps", 0.003);
            Insekt bille = new Insekt("Bille", 0.004);
            Insekt myre = new Insekt("Myre", 0.001);

            Fisk torsk = new Fisk("Torsk", 2);
            Fisk laks = new Fisk("Laks", 2.2);
            Fisk haj = new Fisk("Haj", 300);
            Fisk hvalhaj = new Fisk("Hvalhaj", 20000);
            Fisk klovnefisk = new Fisk("Klovnefisk", 0.24);


            Console.WriteLine(elefant);
            Console.WriteLine(tiger);
            Console.WriteLine(vildsvin);
            Console.WriteLine(hest);
            Console.WriteLine(ulv);

            Console.WriteLine();

        }
    }
}
