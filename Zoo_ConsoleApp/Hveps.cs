using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Hveps : Insekt, IByttedyr
    {
        public Hveps(double vægt, string køn) : base("Hveps", vægt, køn, true)
        {

        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
