using System;
using System.Collections.Generic;

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

            List<Dyr> dyr = new List<Dyr>();
            dyr.Add(elefant);
            dyr.Add(tiger);
            dyr.Add(vildsvin);
            dyr.Add(hest);
            dyr.Add(ulv);
            dyr.Add(myg);
            dyr.Add(flue);
            dyr.Add(hveps);
            dyr.Add(bille);
            dyr.Add(myre);
            dyr.Add(torsk);
            dyr.Add(laks);
            dyr.Add(haj);
            dyr.Add(hvalhaj);
            dyr.Add(klovnefisk);

            foreach (var item in dyr)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
