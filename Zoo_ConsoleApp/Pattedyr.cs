using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Pattedyr : Dyr
    {
        public bool LæggerÆg { get; }
        public Pattedyr(string navn, double vægt, bool læggerÆg) : base(navn, vægt)
        {
            læggerÆg = LæggerÆg;
        }
    }
}
