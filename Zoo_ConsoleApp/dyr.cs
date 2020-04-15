using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// base klasse for dyr i zoo
    /// </summary>
    public abstract class Dyr
    {
        public string Name { get; }
        public double Weight { get;  }
        public string Køn { get; }

        /// <summary>
        /// cosntructor som tager dyrenavn og vægt som parameter
        /// </summary>
        public Dyr(string navn, double vægt, string køn)
        {
            this.Name = navn;
            this.Weight = vægt;
            this.Køn = køn;
        }

        public override string ToString()
        {
            return $"Denne {Name} vejer {Weight} kg og er en {Køn}.";
        }

    }
}
