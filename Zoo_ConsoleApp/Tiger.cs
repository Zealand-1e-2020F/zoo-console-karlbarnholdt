using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Tiger : Pattedyr, IRovdyr
    {
        public Tiger(double vægt, string køn) : base("Tiger", vægt, køn, false)
        {
            
        }
        public bool ErRovdyr()
        {
            return true;
        }
    }
}
