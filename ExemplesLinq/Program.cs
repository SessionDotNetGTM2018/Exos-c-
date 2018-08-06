using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExemplesLinq
{
    class Program
    {
        private static readonly int[] numeros = new int[] { 1, 3, 4, 6, 7, 8, 11, 15 };

        private static readonly string[] prenoms = new string[] {
            "Thierry", "Alexina", "Alexandre", "Frédéric",
            "Youcef", "Stéphane", "Laura", "Chi Trung", "Julien",
            "Cristtiano", "Hatem", "Laynet", "Anne", "Thi Tuong" };

        private static readonly List<Ville> villes = new List<Ville> {
            new Ville { Nom = "Paris", CodePostal = "75013" },
            new Ville { Nom = "Bordeaux", CodePostal = "33000" },
            new Ville { Nom = "Sarlat-La-Canéda", CodePostal = "24200" },
            new Ville { Nom = "Marseille", CodePostal = "13000" },
        };

        private static readonly List<Departement> departements = new List<Departement> {
            new Departement { Nom = "Paris", Numero = "75" },
            new Departement { Nom = "Dordogne", Numero = "24" },
            new Departement { Nom = "Charente", Numero = "16" },
            new Departement { Nom = "Gironde", Numero = "33" },
        };

        static void Main(string[] args)
        {
            RequeteSimple();
            RequeteAvecFiltre();
            RequeteAvecTri();
            RequeteAvecGroupement();
            RequeteAvecTypeDeRetourDifferent();
            RequeteAvecJointure();

            Console.ReadKey();
        }

        private static void RequeteSimple()
        {
            AfficherEntete();

            // Syntaxe de requête


            // Syntaxe de méthode
        }

        private static void RequeteAvecFiltre()
        {
            AfficherEntete();

            // Syntaxe de requête


            // Syntaxe de méthode
        }

        private static void RequeteAvecTri()
        {
            AfficherEntete();

            // Syntaxe de requête


            // Syntaxe de méthode
        }

        private static void RequeteAvecGroupement()
        {
            AfficherEntete();

            // Syntaxe de requête


            // Syntaxe de méthode
        }

        private static void RequeteAvecTypeDeRetourDifferent()
        {
            AfficherEntete();

            // Syntaxe de requête


            // Syntaxe de méthode
        }

        private static void RequeteAvecJointure()
        {
            AfficherEntete();

            // Syntaxe de requête


            // Syntaxe de méthode
        }

        private static void AfficherEntete([CallerMemberName]string nomMethodeAppelant = null)
        {
            Console.WriteLine();
            Console.WriteLine(nomMethodeAppelant);
            Console.WriteLine(new string('-', 60));
        }
    }
}
