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
            Pattedyr hest = new Pattedyr("hest", 200);
            Pattedyr ulv = new Pattedyr("Ulv", 40);


            Console.WriteLine(elefant.Name);

        }
    }
}
