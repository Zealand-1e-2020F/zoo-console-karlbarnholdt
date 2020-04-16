namespace Zoo_ConsoleApp
{
    /// <summary>
    /// Base class for fisk. Nedarver navn, vægt og køn fra Dyr.
    /// </summary>
    public abstract class Fisk : Dyr
    {
        public int Længde { get; }
        /// <summary>
        /// Constructor til fisk der tager fiskens navn, vægt, køn og længde i centimeter som parametre.
        /// </summary>
        /// <param name="navn"></param>
        /// <param name="vægt"></param>
        /// <param name="køn"></param>
        /// <param name="længde"></param>
        public Fisk(string navn, double vægt, string køn, int længde) : base(navn, vægt, køn)
        {
            Længde = længde;
        }
        public override string ToString()
        {
            return base.ToString() + $" Dens længde er {Længde} cm.";
        }
    }
}
