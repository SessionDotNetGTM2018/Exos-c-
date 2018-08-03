using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MethodesExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var chaine = " ezfzef zef rzg rthetrh er";
            AfficherMessage("Chaîne d'origine: \"");
            AfficherMessage(chaine, ConsoleColor.Yellow);
            AfficherMessage("\"\n");

            chaine = chaine.SupprimerEspaces("*");
            AfficherMessage("Chaîne transformée: \"");
            AfficherMessage(chaine, ConsoleColor.Yellow);
            AfficherMessage("\"\n");

            Console.ReadKey();
        }

        static void AfficherMessage(string texte, ConsoleColor couleur = ConsoleColor.Gray)
        {
            Console.ForegroundColor = couleur;
            Console.Write(texte);
            Console.ResetColor();
        }
    }
}
