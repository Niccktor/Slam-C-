using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grille = new int[6, 7];
            int vS;
            grille = init(grille);
            Console.Write("Saisir le nom du joueur 1 : ");
            string nomJoueur1 = Console.ReadLine();

            Console.Write("Saisir le nom du joueur 2 : ");
            string nomJoueur2 = Console.ReadLine();

            Console.Clear();

            do
            {
                Grille(grille);
                nomJoueur(nomJoueur1);
                Console.WriteLine("Saisir la colonne.");
                vS = saisieY();
                ajout(grille, vS, 1);

                



            } while (true);


        }
        private static void Grille(int[,] grille)
        {
            Console.WriteLine("| A | B | C | D | E | F | G |");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("|", i);
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(" ");
                    if (grille[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
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
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        private static void nomJoueur(string nom)
        {
            int taille = Console.WindowWidth;
            Console.SetCursorPosition(taille / 2, 2);
            Console.WriteLine("A vous de jouez {0}", nom);
            Console.SetCursorPosition(0, 11);
        }

        static int[,] ajout(int[,] grille,int vS, int joueur)
        {







            return grille;
        }
        static int saisieY()
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
        static int[,] init(int[,] grille)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    grille[i, j] = 0;
                }
            }
            return grille;
        }

    }
}
