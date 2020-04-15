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
            længdePåStødtænderIcm = LængdePåStødtænderIcm;
        }
    }
}
