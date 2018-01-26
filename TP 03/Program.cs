using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP 03
            #region Exo 01
            /*
            string valeurSaisie;
            string chaineEtoile = "";

            Console.WriteLine("Saisir une valeur :");
            valeurSaisie = Console.ReadLine();
            int nbEtoile = Convert.ToInt32(valeurSaisie);

            while (nbEtoile > 0)
            {
                chaineEtoile += "*";
                nbEtoile -= 1;            
            }
            Console.WriteLine(chaineEtoile);
            Console.ReadKey();
            */
            #endregion

            #region Exo 02
            /*
            string valeurSaisie;
            string chaineEtoile = "";

            Console.WriteLine("Saisir une valeur :");
            valeurSaisie = Console.ReadLine();
            int nbEtoile = Convert.ToInt32(valeurSaisie);

            while (nbEtoile > 0)
            {
                chaineEtoile += "*";
                nbEtoile -= 1;
                if (chaineEtoile == "*****")
                {
                    Console.WriteLine(chaineEtoile);
                    chaineEtoile = "";
                }
            }
            Console.WriteLine(chaineEtoile);

            Console.ReadKey();
            */
            #endregion

            #region Exo 03
            /*
            string valeurSaisie;
            string chaineFin = "";

            Console.WriteLine("Saisir une valeur :");
            valeurSaisie = Console.ReadLine();
            int nbEtoile = Convert.ToInt32(valeurSaisie);
            int EouD = 0;    // Etoile = 0 Dollar = 1
            int etoile = 0;
            while (nbEtoile > 0)
            {                               
                etoile++;
                nbEtoile -= 1;
                if (etoile == 5 && EouD == 0)
                {
                    Console.WriteLine("*****");
                    etoile = 0;
                    EouD = 1;
                }
                if (etoile == 5 && EouD == 1)
                {
                    Console.WriteLine("$$$$$");
                    etoile = 0;
                    EouD = 0;
                }
            }
            if (EouD == 0)
            {
                while (etoile > 0)
                {
                    chaineFin += "*";
                    etoile -= 1;
                }

            }
            else
            {
                while (etoile > 0)
                {
                    chaineFin += "$";
                    etoile -= 1;
                }
            }            
            Console.WriteLine(chaineFin);
            Console.ReadKey();
            */
            #endregion

            #region Exo 04
            /*
            string valeurSaisie;
            string etoileCarre = "";

            Console.WriteLine("Saisir la taille d'un côté du carré :");
            valeurSaisie = Console.ReadLine();
            int longuerCarre = Convert.ToInt32(valeurSaisie), largeurCarre = Convert.ToInt32(valeurSaisie);

            while (longuerCarre > 0)
            {
                while (largeurCarre > 0)
                {
                    etoileCarre += "*";
                    largeurCarre --;
                }
                Console.WriteLine(etoileCarre);
                longuerCarre --;
            }            
            Console.ReadKey();
            */
            #endregion

            #region Exo 05 
            /*
            string valeurSaisie;
            string etoileLargeurCarre = "";
            string etoileCorpsCarre = "";

            Console.WriteLine("Saisir la taille d'un côté du carré :");
            valeurSaisie = Console.ReadLine();
            int longuerCarre = Convert.ToInt32(valeurSaisie), largeurCarre = Convert.ToInt32(valeurSaisie), largeurCorpsCarre = Convert.ToInt32(valeurSaisie);

            while (largeurCarre > 0)
            {
                etoileLargeurCarre += "*";
                largeurCarre --;
            }
            for (int i = 1; i > 0 ; i--)
            {
                etoileCorpsCarre += "*";
                largeurCorpsCarre --;
            }
            while(largeurCorpsCarre > 1)
            {
                etoileCorpsCarre += " ";
                largeurCorpsCarre --;
            }
            for (int i = 1; i > 0; i--)
            {
                etoileCorpsCarre += "*";
                largeurCorpsCarre--;
            }
            for (int i = 1; i > 0; i--)
            {
                Console.WriteLine(etoileLargeurCarre);
                longuerCarre--;
            }
            while (longuerCarre > 1)
            {
                Console.WriteLine(etoileCorpsCarre);
                longuerCarre--;
            }
            for (int i = 1; i > 0; i--)
            {
                Console.WriteLine(etoileLargeurCarre);
                longuerCarre--;
            }

            Console.ReadKey();
            */
            #endregion

            #region Exo 06
            /*
            string valeurSaisie;
                       
            Console.WriteLine("Saisir une valeur: ");
            valeurSaisie = Console.ReadLine();
            int valeurFactorielle = Convert.ToInt32(valeurSaisie);
            int resultatFactorisation = 1, reste = 0, ancienResultatFactorisation = 0;
            int factorielle = 0;
                       
            while (valeurFactorielle != resultatFactorisation)
            {
                factorielle++;
                ancienResultatFactorisation = resultatFactorisation;
                resultatFactorisation = factorielle * resultatFactorisation;
                if (resultatFactorisation > valeurFactorielle)
                {
                    reste = valeurFactorielle - ancienResultatFactorisation;
                    factorielle--;
                    break;
                }                
            }
            Console.WriteLine("La factorielle de {0} est fact({1}) + {2}",valeurFactorielle, factorielle, reste);
            Console.ReadKey();
            */
            #endregion

            #region Exo 07
            /*
            string valeurSaisie;

            Console.WriteLine("Saisir une valeur :");
            valeurSaisie = Console.ReadLine();
            int valeur = Convert.ToInt32(valeurSaisie), valeurFix = Convert.ToInt32(valeurSaisie);
            int terme2 = 0, terme1 = 1;
            int resultatTerme = 0; 
            
            if (valeur == 0)
            {
                Console.WriteLine("F0 = 0");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (valeur == 1)             
            {
                Console.WriteLine("F1 = 1");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            while (valeur > 1)
            {
                resultatTerme = terme2 + terme1;
                valeur = valeur - 1;
                if (valeur == 1)
                {
                    break;
                }
                terme2 = terme1;
                terme1 = resultatTerme;
            }          
            Console.WriteLine("F{0} = {1} les terme précédents sont :\nF{2} = {3}\nF{4} = {5}  ",valeurFix,resultatTerme,valeurFix - 1,terme1, valeurFix - 2, terme2);
            Console.ReadKey();
            */


            #endregion

            //TP 03 Suite 

            #region Exo 01 
            /*
            string valeurSaisie;
            int resultats = 0;

            Console.WriteLine("Saisir une 1er valeur :");
            int valeur1 = Convert.ToInt32(valeurSaisie = Console.ReadLine());
            
            Console.WriteLine("Saisir une 2eme valeur :");            
            int valeur2 = Convert.ToInt32(valeurSaisie = Console.ReadLine());

            for (int i = 0; i < valeur2; i++)
            {
                resultats = resultats + valeur1;
            }
            Console.WriteLine(resultats);            
            Console.ReadKey();
            */
            #endregion

            #region Exo 02
            /*
            string valeurSaisie;
            int quotient = 0 , reste = 0;

            Console.WriteLine("Saisir une 1er valeur :");
            int valeurA = Convert.ToInt32(valeurSaisie = Console.ReadLine());

            Console.WriteLine("Saisir une 2eme valeur :");
            int valeurB = Convert.ToInt32(valeurSaisie = Console.ReadLine());
           
            while (valeurA >= valeurB)
            {
                valeurA= valeurA - valeurB;
                reste = valeurA ;
                quotient++;  
            }
            Console.WriteLine("Le quotient est de {0} et il reste {1}", quotient, reste);
            Console.ReadKey();
            */
            #endregion        

            #region Exo 03
            /*
            string valeurSaisie;
            int plusGrandDiviseur = 0;
            int calcul = 0;
            Console.WriteLine("Saisir une 1er valeur : (Supérieur à 100)");
            int valeur = Convert.ToInt32(valeurSaisie = Console.ReadLine());

            for(int i = 2; i <= 100 ; i++)
            {
                calcul = valeur % i;
                if (calcul == 0)
                {
                    plusGrandDiviseur = i;
                }
                
            }
            if (plusGrandDiviseur == 0)
            {
                Console.WriteLine("Le nombre choisi est nombre premier");
            }
            else
            {
            Console.WriteLine("Le plus grand diviseur compris entre 2 et 100 est: {0}", plusGrandDiviseur);

            }
            Console.ReadKey();
            */
            #endregion
        }
    }
}
