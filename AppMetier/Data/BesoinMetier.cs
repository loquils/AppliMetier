using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMetier.Data
{
    public enum MetierType
    {
        Paysan
    }

    internal class BesoinMetier
    {
        internal int NiveauDebut { get; set; }

        internal int NiveauFin { get; set; }

        internal MetierType Metier { get; set; }

        internal Dictionary<Craft, int> QuantiteeCraft { get; set; }

        internal BesoinMetier(MetierType metier, int niveauDebut, int niveauFin, Craft craft, int quantitee)
        {
            Metier = metier;
            NiveauDebut = niveauDebut;
            NiveauFin = niveauFin;
            QuantiteeCraft = new Dictionary<Craft, int>
            {
                [craft] = quantitee
            };
        }
    }
}
