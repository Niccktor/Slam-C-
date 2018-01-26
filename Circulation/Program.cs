using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("Peugeot");

            InfoVoiture(voiture);
            Console.WriteLine();
            voiture.DemarrerVoiture();

            InfoVoiture(voiture);
            Console.WriteLine();

            voiture.Accelerer(50);

            InfoVoiture(voiture);
            Console.WriteLine();

            voiture.Decelerer(50);

            InfoVoiture(voiture);
            Console.WriteLine();

            voiture.CouperLeContact();

            InfoVoiture(voiture);
            Console.WriteLine();

            Console.ReadKey();
        }
        static void InfoVoiture(Voiture voiture)
        {
            Console.WriteLine("La marque est : {0}", voiture.Marque);
            Console.WriteLine("Le modele est : {0}", voiture.Modele);
            Console.WriteLine("La voiture est démarer : {0}", voiture.Demarrer);
            Console.WriteLine("La vitesse de la voiture est : {0}", voiture.Vitesse);
            Console.WriteLine("La vitesse maxi de la voiture est : {0}", voiture.VitesseMaxi);
        }
    }
}
