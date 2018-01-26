using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // TP 04.3
            #region Exo 01
            /*
            int resultas = 0; 
            Console.Write("Saisir une valeur :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Saisir une valeur :");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                resultas += a ;
            }

            Console.WriteLine(resultat);
            Console.ReadKey();
            */
            #endregion

            #region Exo 02
            /*
            int reste = 0, resultat =0;
            Console.Write("Saisir une valeur :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Saisir une valeur :");
            int b = Convert.ToInt32(Console.ReadLine());

            reste = b;

            while (a >= b)
            {
                a -= b;
                reste = a;
                resultat++;
            }
            Console.WriteLine("Le resultat est {0} et il reste {1}",resultat,reste);
            Console.ReadKey();
            */
            #endregion

            #region Exo 03
            /*
            Console.Write("Saisir une valeur entière:");
            int eDec = Convert.ToInt32(Console.ReadLine());
            string eBin = Convert.ToString(eDec, 2);

            Console.WriteLine("La valeur {0} donne {1} en binaire",eDec, eBin);
            Console.ReadKey();
            */
            #endregion

        }
    }
}
