namespace Exos.Agence
{
    public sealed class Camionette : Vehicule
    {
        public int PoidsMaxEnKilos { get; set; }
        public int PrixJour { get; set; }

        public override double GetPrixJour()
        {
            return PrixJour;
        }
    }
}
