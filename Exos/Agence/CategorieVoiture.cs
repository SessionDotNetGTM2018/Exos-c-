using System.Collections.Generic;

namespace Exos.Agence
{
    public class CategorieVoiture
    {
        public string Nom { get; set; }
        public double PrixJour { get; set; }

        public List<Voiture> Voitures { get; set; }
    }
}
