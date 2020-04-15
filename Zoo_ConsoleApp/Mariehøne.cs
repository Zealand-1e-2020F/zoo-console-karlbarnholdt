using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Mariehøne : Insekt, IByttedyr
    {
        public Mariehøne(double vægt, string køn) : base("Mariehøne", vægt, køn, false)
        {

        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
