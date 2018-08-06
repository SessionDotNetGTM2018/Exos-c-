using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Exos
{
    class Program
    {
        private static int[] scores = new[] { 97, 92, 81, 60 };

        static void Main(string[] args)
        {
            ScoresSuperieursA80();
            ScoresParOrdreCroissant();
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
