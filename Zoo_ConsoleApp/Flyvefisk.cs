using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Flyvefisk : Fisk, IByttedyr
    {
        public Flyvefisk(double vægt, string køn, int længde) : base("Flyvefisk", vægt, køn, længde)
        {
        
        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
