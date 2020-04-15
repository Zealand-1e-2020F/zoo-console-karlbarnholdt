using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Ørred : Fisk, IByttedyr
    {
        public Ørred(double vægt, string køn, int længde) : base("Ørred", vægt, køn, længde)
        {

        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
