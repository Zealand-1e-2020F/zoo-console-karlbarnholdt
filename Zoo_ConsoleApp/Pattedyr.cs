using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Pattedyr : Dyr
    {
        public bool LæggerÆg { get; }
        public Pattedyr(string navn, double vægt, string køn, bool læggerÆg) : base(navn, vægt, køn)
        {
            LæggerÆg = læggerÆg;
        }

        public override string ToString()
        {
            return base.ToString() + $" En {Name} lægger æg: {LæggerÆg}.";
        }
    }
}
