using System;

namespace Delegues
{
    class Program
    {
        public delegate void Delegue(string message);

        static void Main(string[] args)
        {
            var monDelegue = new Delegue(AfficherMessageErreur);
            monDelegue += AfficherMessage;

            Console.WriteLine("Entier 1:");
            var entier1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entier 2:");
            var entier2 = int.Parse(Console.ReadLine());

            CalculerSomme(entier1, entier2, monDelegue);

            Console.ReadKey();
        }

        public static void CalculerSomme(
            int entier1, 
            int entier2,
            Delegue methodePourAfficher)
        {
            var resultat = entier1 + entier2;
            methodePourAfficher($"Le résultat: {resultat}");
        }

        public static void AfficherMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int SaisirEntier(string message)
        {
            Console.WriteLine("Entier1:");
            return int.Parse(Console.ReadLine());
        }

        public static void AfficherMessageErreur(string texte)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texte);
            Console.ResetColor();
        }
    }
}
