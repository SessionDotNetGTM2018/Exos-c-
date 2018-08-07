using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Exos
{
    class Program
    {
        private static int[] scores = new[] { 97, 92, 81, 60 };

        static void Main(string[] args)
        {
            ScoresSuperieursA80();
            ScoresParOrdreCroissant();
            NombreOccurrencesLettres();

            Console.ReadKey();
        }

        private static void ScoresSuperieursA80()
        {
            AfficherEntete("Scores > 80");

            // Syntaxe de requête
            var requete = from score in scores
                          where score > 80
                          select score;

            // Syntaxe de méthode
            var requete2 = scores.Where(x => x > 80);

            AfficherResultats(requete);
        }

        private static void NombreOccurrencesLettres()
        {
            AfficherEntete("Nombre d'occurrences de chaque lettre");

            Console.WriteLine("Entre un mot:");
            var mot = Console.ReadLine();

            // Syntaxe de requête
            var requete = from lettre in mot
                          group lettre by lettre into groupe
                          select groupe;
            foreach (var groupe in requete)
            {
                Console.WriteLine($"Lettre {groupe.Key}: {groupe.Count()}");
            }
            Console.WriteLine("********************");

            // Syntaxe de méthode
            var requete2 = mot.GroupBy(x => x);
            foreach (var groupe in requete2)
            {
                Console.WriteLine($"Lettre {groupe.Key}: {groupe.Count()}");
            }
        }

        private static void ScoresParOrdreCroissant()
        {
            AfficherEntete("Scores par ordre croissant");

            // Syntaxe de requête
            var requete = from score in scores
                          orderby score
                          select score;

            // Syntaxe de méthode
            var requete2 = scores.OrderBy(x => x);
            AfficherResultats(requete2);
        }

        private static void AfficherResultats<T>(IEnumerable<T> resultats)
        {
            foreach (var resultat in resultats)
                Console.WriteLine(resultat);
        }

        private static void AfficherEntete(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
