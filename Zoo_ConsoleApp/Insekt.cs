using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Insekt : Dyr
    {
        public bool ErGiftig { get; }
        public Insekt(string navn, double vægt, string køn, bool erGiftig) : base(navn, vægt, køn)
        {
            ErGiftig = erGiftig;
        }
        public override string ToString()
        {
            return base.ToString() + $" Denne {base.Name} er giftig: {ErGiftig}.";
        }
    }
}
