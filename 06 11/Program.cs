using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo 01
            /*
            Console.WriteLine("Saisir une valeur entière positive");
            int valeur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liste des diviseurs de {0}", valeur);
            for (int i = 1; i <= valeur; i++)
            {
                if (valeur % i == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.ReadKey();
            */
            #endregion

            #region Exo 02
            /*
            Console.Write("Saisir une population de départ : ");
            decimal popultation = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Saisir un taux de croissance : ");
            decimal croissance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Saisir le temps de croissance :");
            int annees = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= annees; i++)
            {
                popultation = popultation + (popultation * croissance);
                Console.WriteLine("Année {0} Population : {1}", i, popultation);
            }
            Console.ReadKey();
            */
            #endregion
        }
    }
}
