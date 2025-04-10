using System.Collections.Generic;
using System.Linq;

namespace AppMetier.Data
{
    internal class InitializeDatas
    {
        internal List<Ressource> ListeRessources;
        internal List<Craft> ListeCrafts;
        internal List<BesoinMetier> ListeBesoinsMetiers;

        internal InitializeDatas()
        {
            ListeRessources = DefineRessourcesList();
            ListeCrafts = DefineCraftsList();
            ListeBesoinsMetiers = DefineBesoinsMetiersList();
        }

        /// <summary>
        /// Initialize la liste de toutes les ressources.
        /// </summary>
        /// <returns></returns>
        List<Ressource> DefineRessourcesList()
        {
            var ressourceList = new List<Ressource>();
            ressourceList.AddRange(InitPaysanRessourcesList());
            ressourceList.AddRange(InitAlchimieRessourcesList());
            ressourceList.AddRange(InitRandomRessourcesList());

            return ressourceList;
        }

        /// <summary>
        /// Initialize la liste de tous les crafts.
        /// </summary>
        /// <returns></returns>
        List<Craft> DefineCraftsList()
        {
            var craftList = new List<Craft>();
            craftList.AddRange(DefineCraftsPaysans());

            return craftList;
        }

        /// <summary>
        /// Initialize la liste de tous les besoins métiers.
        /// </summary>
        /// <returns></returns>
        List<BesoinMetier> DefineBesoinsMetiersList()
        {
            var besoinsMetiersList = new List<BesoinMetier>();
            besoinsMetiersList.AddRange(DefineBesoinPaysans());

            return besoinsMetiersList;
        }

        #region Utils
        /// <summary>
        /// Permet de rechercher les besoins métier correspondants a une tranche de niveaux.
        /// </summary>
        /// <returns>La liste des besoins metier nécessaires.</returns>
        internal List<BesoinMetier> RechercheBesoin(int niveauDepart, int niveauArrivee, MetierType metier)
        {
            List<BesoinMetier> result = new List<BesoinMetier>();
            foreach (var besoin in ListeBesoinsMetiers.Where(x => x.Metier == metier).ToList())
            {
                if (niveauDepart <= besoin.NiveauDebut && niveauArrivee >= besoin.NiveauFin)
                {
                    result.Add(besoin);
                }
            }
            return result;
        }

        /// <summary>
        /// Permet de rechercher une ressource à partir de son nom.
        /// </summary>
        /// <param name="nom">Nom de la ressource.</param>
        /// <returns>La ressource.</returns>
        internal Ressource RechercheRessource(string nom)
        {
            return ListeRessources.First(x => x.Name == nom);
        }

        /// <summary>
        /// Permet de rechercher un Craft à partir de son nom.
        /// </summary>
        /// <param name="nom">Nom du craft.</param>
        /// <returns>Le craft.</returns>
        internal Craft RechercheCraft(string nom)
        {
            return ListeCrafts.First(x => x.Name == nom);
        }

        #endregion

        #region Ressources

        /// <summary>
        /// Definition de la liste des ressources de paysan. 
        /// </summary>
        /// <returns>La liste des ressources.</returns>
        List<Ressource> InitPaysanRessourcesList()
        {
            List<Ressource> listeRessourcesPaysan = new List<Ressource>();
            RessourceType ressourceType = RessourceType.Paysan;
            listeRessourcesPaysan.Add(new Ressource("Blé", 10, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Orge", 22, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Avoine", 23, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Houblon", 21, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Lin", 34, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Seigle", 87, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Malt", 70, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Chanvre", 160, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Maïs", 131, ressourceType));
            listeRessourcesPaysan.Add(new Ressource("Millet", 300, ressourceType));

            return listeRessourcesPaysan;
        }

        /// <summary>
        /// Definition de la liste des ressources d'alchimiste.
        /// </summary>
        /// <returns>La liste des ressources.</returns>
        List<Ressource> InitAlchimieRessourcesList()
        {
            List<Ressource> listeRessourcesAlchi = new List<Ressource>();
            RessourceType ressourceType = RessourceType.Alchimie;
            listeRessourcesAlchi.Add(new Ressource("Ortie", 40, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Sauge", 31, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Trèfle à 5 feuilles", 30, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Menthe sauvage", 38, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Orchidée freyesque", 31, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Edelweiss", 140, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Graine de pandouille", 70, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Ginseng", 160, ressourceType));
            listeRessourcesAlchi.Add(new Ressource("Belladone", 160, ressourceType));

            return listeRessourcesAlchi;
        }

        /// <summary>
        /// Initalisation de la liste de ressources autres.
        /// </summary>
        /// <returns>La liste des ressources.</returns>
        List<Ressource> InitRandomRessourcesList()
        {
            List<Ressource> listeRessourcesRandom = new List<Ressource>();
            RessourceType ressourceType = RessourceType.Random;
            listeRessourcesRandom.Add(new Ressource("Aubergine", 450, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Haricot", 195, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Cendres éternelles", 443, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Cerise", 41, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Sang de scorbute", 420, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Epices", 990, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Eau potable", 67, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Poudre de perlinpainpain", 170, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Poudre temporelle", 305, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Résine", 300, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Mesure de sel", 33, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Mesure de poivre", 80, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Citron", 220, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Feuille de salace", 240, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Huile à frire", 44, ressourceType));
            listeRessourcesRandom.Add(new Ressource("Oignon", 220, ressourceType));

            return listeRessourcesRandom;
        }

        List<Ressource> InitChasseurRessourcesList()
        {
            List<Ressource> listeRessourcesChasseur = new List<Ressource>();
            RessourceType ressourceType = RessourceType.Chasseur;
            listeRessourcesChasseur.Add(new Ressource("Blé", 10, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Orge", 22, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Avoine", 23, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Houblon", 21, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Lin", 34, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Seigle", 87, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Malt", 70, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Chanvre", 160, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Maïs", 131, ressourceType));
            listeRessourcesChasseur.Add(new Ressource("Millet", 300, ressourceType));

            return listeRessourcesChasseur;
        }

        #endregion

        #region Crafts

        /// <summary>
        /// Definie la liste des diférents crafts paysan.
        /// </summary>
        /// <returns></returns>
        List<Craft> DefineCraftsPaysans()
        {
            var ListeCraftsPaysans = new List<Craft>
            {
                new Craft("Pain d'incarnam", new List<KeyValuePair<Ressource, int>>() {new KeyValuePair<Ressource, int>(RechercheRessource("Blé"), 4) }),
                new Craft("Michette", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Blé"), 5) }),
                new Craft("Beignet carasau", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Orge"), 4), new KeyValuePair<Ressource, int>(RechercheRessource("Ortie"), 1) }),
                new Craft("Fougasse", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Orge"), 5), new KeyValuePair<Ressource, int>(RechercheRessource("Ortie"), 1) }),
                new Craft("Pain aux flocons d'avoine", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Avoine"), 5), new KeyValuePair<Ressource, int>(RechercheRessource("Sauge"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Aubergine"), 1) }),
                new Craft("Pain de mie", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Avoine"), 5), new KeyValuePair<Ressource, int>(RechercheRessource("Sauge"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Haricot"), 1) }),
                new Craft("Briochette", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Houblon"), 5), new KeyValuePair<Ressource, int>(RechercheRessource("Trèfle à 5 feuilles"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Cendres éternelles"), 1) }),
                new Craft("Pain consistant", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Houblon"), 5), new KeyValuePair<Ressource, int>(RechercheRessource("Trèfle à 5 feuilles"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Cerise"), 1) }),
                new Craft("Biscotte", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Lin"), 5), new KeyValuePair<Ressource, int>(RechercheRessource("Menthe sauvage"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Sang de scorbute"), 1) }),
                new Craft("Pain d'épice", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Lin"), 5), new KeyValuePair<Ressource, int>(RechercheRessource("Menthe sauvage"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Epices"), 1) }),
                new Craft("Pain de seigle", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Seigle"), 6), new KeyValuePair<Ressource, int>(RechercheRessource("Orchidée freyesque"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Eau potable"), 1) }),
                new Craft("Pain des villes", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Seigle"), 6), new KeyValuePair<Ressource, int>(RechercheRessource("Orchidée freyesque"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Poudre de perlinpainpain"), 1) }),
                new Craft("Pain aux céréales", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Malt"), 6), new KeyValuePair<Ressource, int>(RechercheRessource("Edelweiss"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Poudre temporelle"), 1) }),
                new Craft("Borodinski", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Malt"), 6), new KeyValuePair<Ressource, int>(RechercheRessource("Edelweiss"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Résine"), 1) }),
                new Craft("Pain gre", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Chanvre"), 6), new KeyValuePair<Ressource, int>(RechercheRessource("Graine de pandouille"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Mesure de sel"), 1) }),
                new Craft("Mantou", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Chanvre"), 6), new KeyValuePair<Ressource, int>(RechercheRessource("Graine de pandouille"), 1), new KeyValuePair<Ressource, int>(RechercheRessource("Mesure de poivre"), 1) }),
                new Craft("Tortilla", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Maïs"), 7), new KeyValuePair<Ressource, int>(RechercheRessource("Ginseng"), 2), new KeyValuePair<Ressource, int>(RechercheRessource("Citron"), 1) }),
                new Craft("Pain des champs", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Maïs"), 7), new KeyValuePair<Ressource, int>(RechercheRessource("Ginseng"), 2), new KeyValuePair<Ressource, int>(RechercheRessource("Feuille de salace"), 1) }),
                new Craft("Pain tahde", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Millet"), 7), new KeyValuePair<Ressource, int>(RechercheRessource("Belladone"), 2), new KeyValuePair<Ressource, int>(RechercheRessource("Huile à frire"), 1) }),
                new Craft("Brioche dorée", new List<KeyValuePair<Ressource, int>>() { new KeyValuePair<Ressource, int>(RechercheRessource("Millet"), 7), new KeyValuePair<Ressource, int>(RechercheRessource("Belladone"), 2), new KeyValuePair<Ressource, int>(RechercheRessource("Oignon"), 1) })
            };

            return ListeCraftsPaysans;
        }

        #endregion

        #region Besoins Metiers

        /// <summary>
        /// Definie les quantitée de crafts nécessaires pour monter les niveaux de paysans.
        /// </summary>
        /// <returns></returns>
        List<BesoinMetier> DefineBesoinPaysans()
        {
            MetierType metier = MetierType.Paysan;

            var ListeBesoinsPaysans = new List<BesoinMetier>
            {
                new BesoinMetier(metier, 0, 10, RechercheCraft("Pain d'incarnam"), 77),
                new BesoinMetier(metier, 10, 20, RechercheCraft("Michette"), 507),
                new BesoinMetier(metier, 20, 30, RechercheCraft("Beignet carasau"), 404),
                new BesoinMetier(metier, 30, 40, RechercheCraft("Fougasse"), 367),
                new BesoinMetier(metier, 40, 50, RechercheCraft("Pain aux flocons d'avoine"), 367),
                new BesoinMetier(metier, 50, 60, RechercheCraft("Pain de mie"), 367),
                new BesoinMetier(metier, 60, 70, RechercheCraft("Briochette"), 367),
                new BesoinMetier(metier, 70, 80, RechercheCraft("Pain consistant"), 367),
                new BesoinMetier(metier, 80, 90, RechercheCraft("Biscotte"), 367),
                new BesoinMetier(metier, 90, 100, RechercheCraft("Pain d'épice"), 367),
                new BesoinMetier(metier, 100, 110, RechercheCraft("Pain de seigle"), 367),
                new BesoinMetier(metier, 110, 120, RechercheCraft("Pain des villes"), 367),
                new BesoinMetier(metier, 120, 130, RechercheCraft("Pain aux céréales"), 367),
                new BesoinMetier(metier, 130, 140, RechercheCraft("Borodinski"), 367),
                new BesoinMetier(metier, 140, 150, RechercheCraft("Pain gre"), 367),
                new BesoinMetier(metier, 150, 160, RechercheCraft("Mantou"), 367),
                new BesoinMetier(metier, 160, 170, RechercheCraft("Tortilla"), 367),
                new BesoinMetier(metier, 170, 180, RechercheCraft("Pain des champs"), 367),
                new BesoinMetier(metier, 180, 190, RechercheCraft("Pain tahde"), 367),
                new BesoinMetier(metier, 190, 200, RechercheCraft("Brioche dorée"), 367),
            };

            return ListeBesoinsPaysans;
        }

        #endregion
    }
}
