using System.Collections.Generic;

namespace Exos.Agence
{
    public sealed class Agence
    {
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public List<Employe> Personnel { get; set; }
        public List<Vehicule> Parc { get; set; }
    }
}
