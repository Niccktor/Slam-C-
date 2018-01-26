using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP 02.2 
            #region Exo 01
            /*
            string valeurSaisie;

            Console.WriteLine("Bonjour, quel client ete vous?(DeepInside, JBC, autre)");
            string client = Console.ReadLine();

            Console.WriteLine("Quel est la quantité commandée ?");
            valeurSaisie = Console.ReadLine();
            int quantite = Convert.ToInt32(valeurSaisie);

            decimal reductionSupp = 0;

            switch (client)
            {
                case "DeepInside" :
                    reductionSupp = 2;                  
                    break;

                case "JBC":
                    reductionSupp = 1;
                    break;

                case "autre":
                    reductionSupp = 0;
                    break;
            }

            decimal reduction = 0; 

            if (quantite > 40000)
            {
                reduction = 20;
            }
            else if (quantite > 20000)
            {
                reduction = 15;
            }
            else if (quantite > 9999)
            {
                reduction = 10;
            }

            decimal reductionTotal = reduction + reductionSupp;

            Console.WriteLine("Le taux de reduction est de {0} pour les {1} articles.",reductionTotal,quantite);

            Console.ReadKey();
            */
            #endregion

            #region Exo 02
            /*
            string valeurSaisie;
            decimal prixNourriture = 3.5m;

            Console.WriteLine("Quels est le nombres d'élèves qui participe à ce voyage?");
            valeurSaisie = Console.ReadLine();
            int nbEleve = Convert.ToInt32(valeurSaisie);

            decimal prixHebergement;

            if (nbEleve <= 29)
            {
                prixHebergement = 4.75m;
            }
            else if (nbEleve <= 35)
            {
                prixHebergement = 4;
            }
            else
            {
                prixHebergement = 3.5m;
            }
            decimal prixSejour = prixNourriture * nbEleve + prixHebergement * nbEleve;

            Console.WriteLine("Le prix de l'hebergement sera de {0} euros par jour et par élèves.", prixHebergement);
            Console.WriteLine("Le prix journalier du sejour sera de {0} euros par jour pour les {1} eleves", prixSejour, nbEleve);

            Console.ReadKey();
            */
            #endregion

            #region Exo 03

            string valeurSaisie;

            Console.WriteLine("Combien avez vous eu d'accident avec une responsabilité superieur ou egale à 20% pendant l’année écoulée?");
            valeurSaisie = Console.ReadLine();
            int nbAccident = Convert.ToInt16(valeurSaisie);

            Console.WriteLine("Quel est la distance parcouru pendant l'année?");
            valeurSaisie = Console.ReadLine();
            decimal nbDistance = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Quel est le temps d'ancienneté?");
            valeurSaisie = Console.ReadLine();
            int anncienneté = Convert.ToInt32(valeurSaisie);

            int AccidentPrimeFacteur = 0;

            if (nbAccident >= 4)
            {
                Console.WriteLine("La prime est annulée.");
                AccidentPrimeFacteur = 100;
            }
            else if (nbAccident >= 3)
            {
                AccidentPrimeFacteur = 4;
            }
            else if (nbAccident >= 2)
            {
                AccidentPrimeFacteur = 3;
            }
            else if (nbAccident >= 1)
            {
                AccidentPrimeFacteur = 2;
            }
            else
            {
                AccidentPrimeFacteur = 1;
            }

            /*
            switch (nbAccident)
            {
                case 3:
                    AccidentPrimeFacteur = 4;
                    break;
                case 2:
                    AccidentPrimeFacteur = 3;                                // Autre façon Retirer Ligne 118 à 133
                    break;

                case 1:
                    AccidentPrimeFacteur = 2;
                    break;

                case 0:
                    AccidentPrimeFacteur = 1;
                    break;                  
            }
            */

            decimal primeDistance = 0;

            if (AccidentPrimeFacteur != 100)
            {
                primeDistance = nbDistance * 0.01m;
            }
            decimal primeAnncienneté = 0;

            if (AccidentPrimeFacteur != 100 && anncienneté >= 4)
            {
                primeAnncienneté = ((anncienneté - 4) * 20) + 200;
            }

            decimal primeTotal = (primeAnncienneté + primeDistance) / AccidentPrimeFacteur;

            if (AccidentPrimeFacteur != 100)
            {
                Console.WriteLine("Votre prime annuelle sera de {0} euros", primeTotal);
            }

            Console.ReadKey();
            #endregion



        }
    }
}
