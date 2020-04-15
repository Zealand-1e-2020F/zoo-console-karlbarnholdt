using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Bjørn : Pattedyr, IRovdyr
    {
        public bool ErPeterPlys { get; }
        public Bjørn(double vægt, string køn, bool erPeterPlys) : base("Bjørn", vægt, køn, false)
        {
            ErPeterPlys = erPeterPlys;
        }
        public override string ToString()
        {
            return base.ToString() + $" Denne bjørn er Peter Plys: {ErPeterPlys}.";
        }
        public bool ErRovdyr()
        {
            return true;
        }
    }
}
