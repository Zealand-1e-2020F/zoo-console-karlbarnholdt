namespace Zoo_ConsoleApp
{
    public class Bjørn : Pattedyr, IRovdyr
    {
        public bool ErPeterPlys { get; }
        /// <summary>
        /// Construtor til at lave bjørneobjekter. Tager tre parametre som input: vægt, køn og info om det er Peter Plys.
        /// </summary>
        /// <param name="vægt"></param>
        /// <param name="køn"></param>
        /// <param name="erPeterPlys"></param>
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
