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

            Tiger tiger = new Tiger(120, "Han");
            Console.WriteLine(tiger);

            Næbdyr næbdyr = new Næbdyr(28, "Han");
            Console.WriteLine(næbdyr);

            Bjørn bjørn = new Bjørn(190, "Hun");
            Console.WriteLine(bjørn);
        }
    }
}
