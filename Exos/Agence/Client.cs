using System.Collections.Generic;

namespace Exos.Agence
{
    public class Client : Personne
    {
        public Client()
        {
            Contrats = new List<ContratLocation>();
        }

        public string Numero { get; set; }

        public List<ContratLocation> Contrats { get; set; }
    }
}
