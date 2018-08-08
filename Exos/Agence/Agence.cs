using System.Collections.Generic;

namespace Exos.Agence
{
    public sealed class Agence
    {
        public Agence()
        {
            Parc = new List<Vehicule>();
            Personnel = new List<Employe>();
        }

        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public List<Employe> Personnel { get; set; }
        public List<Vehicule> Parc { get; set; }
    }
}
