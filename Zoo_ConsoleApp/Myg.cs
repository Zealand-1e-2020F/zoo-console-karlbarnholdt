using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Myg : Insekt, IRovdyr
    {
        public Myg(double vægt, string køn) : base("Myg", vægt, køn, false)
        {

        }
        public bool ErRovdyr()
        {
            return true;
        }
    }
}
