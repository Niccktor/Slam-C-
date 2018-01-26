using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Puissance_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grille = new int[10, 10];
            grille = grilleInit(grille);

            affichageJoueur(grille);
            Console.ReadKey();





        }
        static int[,] grilleInit(int[,] grille)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grille[i, j] = 0;                   
                }
            }
            return grille;
        }
        private static void affichageJoueur(int[,] grille)
        {
            Console.WriteLine("| A | B | C | D | E | F | G | H | I | J |");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("|", i);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" ");
                    if (grille[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (grille[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else if (grille[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(grille[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }

        static int convertToX(char caractere)
        {
            char[] carac = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            int x = 0;
            for (int i = 0; i < carac.Length; i++)
            {
                if (carac[i] == caractere)
                {
                    x = i;
                }
            }
            return x;
        }
        static int saisieX()
        {
            string vS;
            while (true)
            {
                vS = Console.ReadLine();
                if (vS == "A" || vS == "B" || vS == "C" || vS == "D" || vS == "E" || vS == "F" || vS == "G" || vS == "H" || vS == "I" || vS == "J")
                {
                    return convertToX(Convert.ToChar(vS));
                }
            }
        }

        static int [,] addPion (int[,] grille, int numJoueur)
        {
            int vS = saisieX();
            for (int i = 0; i < 10; i++)
            {
                if (grille[vS, i] == 0)
                {
                    Console.Clear();
                    if (grille[vS, i] != 0)
                    {
                        return grille;
                    }
                    if (i == 0)
                    {
                        grille[vS, i] = numJoueur;
                    }
                    else
                    {
                        grille[vS, i - 1] = 0;
                        grille[vS, i] = numJoueur;
                    }
                    affichageJoueur(grille);
                    Thread.Sleep(200);

                }
            }
        }
    }
}
