using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Fisk : Dyr
    {
        public int Længde { get; }
        public Fisk(string navn, double vægt, string køn, int længde) : base(navn, vægt, køn)
        {
            Længde = længde;
        }
    }
}
