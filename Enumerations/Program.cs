using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenement = new Evenement();
            evenement.JourSemaine = JourSemaine.Mardi;

            Console.ReadKey();
        }
    }

}
