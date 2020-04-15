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

            Bjørn bjørn = new Bjørn(190, "Hun", false);
            Console.WriteLine(bjørn);

            Bjørn peterPlys = new Bjørn(45, "Han", true);
            Console.WriteLine(peterPlys);

            Flue flue = new Flue(0.002, "Han");
            Console.WriteLine(flue);

            Hveps hveps = new Hveps(0.003, "Hun");
            Console.WriteLine(hveps);

            Myg myg = new Myg(0.001, "Han");
            Console.WriteLine(myg);

            Mariehøne mariehøne = new Mariehøne(0.0035, "Han");
            Console.WriteLine(mariehøne);

            Flyvefisk flyvefisk = new Flyvefisk(0.1, "Hun", 28);
            Console.WriteLine(flyvefisk);

            Hammerhaj hammerhaj = new Hammerhaj(280, "Hun", 220);
            Console.WriteLine(hammerhaj);
        }
    }
}
