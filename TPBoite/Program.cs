using System;

namespace TPBoite
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite uneBoite = new Boite(4, 5, 6);

            uneBoite.Hauteur = 8;

            if (uneBoite.IsCube())
            {
                Console.WriteLine("cette boite est un cube.");
            }
            else
            {
                Console.WriteLine("Cette boite n'est pas un cube.");
            }

            Boite uneAutreBoite = new Boite(8, 5, 4);

            if (uneBoite.SameVolume(uneAutreBoite))
            {
                Console.WriteLine("Les deux boite sont de même volume.");
            }
            else
            {
                Console.WriteLine("Les deux boite ne sont pas de même volume.");
            }
            Console.ReadKey();
        }
    }
}
