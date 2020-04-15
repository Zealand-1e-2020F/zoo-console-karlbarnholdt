using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// base klasse for dyr i zoo
    /// </summary>
    public class Dyr
    {
        public string Name { get; }
        public double Weight { get;  }

        /// <summary>
        /// cosntructor som tager dyrenavn som parameter
        /// </summary>
        public Dyr(string navn, double vægt)
        {
            this.Name = navn;
            this.Weight = vægt;
        }


    }
}
