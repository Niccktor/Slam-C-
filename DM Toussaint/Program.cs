using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Toussaint
{
    class Program
    {
        static void Main(string[] args)
        {
            // DM Toussaint

            #region Exo 01
            /*
            Console.WriteLine("Quel est votre genre ? (F/H)");
            char genre = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Quel est votre age ?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Nombres d'années de permis?");
            int permis = Convert.ToInt16(Console.ReadLine());

            if (permis > 5)
            {
                Console.WriteLine("Vous ne payer pas la surprime.");
                Console.ReadKey();                
                Environment.Exit(0);
            }
            if (genre == 'H' && age > 22)
            {
                Console.WriteLine("Vous payer une surprime.");
            }
            else if (genre == 'F' && age > 19 && age < 31)
            {
                Console.WriteLine("Vous payer une surprime.");
            }
            else
            {
                Console.WriteLine("Vous ne payer pas la surprime.");
            }
            Console.ReadKey();
            */
            #endregion

            #region Exo 02
            /*
            Console.WriteLine("Quel est le jour ?");
            int jour = Convert.ToInt16(Console.ReadLine());
                    
            Console.WriteLine("Quel est le mois ?");
            int mois = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Quel est le année ?");
            int annee = Convert.ToInt32(Console.ReadLine());
            if (mois == 12 && jour == 31)
            {
                jour = 1;
                mois = 1;
                annee++;               
            }
            else if (mois == 2)
            {
                if (jour < 28)
                {
                    jour++;
                }
                else 
                {
                    jour = 1;
                    mois++;
                }
            }
            else if (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10 )
            {
                if (jour < 31)
                {
                    jour++;
                }
                else
                {
                    jour = 1;
                    mois++;
                }
            }
            else
            {
                if (jour < 30)
                {
                    jour++;
                }
                else
                {
                    jour = 1;
                    mois++;
                }
            }
            Console.WriteLine("Demain ce sera le {0}/{1}/{2}",jour,mois,annee);
            Console.ReadKey();
            */
            #endregion

            #region Exo 03
            /*
            Console.WriteLine("Quel est N ?");
            decimal n = Convert.ToInt32(Console.ReadLine());
            decimal resultatsFacto = 1;
            decimal resultats = 1;
            for (int i = 1; i <= n; i++)
            {
                resultatsFacto = resultatsFacto * i;
                resultats = resultats + (1 / resultatsFacto);
            }
            Console.WriteLine(resultats);
            Console.ReadKey();
            */
            #endregion

            #region Exo 04
            /*
            int valeursaisie = 0;
            decimal moyenne = 0;
            int[] tableau = new int[10]; 
           
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Quel sont les valeurs du tableau?");
                valeursaisie = Convert.ToInt32(Console.ReadLine());
                tableau[i] = valeursaisie;
                moyenne += valeursaisie;    
            }
            moyenne = moyenne / tableau.Length;
            Console.WriteLine("Les notes au dessu de la moyenne sont :");
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] >= moyenne)
                {
                    Console.Write("{0} ",tableau[i]);
                }
            }
            Console.ReadKey();
            */
            #endregion

            #region Exo 05
            
            Console.WriteLine("Taille des tableau?");
            int tailleTab = Convert.ToInt32(Console.ReadLine()), resultats = 0, somme=0;

            int[] tableau1 = new int[tailleTab];
            int[] tableau2 = new int[tailleTab];

            for (int i = 0; i < tableau1.Length; i++)
            {
                Console.WriteLine("Valeur du tableau 1:");
                tableau1[i] = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("Valeur du tableau 2:");
                tableau2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < tableau1.Length; i++, tailleTab--)
            {
                resultats = tableau1[i] * tableau2[tailleTab-1];
                somme += resultats;
                Console.WriteLine("{0} * {1} = {2}", tableau1[i], tableau2[tailleTab-1], resultats);
            }
            Console.WriteLine("La somme des produits croisés est égale à {0}.", somme);
            Console.ReadKey();
            
            #endregion
        }
    }
}
