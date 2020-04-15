using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Næbdyr : Pattedyr, IRovdyr
    {
        public Næbdyr(double vægt, string køn) : base("Næbdyr", vægt, køn, true)
        {

        }
        public bool ErRovdyr()
        {
            return true;
        }
    }
}
