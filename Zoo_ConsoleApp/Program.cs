using System;
using System.Collections.Generic;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Elefant elefant = new Elefant(5000, "Han", 60);
            Tiger tiger = new Tiger(120, "Han");
            Næbdyr næbdyr = new Næbdyr(28, "Han");
            Bjørn bjørn = new Bjørn(190, "Hun", false);
            Bjørn peterPlys = new Bjørn(45, "Han", true);
            Flue flue = new Flue(0.002, "Han");
            Hveps hveps = new Hveps(0.003, "Hun");
            Myg myg = new Myg(0.001, "Han");
            Mariehøne mariehøne = new Mariehøne(0.0035, "Han");
            Flyvefisk flyvefisk = new Flyvefisk(0.1, "Hun", 28);
            Hammerhaj hammerhaj = new Hammerhaj(280, "Hun", 220);
            Dragefisk dragefisk = new Dragefisk(2, "Han", 80);
            Ørred ørred = new Ørred(2.2, "Hun", 75);

            List<Dyr> dyr = new List<Dyr>();

            dyr.Add(elefant);
            dyr.Add(tiger);
            dyr.Add(næbdyr);
            dyr.Add(bjørn);
            dyr.Add(peterPlys);
            dyr.Add(flue);
            dyr.Add(hveps);
            dyr.Add(myg);
            dyr.Add(mariehøne);
            dyr.Add(flyvefisk);
            dyr.Add(hammerhaj);
            dyr.Add(dragefisk);
            dyr.Add(ørred);

            foreach (var item in dyr)
            {
                Console.WriteLine(item.ToString());
                if (item is IRovdyr)
                {
                    Console.WriteLine($"En {item.Name} er et rovdyr.");
                }
                else
                {
                    Console.WriteLine($"En {item.Name} er et byttedyr.");
                }
                Console.WriteLine();
            }
        }
    }
}
