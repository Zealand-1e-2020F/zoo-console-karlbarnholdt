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
        public override string ToString()
        {
            return base.ToString() + $" Dens længde er {Længde} cm.";
        }
    }
}
