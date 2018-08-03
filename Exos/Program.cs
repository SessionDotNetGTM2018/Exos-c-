using Exos.Agence;
using System;

namespace Exos
{
    class Program
    {
        static void Main(string[] args)
        {
            var agence = new Agence.Agence();
            agence.Nom = "Budget";
            agence.Ville = "Paris";

            var client = new Client();
            client.Nom = "BAZAN";
            client.Prenom = "Yannick";
            client.Numero = "00001";

            var categorieCompacte = new CategorieVoiture();
            categorieCompacte.Nom = "Compacte";
            categorieCompacte.PrixJour = 40;

            var voiture1 = new Voiture();
            voiture1.Categorie = categorieCompacte;
            voiture1.Marque = "Peugeot";
            voiture1.Modele = "308";
            categorieCompacte.Voitures.Add(voiture1);
            agence.Parc.Add(voiture1);

            var contratLocation = new ContratLocation();
            contratLocation.Client = client;
            contratLocation.DateDebut = DateTime.Today;
            contratLocation.DateFin = DateTime.Today.AddDays(5);
            contratLocation.KilometrageMaximum = 500;
            contratLocation.Vehicule = voiture1;

            Console.WriteLine($"Contrat pour {contratLocation.Client.Nom} {contratLocation.Client.Prenom}: " +
                                $"{contratLocation.CalculerMontantLocation()} EUR");

            Console.ReadKey();
        }
    }

}
