using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pong_thread
{
    class Program
    {
        static int balleX, balleY;
        static int paletX1, paletY1;
        static int paletX2, paletY2;
        static string directionHB, directionDG;
        static bool stop, butDroit,butGauche;
        static int scoreDroite, scoreGauche;

        static void balle ()
        {
            while (true)
            {
                Random random = new Random();
                int j = random.Next(0, 2);

                Thread.Sleep(50);
        
                if (balleY == 0)
                {
                    directionHB = "Bas";
                }
                else if (balleY + 3 == Console.WindowHeight)
                {
                    directionHB = "Haut";
                }

                if (balleX == 2 && (balleY == paletY1+2 || balleY == paletY1+1 || balleY == paletY1 || balleY +1 == paletY1))
                {
                    directionDG = "Droite";
                }
                else if (balleX == 0)
                {
                    butDroit = true;
                    scoreDroite++;
                    Console.Clear();
                }
                if (balleX == Console.WindowWidth - 5 && (balleY == paletY2+2 || balleY == paletY2 + 1 || balleY == paletY2 || balleY + 1 == paletY2 ))
                {
                    directionDG = "Gauche";
                }
                else if (balleX == Console.WindowWidth - 3)
                {
                    butGauche = true;
                    scoreGauche++;
                    Console.Clear();
                }
                if (directionHB == "Haut")
                {
                    Console.MoveBufferArea(balleX, balleY, 3, 2, balleX, balleY - j);
                    balleY = balleY - j;
                }
                else if (directionHB == "Bas")
                {
                    Console.MoveBufferArea(balleX, balleY, 3, 2, balleX, balleY + j);
                    balleY = balleY + j;
                }
                if (directionDG=="Droite")
                {
                    Console.MoveBufferArea(balleX, balleY, 3, 2, balleX+1, balleY);
                    balleX = balleX +1;
                }
                else if (directionDG == "Gauche")
                {
                    Console.MoveBufferArea(balleX, balleY, 3, 2, balleX-1, balleY);
                    balleX =balleX -1;
                }
            }
        }
        static void palet1 ()
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);

                switch (info.Key)
                {
                    case ConsoleKey.Z:
                        if (paletY1 > 0)
                        {
                            Console.MoveBufferArea(paletX1, paletY1, 1, 3, paletX1, paletY1 - 1);
                            paletY1--;                            
                        }
                        break;
                    case ConsoleKey.S:
                        if (paletY1+3 < Console.WindowHeight)
                        {
                            Console.MoveBufferArea(paletX1, paletY1, 1, 3, paletX1, paletY1 + 1);
                            paletY1++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (paletY2 > 0)
                        {
                            Console.MoveBufferArea(paletX2, paletY2, 1, 3, paletX2, paletY2 - 1);
                            paletY2--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (paletY2+3 < Console.WindowHeight)
                        {
                            Console.MoveBufferArea(paletX2, paletY2, 1, 3, paletX2, paletY2 + 1);
                            paletY2++;
                        }
                        break;
                }
                if (ConsoleKey.Backspace == info.Key)
                {
                    stop = true;
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            scoreDroite = 0; scoreGauche = 0;
            Thread bal = new Thread(new ThreadStart(balle));
            Thread pal1 = new Thread(new ThreadStart(palet1));

            textM("La partie se finit quand l'un des deux joueurs et a 5 points!! \n");
            Console.ReadKey();
            Console.Clear();
            textM("Prêt ?\n");
            Console.ReadKey();
            Console.Clear();

            affichage();

            bal.Start();
            pal1.Start();


            while (true)
            {
                if (scoreDroite == 5)
                {
                    bal.Abort();
                    pal1.Abort();
                    break;
                }
                if (scoreGauche == 5)
                {
                    bal.Abort();
                    pal1.Abort();
                    break;
                }
                if (butDroit)
                {
                    butDroit = false;
                    bal.Abort();
                    pal1.Abort();
                    affichageScore();
                    Thread.Sleep(2000);
                    textM("Prêt pour le point suivant?\n");
                    Console.ReadKey();
                    Console.Clear();

                    affichage();
                    bal = new Thread(new ThreadStart(balle));
                    bal.Start();
                    pal1 = new Thread(new ThreadStart(palet1));
                    pal1.Start();
                }
                if (butGauche)
                {
                    butGauche = false;
                    bal.Abort();
                    pal1.Abort();
                    affichageScore();
                    Thread.Sleep(2000);
                    textM("Prêt pour le point suivant?\n");
                    Console.ReadKey();
                    Console.Clear();

                    affichage();

                    bal = new Thread(new ThreadStart(balle));
                    bal.Start();
                    pal1 = new Thread(new ThreadStart(palet1));
                    pal1.Start();
                }
                if (stop)
                {
                    bal.Abort();
                    pal1.Abort();
                    affichageScore();
                    Console.ReadKey();
                    break;
                }
            }
            Console.Clear();
            if (scoreDroite > scoreGauche)
            { 
                textM("Le joueur droit GAGNE !!!!!");
            }
            else
            {
                textM("Le joueur gauche GAGNE !!!!!");
            }
            Console.ReadKey();
            Environment.Exit(1);
        }
        static void affichage()
        {
            balleX = (Console.WindowWidth / 2); balleY =  (Console.WindowHeight/2)-2;
            paletX1 = 1; paletY1 = 0;
            paletX2 = Console.WindowWidth - 2; paletY2 = 0;
            directionHB = "Haut"; directionDG = "Droite";
            stop = false;


            Console.SetCursorPosition(balleX, balleY);
            Console.WriteLine("@@@");
            Console.SetCursorPosition(balleX, balleY + 1);
            Console.WriteLine("@@@");

            Console.SetCursorPosition(paletX1, paletY1);
            Console.WriteLine("@");
            Console.SetCursorPosition(paletX1, paletY1 + 1);
            Console.WriteLine("@");
            Console.SetCursorPosition(paletX1, paletY1 + 2);
            Console.WriteLine("@");

            Console.SetCursorPosition(paletX2, paletY2);
            Console.WriteLine("@");
            Console.SetCursorPosition(paletX2, paletY2 + 1);
            Console.WriteLine("@");
            Console.SetCursorPosition(paletX2, paletY2 + 2);
            Console.WriteLine("@");
        }

        static void affichageScore()
        {
            Console.Clear();
            Console.WriteLine("Le score est de {0} pour le joueur gauche et {1} pour le joueur droit !!",scoreGauche,scoreDroite);
        }
        private static void textM(string texte)
        {
            int espace = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(espace, (Console.WindowHeight/2) -3);
            Console.Write(texte);
        }
    }
}
