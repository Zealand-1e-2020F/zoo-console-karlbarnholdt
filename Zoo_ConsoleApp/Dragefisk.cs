using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Dragefisk : Fisk
    {
        public Dragefisk(double vægt, string køn, int længde) : base("Dragefisk", vægt, køn, længde)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " ADVARSEL: DENNE FISK ER MEGET GIFTIG.";
        }
    }
}
