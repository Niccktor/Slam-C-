using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_03_Prof
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Exercice 1

            //Console.WriteLine("Saisir une valeur");
            //string chaineSaisie = Console.ReadLine();
            //int nbEtoiles = Convert.ToInt32(chaineSaisie);
            //for (int i = 0; i < nbEtoiles; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Exercice 2

            //Console.WriteLine("Saisir une valeur");
            //string chaineSaisie = Console.ReadLine();
            //int nbEtoiles = Convert.ToInt32(chaineSaisie);
            //for (int i = 1; i <= nbEtoiles; i++)
            //{
            //    Console.Write("*");
            //    int modulo = i % 5;
            //    if (modulo == 0)
            //    {
            //        Console.WriteLine();
            //    }

            //}

            #endregion

            #region Exercice 3

            //Console.WriteLine("Saisir une valeur");
            //int valeurSaisie = int.Parse(Console.ReadLine());
            //char car = '*';
            //for (int i = 1; i <= valeurSaisie; i++)
            //{
            //    Console.Write(car);
            //    if (i % 5 == 0)
            //    {
            //        if (car == '*')
            //        {
            //            car = '$';
            //        }
            //        else
            //        {
            //            car = '*';
            //        }
            //        Console.WriteLine();
            //    }
            //}

            #endregion

            #region Exercice 4

            //Console.WriteLine("Saisir une valeur");
            //string valeurSaisie = Console.ReadLine();
            //int valeur = Convert.ToInt32(valeurSaisie);
            //for (int i = 1; i <= valeur * valeur; i++)
            //{
            //    Console.Write("*");
            //    if (i % valeur == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}



            //Avec deux boucles

            //Console.WriteLine("Saisir une valeur");
            //string chaineSaisie = Console.ReadLine();
            //int valeurSaisie = Convert.ToInt32(chaineSaisie);
            //for (int i = 1; i <= valeurSaisie; i++)
            //{
            //    for (int y = 0; y < valeurSaisie; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Exercice 5

            Console.WriteLine("Saisie N");
            string valeurSaisie = Console.ReadLine();
            int n = Convert.ToInt32(valeurSaisie);

            for (int i = 0; i < n * n; i++)
            {
                /*
                  Prendre en charge le saut de ligne
                  A chaque multiple de N
                */
                if (i % n == 0)
                {
                    Console.WriteLine("");
                }
                /*
                  Afficher les étoiles de la première ligne
                 */
                if (i < n)
                {
                    Console.Write("*");
                }
                /*
                  Afficher les étoiles de la dernière ligne
                 */
                else if (i >= n * n - n)
                {
                    Console.Write("*");
                }
                /*
                  Afficher les étoiles de début et de fin de ligne
                 */
                else if (i % n == 0 || (i + 1) % n == 0)
                {
                    Console.Write("*");
                }
                /*
                  Sinon, on affiche des espaces                 
                 */
                else
                {
                    Console.Write(" ");
                }
            }

            #endregion

            #region Exercice 6

            //Console.WriteLine("Saisir une valeur");
            //string chaineSaisie = Console.ReadLine();
            //int valeurSaisie = Convert.ToInt32(chaineSaisie);
            //float fact = 1;
            //for (int i = 1; i <= valeurSaisie; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.Write("factorielle de {0} : {1} ", valeurSaisie, fact);

            #endregion

            #region Exercice 7

            //int fib_0 = 0;
            //int fib_1 = 1;

            //int fib_2 = fib_1 + fib_0;
            //int fib_3 = fib_2 + fib_1;
            //int fib_4 = fib_3 + fib_2;
            ////Conclusion, il s'agit de répéter une somme

            //int fib_n = 0; //Le fib recherché (n)

            ///*
            // * Les fib de départ
            // * */
            //int fib_nMoins1 = 1; //Le fib de 1
            //int fib_nMoins2 = 0; //Le fib de 0

            ////Etape 1 : la répétition
            //for (int i = 0; i < 6; i++)
            //{
            //    fib_n = fib_nMoins1 + fib_nMoins2; //on calcul le fib courant
            //    Console.WriteLine(fib_n);//seul le fil courant s'affice
            //}

            ////Etape 2 : la permutation
            //for (int i = 0; i < 6; i++)
            //{
            //    fib_n = fib_nMoins1 + fib_nMoins2; //on calcul le fib courant
            //    fib_nMoins2 = fib_nMoins1; //Le fib de n-1 devient le fib de n-2
            //    fib_nMoins1 = fib_n; //Le fib courant devient le fib de n-1 ;
            //    Console.WriteLine(fib_n);//seul le fil courant s'affiche
            //}

            ////Etape 3 : le nombre d'itération
            //Console.WriteLine("Fib de ?");
            //string ChaineSaisie = Console.ReadLine();
            //int valeurSaisie = int.Parse(ChaineSaisie);
            //for (int i = 0; i < valeurSaisie - 1; i++)
            //{
            //    fib_n = fib_nMoins1 + fib_nMoins2; //on calcul le fib courant
            //    fib_nMoins2 = fib_nMoins1; //Le fib de n-1 devient le fib de n-2
            //    fib_nMoins1 = fib_n; //Le fib courant devient le fib de n-1 ;
            //}
            //Console.WriteLine(fib_n);//Le FIB  final

            //Console.WriteLine("saisir une valeur entière");
            //string chaineSaisie = Console.ReadLine();
            //int valeurSaisie = Convert.ToInt32(chaineSaisie);
            //int fib = 0;

            //int a = 0;
            //int b = 1;

            //if (valeurSaisie == 0)
            //{
            //    fib = 0;

            //}
            //else if (valeurSaisie == 1)
            //{
            //    fib = 1;
            //}
            //else
            //{
            //    for (int i = 2; i <= valeurSaisie; i++)
            //    {
            //        fib = a + b; //on calcul de fib de courant
            //        a = b;       //on remplace le fib n-1 par le fib n-2
            //        b = fib;     //on remplace le fib de n-2 par le fib courant
            //    }
            //}
            //Console.WriteLine(fib);

            #endregion FIN FIB

            Console.ReadKey();



        }
    }
}
