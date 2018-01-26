using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace Bataille_navale
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer clock = new SoundPlayer();
            SoundPlayer son = new SoundPlayer();
            SoundPlayer sonar = new SoundPlayer();
            SoundPlayer miss = new SoundPlayer();
            SoundPlayer victoireJ1 = new SoundPlayer();
            SoundPlayer victoireJ2 = new SoundPlayer();
            clock.SoundLocation = (Environment.CurrentDirectory + @"\son\clock.wav");
            son.SoundLocation = (Environment.CurrentDirectory + @"\son\explo.wav");
            sonar.SoundLocation = (Environment.CurrentDirectory + @"\son\sonar.wav");
            miss.SoundLocation = (Environment.CurrentDirectory + @"\son\miss.wav");
            victoireJ1.SoundLocation = (Environment.CurrentDirectory + @"\son\victoireJ1.wav");
            victoireJ2.SoundLocation = (Environment.CurrentDirectory + @"\son\victoireJ2.wav");
            bool rejouer = true;
            bool gagneJ1 = false, gagneJ2 = false;
            int xBateau, yBateau, xBateauFin, yBateauFin;
            int[,] joueur1 = new int[10, 10];
            int[,] joueur2 = new int[10, 10];
            string[] indice = new string[] { "premier", "deuxieme", "troisième", "quatrième" };
            joueur1 = init(joueur1);
            joueur2 = init(joueur2);

            clock.PlayLooping();

            Console.Write("Saisir le nom du joueur 1 : ");
            string nomJoueur1 = Console.ReadLine();

            Console.Write("Saisir le nom du joueur 2 : ");
            string nomJoueur2 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Tour de {0}", nomJoueur1);
            Console.ReadKey();
            clock.Stop();
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                affichageJoueur(joueur1);
                nomJoueur(nomJoueur1);

                Console.WriteLine("Saisir la Coordonée Y de votre {0} petit bateau. (A - J)", indice[i]);
                yBateau = saisieY();
                Console.WriteLine("Saisir la Coordoner X de votre {0} petit bateau. (0 - 9)", indice[i]);
                xBateau = saisieX();

                joueur1[xBateau, yBateau] = 1;
                Console.Clear();
                previsualisation(joueur1, yBateau, xBateau);

                Console.WriteLine("Saisir la Coordonée Y de fin de votre {0} petit bateau. (A - J)", indice[i]);
                yBateauFin = saisieYFin(joueur1,xBateau,yBateau);
                Console.WriteLine("Saisir la Coordonée X de fin de votre {0} petit bateau. (0 - 9)", indice[i]);
                xBateauFin = saisieXFin(joueur1,xBateau,yBateau,yBateauFin);

                joueur1 = ajoutBateau(joueur1, xBateau, yBateau, xBateauFin, yBateauFin);
                Console.Clear();

            }

            Console.WriteLine("Tour de {0}",nomJoueur2);
            Console.ReadKey();

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                affichageJoueur(joueur2);
                nomJoueur(nomJoueur2);


                Console.WriteLine("Saisir la Coordonée Y de votre {0} petit bateau. (A - J)", indice[i]);
                yBateau = saisieY();
                Console.WriteLine("Saisir la Coordonée X de votre {0} petit bateau. (0 - 9)", indice[i]);
                xBateau = saisieX();

                joueur2[xBateau, yBateau] = 1;
                Console.Clear();
                previsualisation(joueur2, yBateau, xBateau);

                Console.WriteLine("Saisir la Coordonée Y de fin de votre {0} petit bateau. (A - J)", indice[i]);
                yBateauFin = saisieYFin(joueur2, xBateau, yBateau);
                Console.WriteLine("Saisir la Coordonée X de fin de votre {0} petit bateau. (0 - 9)", indice[i]);
                xBateauFin = saisieXFin(joueur2, xBateau, yBateau, yBateauFin);

                joueur2 = ajoutBateau(joueur2, xBateau, yBateau, xBateauFin, yBateauFin);
            }

            do
            {
                rejouer = true;
                Console.Clear();
                Console.WriteLine("Tour de {0}.",nomJoueur1);
                Console.ReadKey();
                Console.Clear();
                sonar.PlayLooping();
                while (rejouer)
                {
                    affichageJoueur(joueur1);
                    nomJoueur(nomJoueur1);
                    Console.WriteLine("Saisir la Coordonée Y du tire. (A - J)");
                    yBateau = saisieY();
                    Console.WriteLine("Saisir la Coordonée X du tire. (0 - 9)");
                    xBateau = saisieX();
                    sonar.Stop();

                    if (joueur2[xBateau, yBateau] == 1)
                    {
                        Console.WriteLine("Vous avez toucher votre cible");
                        joueur2[xBateau, yBateau] = 2;
                        son.Play();
                        Thread.Sleep(4500);
                        sonar.PlayLooping();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Vons n'avez pas touche votre cible");
                        rejouer = false;
                        miss.Play();
                        Thread.Sleep(2500);
                        Console.ReadKey();
                    }
                    if (verification(joueur2) == 0)
                    {
                        gagneJ1 = true;
                        sonar.Stop();
                        break;
                    }
                }
                if (gagneJ1)
                {
                    Console.Clear();
                    Console.WriteLine("{0} Gagne.",nomJoueur1);
                    victoireJ1.Play();
                    Console.ReadKey();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Tour de {0}.",nomJoueur2);
                Console.ReadKey();

                rejouer = true;
                Console.Clear();
                sonar.PlayLooping();
                while (rejouer)
                {
                    affichageJoueur(joueur2);
                    nomJoueur(nomJoueur2);
                    Console.WriteLine("Saisir la Coordonée Y du tire. (A - J)");
                    yBateau = saisieY();
                    Console.WriteLine("Saisir la Coordonée X du tire. (0 - 9)");
                    xBateau = saisieX();
                    sonar.Stop();
                    if (joueur1[xBateau, yBateau] == 1)
                    {
                        Console.WriteLine("Vous avez toucher votre cible");
                        joueur1[xBateau, yBateau] = 2;
                        son.Play();
                        Thread.Sleep(4500);
                        sonar.PlayLooping();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Vons n'avez pas touche votre cible");
                        rejouer = false;
                        miss.Play();
                        Thread.Sleep(2500);
                        Console.ReadKey();
                    }
                    if (verification(joueur1) == 0)
                    {
                        gagneJ2 = true;
                        sonar.Stop();
                        break;
                    }
                }

                if (gagneJ2)
                {
                    Console.Clear();
                    victoireJ2.Play();
                    Console.WriteLine("{0} Gagne.",nomJoueur2);
                    Console.ReadKey();
                    break;
                }

            } while (true);
        }


        private static void nomJoueur(string nom)
        {
            int taille = Console.WindowWidth;
            Console.SetCursorPosition(taille / 2, 2);
            Console.WriteLine("A vous de jouez {0}", nom);
            Console.SetCursorPosition(0, 11);
        }
        private static void affichageJoueur(int[,] joueur)
        {
            Console.WriteLine("   | A | B | C | D | E | F | G | H | I | J |");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" {0} |", i);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" ");
                    if (joueur[i,j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (joueur[i,j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (joueur[i,j] == 2)    
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(joueur[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
        private static void previsualisation(int[,] joueur,int y,int x)
        {
            Console.WriteLine("   | A | B | C | D | E | F | G | H | I | J |");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" {0} |", i);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" ");
                    if (joueur[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    if ((y - 1 == j || y - 2 == j || y - 3 == j) && y - 3 >= 0 && x == i && pasNavireGauche(joueur, x, y))
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    if ((y + 1 == j || y + 2 == j || y + 3 == j) && y + 3 <= 9 && x == i && pasNavireDroit(joueur, x, y))
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    if ((x + 1 == i || x + 2 == i || x + 3 == i) && x + 3 <= 9 && y == j && pasNavireBas(joueur, x, y))
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    if ((x - 1 == i || x - 2 == i || x - 3 == i) && x - 3 >= 0 && y == j && pasNavireHaut(joueur, x, y))
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write(joueur[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" |");
                }
                Console.WriteLine();
            }

        }        

        static bool pasNavireGauche(int[,] joueur,int x , int y )
        {
            if (joueur[x,y-1] == 1|| joueur[x, y - 2] == 1 || joueur[x, y - 3] == 1 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool pasNavireDroit(int[,] joueur, int x, int y)
        {
            if (joueur[x, y + 1] == 1 || joueur[x, y + 2] == 1 || joueur[x, y + 3] == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool pasNavireBas(int[,] joueur, int x, int y)
        {
            if (joueur[x + 1, y] == 1 || joueur[x + 2, y] == 1 || joueur[x + 3, y] == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool pasNavireHaut(int[,] joueur, int x, int y)
        {
            if (joueur[x - 1, y] == 1 || joueur[x - 2, y] == 1 || joueur[x - 3, y] == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static int[,] init(int[,] joueur)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    joueur[i, j] = 0;
                }
            }
            return joueur;
        }
        static int[,] ajoutBateau(int[,] joueur, int x, int y, int xFin, int yFin)
        {
            if (x == xFin)
            {
                if (y + 3 == yFin)
                {
                    joueur[x, y] = 1;
                    joueur[x, y + 1] = 1;
                    joueur[x, y + 2] = 1;
                    joueur[x, y + 3] = 1;
                }
                else if (y - 3 == yFin)
                {
                    joueur[x, y] = 1;
                    joueur[x, y - 1] = 1;
                    joueur[x, y - 2] = 1;
                    joueur[x, y - 3] = 1;
                }
            }
            else if (y == yFin)
            {
                if (x + 3 == xFin)
                {
                    joueur[x, y] = 1;
                    joueur[x + 1, y] = 1;
                    joueur[x + 2, y] = 1;
                    joueur[x + 3, y] = 1;
                }
                else if (x - 3 == xFin)
                {
                    joueur[x, y] = 1;
                    joueur[x - 1, y] = 1;
                    joueur[x - 2, y] = 1;
                    joueur[x - 3, y] = 1;
                }
            }
            return joueur;
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
        static int verification(int[,] joueur)
        {
            int verif = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (joueur[i, j] == 1)
                    {
                        verif++;
                    }
                }
            }
            return verif;
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
        static int saisieX()
        {
            string vS;
            while (true)
            {
                vS = Console.ReadLine();
                if (vS == "0" || vS == "1" || vS == "2" || vS == "3" || vS == "4" || vS == "5" || vS == "6" || vS == "7" || vS == "8" || vS == "9")
                {
                    return Convert.ToInt32(vS);
                }
            }
        }
        static int saisieYFin(int[,] joueur,int x,int y )
        {
            string vS;
            while (true)
            {
                vS = Console.ReadLine();

                if (vS == "A" || vS == "B" || vS == "C" || vS == "D" || vS == "E" || vS == "F" || vS == "G" || vS == "H" || vS == "I" || vS == "J")
                {
                    if (convertToX(Convert.ToChar(vS)) == y)
                    {
                        return convertToX(Convert.ToChar(vS));
                    }
                    else if (convertToX(Convert.ToChar(vS)) == y+3 && pasNavireDroit(joueur,x,y))
                    {
                        return convertToX(Convert.ToChar(vS));
                    }
                    else if (convertToX(Convert.ToChar(vS))== y-3 && pasNavireGauche(joueur,x,y))
                    {
                        return convertToX(Convert.ToChar(vS));
                    }
                }
            }
        }
        static int saisieXFin(int[,] joueur ,int x,int y,int ySaisieFin)
        {
            string vS;
            while (true)
            {
                vS = Console.ReadLine();
                if (vS == "0" || vS == "1" || vS == "2" || vS == "3" || vS == "4" || vS == "5" || vS == "6" || vS == "7" || vS == "8" || vS == "9")
                {
                    if (ySaisieFin == y )
                    {
                        if (Convert.ToInt32(vS) == x + 3 && pasNavireBas(joueur, x, y))
                        {
                            return Convert.ToInt32(vS);
                        }
                        else if (Convert.ToInt32(vS) == x - 3 && pasNavireHaut(joueur, x, y)) 
                        {
                            return Convert.ToInt32(vS);
                        }
                    }
                    else if (ySaisieFin != y)
                    {
                        return x;
                    }
                }
            }
        }
    }
}
