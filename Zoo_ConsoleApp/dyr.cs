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
        public string DyreNavn { get; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Dyr()
        {

        }

        public Dyr(string navn)
        {
            this.DyreNavn = navn;

        }


    }
}
