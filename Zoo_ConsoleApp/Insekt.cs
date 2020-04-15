using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Insekt : Dyr
    {
        public bool ErGiftig { get; }
        public Insekt(string navn, double vægt, bool erGiftig) : base(navn, vægt)
        {
            erGiftig = ErGiftig;
        }
    }
}
