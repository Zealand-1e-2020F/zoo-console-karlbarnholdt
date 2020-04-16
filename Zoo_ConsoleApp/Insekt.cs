namespace Zoo_ConsoleApp
{
    /// <summary>
    /// Base class for insekt. Nedarver navn, vægt og køn fra Dyr.
    /// </summary>
    public abstract class Insekt : Dyr
    {
        public bool ErGiftig { get; }
        /// <summary>
        /// Constructor til Insekter som tager insektets navn, vægt, køn og markering af giftig eller ej.
        /// </summary>
        /// <param name="navn"></param>
        /// <param name="vægt"></param>
        /// <param name="køn"></param>
        /// <param name="erGiftig"></param>
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
