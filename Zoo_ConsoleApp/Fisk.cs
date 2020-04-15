using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Fisk : Dyr
    {
        public int Lenght { get; }
        public Fisk(string navn, int længde, double vægt) : base(navn, vægt)
        {
            længde = Lenght;
        }
    }
}
