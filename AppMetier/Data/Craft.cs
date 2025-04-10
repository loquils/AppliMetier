using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMetier.Data
{
    internal class Craft
    {
        internal string Name { get; set; }

        internal Dictionary<Ressource, int> CraftItems { get; set; }

        internal Craft(string name, List<KeyValuePair<Ressource, int>> listRessourceQuantitee)
        {
            this.Name = name;
            CraftItems = new Dictionary<Ressource, int>();
            foreach (var keyValuePair in listRessourceQuantitee)
            {
                CraftItems[keyValuePair.Key] = keyValuePair.Value;
            }
        }
    }
}
