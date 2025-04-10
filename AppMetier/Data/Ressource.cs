namespace AppMetier.Data
{
    public enum RessourceType
    {
        Unknown,
        Paysan,
        Alchimie,
        Random,
        Chasseur
    }

    internal class Ressource
    {
        public string Name { get; set; }

        public int PrixMoyen { get; set; }

        public RessourceType RessourceType { get; set; }

        public Ressource(string name, int prixMoyen, RessourceType ressourceType)
        {
            this.Name = name;
            this.PrixMoyen = prixMoyen;
            this.RessourceType = ressourceType;
        }
    }
}
