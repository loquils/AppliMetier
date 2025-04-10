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

namespace AppMetier
{
    public partial class MainWindow : Form
    {
        internal InitializeDatas DataBase { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();

            DataBase = new InitializeDatas();

            LvlDepart_ComboBox.DataSource = Enumerable.Range(0, 20).Select(x => x * 10).ToList();
            LvlFin_ComboBox.DataSource = Enumerable.Range(0, 21).Select(x => x * 10).ToList();

            LvlFin_ComboBox.SelectedIndex = 20;
        }



        Dictionary<Ressource, int> CalculQuantiteItems(List<BesoinMetier> besoins)
        {
            var result = new Dictionary<Ressource, int>();
            foreach (var besoin in besoins)
            {
                foreach (var craft in besoin.QuantiteeCraft)
                {
                    foreach (var item in craft.Key.CraftItems)
                    {
                        if (result.ContainsKey(item.Key))
                        {
                            result[item.Key] += item.Value * craft.Value;
                        }
                        else
                        {
                            result[item.Key] = item.Value * craft.Value;
                        }
                    }
                }
            }

            return result.OrderBy(x => (int)x.Key.RessourceType).ToDictionary(x => x.Key, x => x.Value);
        }



        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            int niveauDepart = (int)LvlDepart_ComboBox.SelectedValue;
            int niveauArrivee = (int)LvlFin_ComboBox.SelectedValue;

            var besoinsMetier = DataBase.RechercheBesoin(niveauDepart, niveauArrivee, MetierType.Paysan);

            var allItemsNeeded = CalculQuantiteItems(besoinsMetier);

            var resultWindow = new ResultWindow(allItemsNeeded);
            resultWindow.Show();

            /*RessourceType ressourceType = default;

            var valeurParType = 0;
            var bigTotal = 0;

            foreach (var endItem in allItemsNeeded)
            {
                if (ressourceType == default || ressourceType != endItem.Key.RessourceType)
                {
                    if (valeurParType != 0)
                    {
                        Console.WriteLine($"\n=====> {ressourceType} = {valeurParType} kamas !\n");
                        bigTotal += valeurParType;
                        valeurParType = 0;
                    }

                    Console.WriteLine($"--------{endItem.Key.RessourceType}----------");
                    ressourceType = endItem.Key.RessourceType;
                }

                Console.WriteLine($"{endItem.Key.Name} x{endItem.Value} = {endItem.Key.PrixMoyen * endItem.Value} kamas.");
                valeurParType += endItem.Key.PrixMoyen * endItem.Value;

                if (endItem.Equals(allItemsNeeded.Last()))
                {
                    Console.WriteLine($"\n=====> {ressourceType} = {valeurParType} kamas !\n");
                    bigTotal += valeurParType;
                }

            }

            Console.WriteLine($"\nBig Total ======= {bigTotal} kamas !\n");*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
