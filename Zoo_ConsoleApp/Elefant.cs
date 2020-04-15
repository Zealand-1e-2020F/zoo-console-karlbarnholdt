using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Elefant : Pattedyr
    {
        public int LængdePåStødtænderIcm { get; }
        public Elefant(double vægt, int længdePåStødtænderIcm) : base("Elefant", vægt, false)
        {
            LængdePåStødtænderIcm = længdePåStødtænderIcm;
        }

        public override string ToString()
        {
            return base.ToString() + $" Denne elefants stødtænder er {LængdePåStødtænderIcm} cm.";
        }
    }
}
