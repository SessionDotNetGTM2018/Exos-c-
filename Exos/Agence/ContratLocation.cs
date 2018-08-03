using System;

namespace Exos.Agence
{
    public class ContratLocation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int KilometrageMaximum { get; set; }

        public Client Client { get; set; }
        public Vehicule Vehicule { get; set; }

        public double CalculerMontantLocation(DateTime dateDebut, DateTime dateFin)
        {
            return 0;
        }
    }
}
