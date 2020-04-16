namespace Zoo_ConsoleApp
{
    /// <summary>
    /// Base class til pattedyr. Nedarver navn, vægt og køn fra Dyr.
    /// </summary>
    public abstract class Pattedyr : Dyr
    {
        public bool LæggerÆg { get; }
        /// <summary>
        /// Constructor til at lave Pattedyr. Tager Pattedyrets navn, vægt i kilo, køn og info om æglægning som input parametre.
        /// </summary>
        /// <param name="navn"></param>
        /// <param name="vægt"></param>
        /// <param name="køn"></param>
        /// <param name="læggerÆg"></param>
        public Pattedyr(string navn, double vægt, string køn, bool læggerÆg) : base(navn, vægt, køn)
        {
            LæggerÆg = læggerÆg;
        }

        public override string ToString()
        {
            return base.ToString() + $" En {Name} lægger æg: {LæggerÆg}.";
        }
    }
}
