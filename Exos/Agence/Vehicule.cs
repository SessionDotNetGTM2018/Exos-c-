namespace Exos.Agence
{
    public abstract class Vehicule
    {
        public string Marque { get; set; }
        public string Modele { get; set; }

        public double GetPrixJour()
        {
            return 0;
        }
    }
}
