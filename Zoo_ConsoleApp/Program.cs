using System;
using System.Collections.Generic;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Elefant elefant = new Elefant(5000, "Han", 60);
            Console.WriteLine(elefant);
        }
    }
}
