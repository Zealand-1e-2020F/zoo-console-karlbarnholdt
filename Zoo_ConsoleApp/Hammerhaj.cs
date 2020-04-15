using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Hammerhaj : Fisk, IRovdyr
    {
        public Hammerhaj(double vægt, string køn, int længde) : base("Hammerhaj", vægt, køn, længde)
        {

        }
        public bool ErRovdyr()
        {
            return true;
        }
    }
}
