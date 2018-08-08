using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LectureEcritureFichier
{
    class Program
    {
        private static readonly List<Ville> villes = new List<Ville> {
            new Ville { Nom = "Paris", CodePostal = "75013" },
            new Ville { Nom = "Bordeaux", CodePostal = "33000" },
            new Ville { Nom = "Mérignac", CodePostal = "33700" },
            new Ville { Nom = "Floirac", CodePostal = "33270" },
            new Ville { Nom = "Sarlat-La-Canéda", CodePostal = "24200" },
            new Ville { Nom = "Bergerac", CodePostal = "24100" },
            new Ville { Nom = "Périgueux", CodePostal = "24000" },
            new Ville { Nom = "Marseille", CodePostal = "13000" },
        };

        static void Main(string[] args)
        {
            // Lire un fichier
            var cheminFichier = "villes.txt";
            if (File.Exists(cheminFichier))
            {
                IEnumerable<string> lignesFichier = File.ReadLines(cheminFichier);
                var villesDansFichier = new List<Ville>();
                foreach (var ligneFichier in lignesFichier)
                {
                    string[] champs = ligneFichier.Split(';');
                    var ville = new Ville();
                    ville.Nom = champs[0];
                    ville.CodePostal = champs[1];
                    ville.CodeInsee = champs[2];

                    villesDansFichier.Add(ville);
                }
            }
            else
            {
                // Ecrire
                var contenuFichier = new StringBuilder();
                foreach (var ville in villes)
                {
                    //contenuFichier.AppendLine($"{ville.Nom};{ville.CodePostal}");
                    contenuFichier.AppendLine(string.Join(";", ville.Nom, ville.CodePostal, ville.CodeInsee));
                }

                File.WriteAllText(cheminFichier, contenuFichier.ToString());
            }

            Console.ReadKey();
        }
    }
}
