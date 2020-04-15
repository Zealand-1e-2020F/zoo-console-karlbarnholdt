using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Elefant : Pattedyr, IByttedyr
    {
        public int LængdePåStødtænderIcm { get; }
        public Elefant(double vægt, string køn, int længdePåStødtænderIcm) : base("Elefant", vægt, køn, false)
        {
            LængdePåStødtænderIcm = længdePåStødtænderIcm;
        }

        public override string ToString()
        {
            return base.ToString() + $" Denne elefants stødtænder er {LængdePåStødtænderIcm} cm.";
        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
