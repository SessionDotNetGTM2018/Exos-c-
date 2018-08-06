using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var entier1 = SaisirEntier("Entre un nombre:");
                var entier2 = SaisirEntier("Entre un autre nombre:");

                var division = entier1 / entier2;

                Console.WriteLine("Bravo!!!!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Euh... ton opération n'est pas possible coco");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Euh..." + exception.Message);
                throw exception;
            }


            Console.ReadKey();
        }

        public static int SaisirEntier(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
