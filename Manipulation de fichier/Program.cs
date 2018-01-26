using System;
using System.IO;

namespace Manipulation_de_fichier
{
    class Program
    {
        static void Main(string[] args)
        {    
            
            do
            {
                Console.Clear();
                Console.WriteLine("0 - Creation d'un nouveau fichier.");
                Console.WriteLine("1 - Ecrire dans un fichier.");
                Console.WriteLine("2 - Visualiser un fichier.");
                Console.WriteLine("3 - Supprimer un fichier.");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "0":
                        Console.Clear();

                        Console.WriteLine("Quel est le nom et l'extantion du fichier?");
                        string chemin = Environment.CurrentDirectory  +@"\"+ Console.ReadLine();
                        
                        if (File.Exists(chemin))
                        {
                            Console.WriteLine("Le fichier existe déja");                            
                        }
                        else
                        {
                            File.Create(chemin);
                            Console.WriteLine("Le fichier a été crée en : {0}", chemin);
                        }

                        Console.ReadKey();    
                        
                        break;


                    case "1":
                        Console.Clear();

                        Console.WriteLine("Saisir le fichier a editer");
                        chemin = Environment.CurrentDirectory +@"\"+ Console.ReadLine();

                        if (!File.Exists(chemin))
                        {
                            Console.WriteLine("Le fichier n'existe pas");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Saisir.");
                        string valeurSaisie = Console.ReadLine();
                        
                        StreamWriter redacteurFichier = new StreamWriter(chemin, true);
                        redacteurFichier.WriteLine(valeurSaisie);
                        redacteurFichier.Close();
                        break;

                    case "2":
                        Console.Clear();

                        Console.WriteLine("Saisir le fichier a visualiser.");
                        chemin=Environment.CurrentDirectory + @"\" + Console.ReadLine();

                        if (!File.Exists(chemin))
                        {
                            Console.WriteLine("Le fichier n'existe pas");
                            Console.ReadKey();
                            break;
                        }

                        StreamReader lecteurDeFichier = new StreamReader(chemin,true);
                        string ligne;
                        ligne = lecteurDeFichier.ReadLine();
                        while (ligne != null)
                        {
                            Console.WriteLine(ligne);
                            ligne = lecteurDeFichier.ReadLine();
                        }
                        lecteurDeFichier.Close();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();

                        Console.WriteLine("Saisir le fichier a supprimer.");
                        chemin = Environment.CurrentDirectory + @"\" + Console.ReadLine();

                        if (!File.Exists(chemin))
                        {
                            Console.WriteLine("Le fichier n'existe pas");
                            Console.ReadKey();
                            break;
                        }
                        File.Delete(chemin);

                        Console.WriteLine("Le dossier a été supprimer.");
                        Console.ReadKey();

                        break;

                    case "4":

                        chemin = Environment.CurrentDirectory + @"\test";
                        if (!File.Exists(chemin))
                        {
                            Console.WriteLine("Le fichier n'existe pas");
                            Console.ReadKey();
                            break;
                        }
                        StreamReader lecteurDeFichierr = new StreamReader(chemin, true);
                        int compt = 0;
                        string lignee = "";
                        ligne = lecteurDeFichierr.ReadLine();
                        var chars = lignee.ToCharArray();
                        while (lignee != null)
                        {
                            for (int i = 0; i < chars.Length; i++)
                            {
                                if (chars[i] == '(')
                                {
                                    Console.Write(chars[i]);
                                }
                                if ((compt == 3 && chars[i] != ' ') || (compt == 5 && chars[i] != ' '))
                                {
                                    Console.Write(chars[i]);
                                }
                                if (chars[i]==',')
                                {
                                    compt++;
                                }
                                if (compt == 6)
                                {
                                    compt = 0;
                                }
                            }
                            Console.WriteLine();
                            lignee = lecteurDeFichierr.ReadLine();
                            try
                            {
                                chars = lignee.ToCharArray();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("fin");
                                break;
                                throw;
                            }
                            
                        }
                        lecteurDeFichierr.Close();
                        Console.ReadKey();
                        break;


                        




















                                                // structure 2 ajouter une fonctionaliter qui sauvegarde les informations relatives a un navire lorsqu'il est supprimer Format CSV.
                                                  
                        //chemin = Environment.CurrentDirectory + @"\navireSupprimer.txt";
                        //if (!File.Exists(chemin))
                        //{
                        //    File.Create(chemin);
                        //}

                        //StreamWriter redacteurFichier = new StreamWriter(chemin, true);

                        //foreach (var item in collection)
                        //{
                        //    Console.Write(item.parametre1);
                        //    Console.Write(",");
                        //    Console.Write(item.parametre2);
                        //
                        //                          Ajouter les parametre supplementaire
                        //}
                        //lecteurDeFichier.Close();






                }
            } while (true);



        }
    }
}
