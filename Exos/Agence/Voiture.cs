namespace Exos.Agence
{
    public sealed class Voiture : Vehicule
    {
        public int NombrePortes { get; set; } = 5;

        public CategorieVoiture Categorie { get; set; }

        public override double GetPrixJour()
        {
            return Categorie.PrixJour;
        }
    }
}
