using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMetier.Data;
using AppMetier.Properties;

namespace AppMetier
{
    internal partial class ResultWindow : Form
    {
        internal ResultWindow(Dictionary<Ressource, int> allNeededRessources)
        {
            InitializeComponent();

            var allRessourceType = allNeededRessources.Select(x => x.Key.RessourceType).ToList();

            var groupes = new Dictionary<string, ListViewGroup>();
            foreach (var ressource in allRessourceType)
            {
                var group = new ListViewGroup(ressource.ToString());
                groupes[ressource.ToString()] = group;
                Ressources_ListView.Groups.Add(group);

            }
            double prixTotal = 0;

            foreach (var res in allNeededRessources.OrderBy(r => r.Key.RessourceType))
            {
                double total = res.Key.PrixMoyen * res.Value;

                var item = new ListViewItem(res.Key.Name);
                item.SubItems.Add(res.Value.ToString());
                item.SubItems.Add(res.Key.PrixMoyen.ToString("N0"));
                item.SubItems.Add(total.ToString("N0"));
                item.Group = groupes[res.Key.RessourceType.ToString()];

                Ressources_ListView.Items.Add(item);
                prixTotal += total;
            }
            PrixTotal_Label.Text = $"Prix total : {prixTotal:N0} K";
        }
    }
}
