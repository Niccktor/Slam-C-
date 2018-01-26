using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP 01
            #region Exo 01
            /*
            string valeurSaisie;

            Console.WriteLine("Quel est votre premier chiffre?");
            valeurSaisie = Console.ReadLine();
            decimal premierNombre = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Quel est votre deuxieme chiffre?");
            valeurSaisie = Console.ReadLine();
            decimal deuxièmeNombre = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Quel est votre troisieme chiffre?");
            valeurSaisie = Console.ReadLine();
            decimal troisièmeNombre = Convert.ToDecimal(valeurSaisie);

            decimal moyene = (premierNombre + deuxièmeNombre + troisièmeNombre) / 3;
            Console.WriteLine("La moyenne est de {0}",moyene);

            Console.ReadKey();
            */
            #endregion
            
            #region Exo 2
            /*
            string valeurSaisie;

            Console.WriteLine("Quel est le prix unitaire?");
            valeurSaisie = Console.ReadLine();
            decimal prixUnitaire = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Quel est la quantite?");
            valeurSaisie = Console.ReadLine();
            int quantite = Convert.ToInt32(valeurSaisie);
            
            Console.WriteLine("Quel est le taux de la TVA?");
            valeurSaisie = Console.ReadLine();
            decimal TVA = Convert.ToDecimal(valeurSaisie);

            decimal prixHT = prixUnitaire * quantite;
            decimal prixPayer = prixHT * TVA + prixHT;
            Console.WriteLine("Le prix TTC sera de {0} euros.",prixPayer);

            Console.ReadKey();
            */
            #endregion
            
            #region Exo 3 
            /*
            string valeurSaisie;
            
            Console.WriteLine("Quel est le prix unitaire?");
            valeurSaisie = Console.ReadLine();
            decimal prixUnitaire = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Quel est la quantite?");
            valeurSaisie = Console.ReadLine();
            int quantite = Convert.ToInt32(valeurSaisie);

            decimal montantCommande = prixUnitaire * quantite;
            Console.WriteLine("Le montant de la commande est de {0} euros.",montantCommande);
            
            decimal remise = montantCommande * 0.05m;
            Console.WriteLine("La remise est de {0} euros.", remise);

            decimal fraisDePort = montantCommande * 0.02m;
            Console.WriteLine("Les frais de port sont de {0} euros.", fraisDePort);

            decimal prixPayer = montantCommande + fraisDePort - remise;
            Console.WriteLine("Le prix à payer est de {0} euros.", prixPayer);
            Console.ReadKey();
            */
            #endregion
                       
            #region Exo 4
            /*
            string valeurSaisie;

            Console.WriteLine("Nombre d'heure :");
            valeurSaisie = Console.ReadLine();
            int nbHeure = Convert.ToInt16(valeurSaisie);

            Console.WriteLine("Nombre de minutes :");
            valeurSaisie = Console.ReadLine();
            int nbMinutes = Convert.ToInt16(valeurSaisie);

            Console.WriteLine("Nombre de secondes :");
            valeurSaisie = Console.ReadLine();
            int nbSecondes = Convert.ToInt16(valeurSaisie);

            Console.WriteLine("Vous avez saisie {0} heures {1} minutes {2} secondes", nbHeure, nbMinutes, nbSecondes);

            int nbSecondesTotal = nbHeure * 3600 + nbMinutes * 60 + nbSecondes;

            Console.WriteLine("Ce qui correspond à {0} secondes", nbSecondesTotal);
            Console.ReadKey();
            */
            #endregion
        }
    }
}
