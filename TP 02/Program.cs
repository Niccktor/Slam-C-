using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP 02            
            #region Exo 01
            /*
            String valeurSaisie;

            Console.WriteLine("Saisir une valeur:");
            valeurSaisie = Console.ReadLine();
            decimal premeirNombres = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Saisir une seconde valeur:");
            valeurSaisie = Console.ReadLine();
            decimal deuxiemeNombres = Convert.ToDecimal(valeurSaisie);

            if (premeirNombres < deuxiemeNombres)
            {
                Console.WriteLine("Le plus petit des deux nombres est {0}", premeirNombres);
            }
            else
            {
                Console.WriteLine("Le plus petit des deux nombres est {0}", deuxiemeNombres);
            }
            Console.ReadKey();
            */
            #endregion

            #region Exo 02
            /*
            String valeurSaisie;

            Console.WriteLine("Quel est le chiffre d'affaire?");
            valeurSaisie = Console.ReadLine();
            Decimal chiffreAffaire = Convert.ToDecimal(valeurSaisie);

            if (chiffreAffaire > 1000)
            {
                decimal pourcentagePrime = 0.04m;
                decimal prime = chiffreAffaire * pourcentagePrime;
                Console.WriteLine("La prime sera de {0} euros", prime);
            }
            else
            {
                Console.WriteLine("Le chiffre d'affaire est inferieur à 1 000 euros donc il n'y a pas de prime.");
            }
            Console.ReadKey();            
            */
            #endregion
                        
            #region Exo 03
            /*
            String valeurSaisie;

            Console.WriteLine("Quel est le nombres d'articles?");
            valeurSaisie = Console.ReadLine();
            int nbArticles = Convert.ToInt32(valeurSaisie);

            if (nbArticles < 10)
            {
                int prixTotale = nbArticles * 150;
                Console.WriteLine("Le prix unitaire est de 150 euros donc le prix de tous les articles est de {0} euros", prixTotale);
            }
            else if (nbArticles < 50)
            {
                int prixTotale = nbArticles * 135;
                Console.WriteLine("Le prix unitaire est de 135 euros donc le prix de tous les articles est de {0} euros", prixTotale);
            }

            else
            {
                int prixTotale = nbArticles * 110;
                Console.WriteLine("Le prix unitaire est de 110 euros donc le prix de tous les articles est de {0} euros", prixTotale);
            }
            Console.ReadKey();
            */
            #endregion
                       
            #region Exo 04
            /*
            String valuerSaisie;

            Console.WriteLine("Quels est votre note a l'examen?");
            valuerSaisie = Console.ReadLine();
            decimal noteExamen = Convert.ToDecimal(valuerSaisie);

            if (noteExamen < 8)
            {
                Console.WriteLine("Ajourné");
            }
            else if (noteExamen < 10)
            {
                Console.WriteLine("Oral");
            }
            else
            {
                Console.WriteLine("Admis");
            }
            Console.ReadKey();
            */
            #endregion
                        
            #region Exo 05
            /*
            string valeurSaisie;

            Console.WriteLine("Veuillez saisir un premier nombre.");
            valeurSaisie = Console.ReadLine();
            decimal premierNombre = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Veuillez saisir un second nombre.");
            valeurSaisie = Console.ReadLine();
            decimal secondNombre = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Veuillez saisir un troisieme nombre.");
            valeurSaisie = Console.ReadLine();
            decimal troisiemeNombre = Convert.ToDecimal(valeurSaisie);

            if (premierNombre < secondNombre && premierNombre < troisiemeNombre)
            {
                Console.WriteLine("Le plus petit chiffre est le {0}", premierNombre);
            }
            else if (secondNombre < troisiemeNombre) 
            {
                Console.WriteLine("Le plus petit chiffre est le {0}", secondNombre);
            }
            else
            {
                Console.WriteLine("Le plus petit chiffre est le {0}", troisiemeNombre);
            }
            Console.ReadKey();
            */
            #endregion
                        
            #region Exo 06

            string valeursaisie;

            Console.WriteLine("Quel est le nombres d'exemplaires?");
            valeursaisie = Console.ReadLine();
            int nbEx = Convert.ToInt32(valeursaisie);

            Console.WriteLine("Quel est le nombres d'etoile?");
            valeursaisie = Console.ReadLine();
            int nbEtoile = Convert.ToInt32(valeursaisie);
            

            Console.WriteLine("Quel est le type de vente?");
            string typeVente = Console.ReadLine();

            decimal prixAchat = 0;
            
            switch (nbEtoile)
            {
                case 1 :
                    prixAchat = nbEx * 3;
                    Console.WriteLine("Le montant de l'achat sera de {0} euros.",prixAchat);
                   break;

                case 2 :
                    prixAchat = nbEx * 5;
                    Console.WriteLine("Le montant de l'achat sera de {0} euros.", prixAchat);
                    break;

                case 3:
                    prixAchat = nbEx * 6.5m;
                    Console.WriteLine("Le montant de l'achat sera de {0} euros.", prixAchat);
                    break;
            }

            decimal reduction = 0; 

            if (nbEx < 20)
            {
                Console.WriteLine("Il n'y a aucune reduction.",nbEx);
            }
            else 
            {
                reduction = prixAchat * 0.1m;
                Console.WriteLine("La reduction est de {0} euros pour les {1} livres.",reduction,nbEx);
            }
            decimal port = 0, prix = 0;

            switch (typeVente)
            {
                case "M" :
                    prix = prixAchat - reduction;
                    Console.WriteLine("La vente est en magasin, le prix a payer est de {0} euros",prix);
                    break;

                case "C":
                    
                    if (prixAchat < 25 )
                    {
                        port = prixAchat * 0.2m;
                        prix = prixAchat + port - reduction;
                        Console.WriteLine("Vente par correspondance, les frais de port sont de {0} euros et le prix à payer est {1} euros.", port,prix);
                    }
                    else
                    {
                        prix = prixAchat - reduction;
                        Console.WriteLine("Vente par correspondance sans frais de port et le prix à payer est {0} euros.", prix);
                    }          
                    break;
            }
            Console.ReadKey();
            #endregion

        }
    }
}
