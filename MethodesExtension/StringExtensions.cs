using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodesExtension
{
    public static class StringExtensions
    {
        public static string SupprimerEspaces(this string chaine)
        {
            return SupprimerEspaces(chaine, "");
        }

        public static string SupprimerEspaces(this string chaine, string nouveauCaractere)
        {
            return chaine.Replace(" ", nouveauCaractere);
        }

        public static bool EstVide(this string chaine)
        {
            return string.IsNullOrEmpty(chaine);
        }
    }
}
