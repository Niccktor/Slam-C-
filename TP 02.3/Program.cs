using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string valeurSaisie;
            decimal valeurTempos;

            Console.WriteLine("Saisir une valeur:");
            valeurSaisie = Console.ReadLine();
            decimal premeirNombres = Convert.ToDecimal(valeurSaisie);

            Console.WriteLine("Saisir une seconde valeur:");
            valeurSaisie = Console.ReadLine();
            decimal deuxiemeNombres = Convert.ToDecimal(valeurSaisie);

            decimal somme = premeirNombres + deuxiemeNombres;
            decimal produit = premeirNombres * deuxiemeNombres;
            decimal valeurMini = -5986;

            valeurTempos = premeirNombres;

            if (valeurTempos >= premeirNombres) 
            {
                valeurMini = premeirNombres;
                valeurTempos = premeirNombres;
            }

            if (valeurTempos >= deuxiemeNombres) 
            {
                valeurMini = deuxiemeNombres;
                valeurTempos = deuxiemeNombres;
            }

            if (valeurTempos >= somme) 
            {
                valeurMini = somme;
                valeurTempos = somme;
            }

            if (valeurTempos >= produit) 
            {
                valeurMini = produit;
                valeurTempos = produit;
            }
           
                
                
            
          
        }
    }
}
