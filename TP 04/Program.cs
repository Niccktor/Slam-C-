using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP 04 
            #region Exo 01
            /*
            string valeurSaisie;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length ; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie=Console.ReadLine());                            
            }
            */
            #endregion

            #region Exo 02
            /*
            string valeurSaisie;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie = Console.ReadLine());

                for (int i = 0; i < tab.Length ; i++)
            {
                Console.WriteLine("les valeur saisie sont: {0}",tab[i]);
            }

            Console.ReadKey();
            */
            #endregion

            #region Exo 03
            /*
            string valeurSaisie;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie = Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("les valeur saisie sont: {0}", tab[i]);
                }
            }

            Console.ReadKey();  
            */
            #endregion

            #region Exo 04
            /*
            string valeurSaisie;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie = Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if(tab[i] % 2 == 0)
                {
                    Console.WriteLine("les valeur saisie sont paires sont: {0}", tab[i]);
                }
            }

            Console.ReadKey();
            */
            #endregion

            #region Exo 05
            /*
            string valeurSaisie;
            int valeurMax = 0;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie = Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if(valeurMax < tab[i])
                {
                    valeurMax = tab[i];
                }
            }
            Console.WriteLine("La valeur maximale est: {0}",valeurMax);

            Console.ReadKey();
            */
            #endregion

            #region Exo 06
            /*
            string valeurSaisie;
            int valeurMin = 0;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie = Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (valeurMin > tab[i])
                {
                    valeurMin = tab[i];
                }
            }
            Console.WriteLine("La valeur minimale est: {0}", valeurMin);

            Console.ReadKey();
            */
            #endregion

            #region Exo 07
            /*
            string valeurSaisie;
            int somme = 0;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie = Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
            {
                somme = somme + tab[i];
            }
            Console.WriteLine("La somme est: {0}", somme);
            Console.ReadKey();
            */
            #endregion

            #region Exo 08
            /*
            string valeurSaisie;
            int calcul = 0;
            decimal moyenne = 0;
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                tab[i] = Convert.ToInt32(valeurSaisie = Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
            {
                calcul = calcul + tab[i];
            }
            moyenne = calcul / tab.Length;

            Console.WriteLine("La valeur moyenne est: {0}", moyenne);
            Console.ReadKey();
            */
            #endregion

            #region Exo 09
            /*
            int compteurDeNbPremierAssigner = 0;
            int compteurDeMultipleAssigner = 0;
            bool PremierTrouver = true; 

            Console.WriteLine("Saisir N");
            int primeNbMax = Convert.ToInt32(Console.ReadLine());
            int[] tabNbPrime = new int[primeNbMax];
            int[] tabMultiple = new int[primeNbMax * primeNbMax];

            for (int i = 2; i <= tabNbPrime.Length ; i++)
            {
                for (int j = 0; j < compteurDeMultipleAssigner+1 ; j++)
                {
                   if (i == tabMultiple[j] && PremierTrouver == true)
                    {
                        PremierTrouver = false;
                    }                   
                }                

                if ( PremierTrouver == true)
                {
                    tabNbPrime[compteurDeNbPremierAssigner] = i ;
                    compteurDeNbPremierAssigner++;
                    for (int j = 0; j < tabNbPrime.Length; j++)
                    {
                        tabMultiple[compteurDeMultipleAssigner] = i * (j+2);
                        compteurDeMultipleAssigner++;
                    }
                }
                else
                {
                    PremierTrouver = true;
                }
                   
            }
            Console.Write("Les nombres premier sont:");

            for (int i = 0; i < compteurDeNbPremierAssigner; i++)
            {
                Console.Write(" {0},",tabNbPrime[i]);
            }
            
            Console.ReadKey();
            */
            #endregion

            #region Exo 10 Tri à bulles
            /*
            Console.WriteLine("Quel est la taille du tableau?");
            int[] tableau = new int[Convert.ToInt32(Console.ReadLine())];
            int tailleTableau = tableau.Length, tempos = 0,i;
            
            for (int j = 0; j < tableau.Length; j++)
            {
                Console.WriteLine("Quel sont les valeurs du tableau?");
                tableau[j] = Convert.ToInt32(Console.ReadLine());
            }

            while (tailleTableau > 0)
            {
                for (i = 0; i < tailleTableau - 1; i++)
                {
                    if (tableau[i] < tableau[i + 1])
                    {
                        tempos = tableau[i];
                        tableau[i] = tableau[i + 1];
                        tableau[i + 1] = tempos;
                    }                    
                }
                tailleTableau--;
                Console.WriteLine(tableau[i]);
            }

            Console.ReadLine();
            */
            #endregion

            #region Exo 11 Tri par insertion

            int valeurSaisie;

            Console.WriteLine("Quel est la taille du tableau?");
            int[] tableau = new int[Convert.ToInt32(Console.ReadLine())];
            int tailleTableau = tableau.Length, tempos = 0;

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Quel sont les valeurs du tableau?");
                valeurSaisie = Convert.ToInt32(Console.ReadLine());

                if (valeurSaisie > tableau[i])
                {
                    tempos = tableau[i];
                    tableau[i] = valeurSaisie;
                    for (int j = i + 1; j < tableau.Length - i; j++)
                    {
                        tableau[j] = tempos;
                    }

                }
            }
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
            Console.ReadKey();
            #endregion
        }
    }
}