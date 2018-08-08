namespace ExemplesLinq
{
    public class Ville
    {
        public string Nom { get; set; }

        public string CodePostal { get; set; }

        public string CodeInsee { get; set; }

        public string Departement
        {
            get { return this.CodePostal.Substring(0, 2); }
        }
    }
}
