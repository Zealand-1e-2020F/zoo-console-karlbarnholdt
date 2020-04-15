using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Flue : Insekt, IByttedyr
    {
        public Flue(double vægt, string køn) : base("Flue", vægt, køn, false)
        {

        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
