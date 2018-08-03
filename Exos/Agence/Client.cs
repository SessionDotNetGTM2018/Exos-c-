using System.Collections.Generic;

namespace Exos.Agence
{
    public class Client : Personne
    {
        public string Numero { get; set; }

        public List<ContratLocation> Contrats { get; set; }
    }
}
