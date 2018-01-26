using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Classement
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            #region Chargement
            List<Joueur> collectionJoueur = keep.chargementJoueur();
            #endregion

            #region variable
            Joueur joueur = null;
            bool sortir = false;

            #endregion  



            do
            {
                Console.Clear();
                textMillieu("------------------------------------------------------------------------");
                textMillieu("0- Sortir du programme");
                textMillieu("1- Ajouter un joueur");
                textMillieu("2- Afficher les joueur");
                textMillieu("3- Afficher la liste des adhérents");
                textMillieu("4- Afficher la liste des livres");
                textMillieu("5- Supprimer un adhérent");
                textMillieu("6- Supprimer un livre");
                textMillieu("7- Ajouter un emprunt");
                textMillieu("8- Liste des emprunts");
                textMillieu("9- Enregister le retour d'un livre");
                textMillieu("------------------------------------------------------------------------");
                Console.WriteLine("");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "0":

                        keep.save(collectionJoueur);

                        sortir = true;
                        break;

                    case "1":
                        Console.Clear();
                        joueur = new Joueur();

                        Console.WriteLine("Saisir le nom du joueur :");
                        joueur.nom = Console.ReadLine();

                        Console.WriteLine("Saisir le prénom du joueur :");
                        joueur.prenom = Console.ReadLine();

                        Console.WriteLine("Le score de base est 50.");
                        joueur.score = 50;
                        Console.ReadKey();
                        
                        collectionJoueur.Add(joueur);
                        break;

                    case "2":
                        Console.Clear();
                        foreach (Joueur courant in collectionJoueur)
                        {
                            Console.Write(courant.nom);
                            Console.Write("  ");
                            Console.Write(courant.prenom);
                            Console.Write("  ");
                            Console.Write("{0} points",courant.score);
                            Console.Write("  ");
                            if (courant.match == null)
                            {
                                Console.Write("sans match");
                            }
                            else
                            {
                                Console.Write("{0} matchs", courant.match.Count);
                            }
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                        break;














                }

            } while (!sortir);

        }
                private static void textMillieu (string texte)
        {
            int espace = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(espace, Console.CursorTop);
            Console.WriteLine(texte);
        }
    }


    public class Joueur
    {
        public string nom
        {
            set;
            get;
        }
        public string prenom
        {
            get;
            set;
        }
        public int score
        {
            set;
            get;
        }
        public List<match> match
        {
            set;
            get;
        }           
    }

    public class match
    {
        public string nomGagnant
        {
            set;
            get;
        }
        public string nomPerdant
        {
            set;
            get;
        }
        public int points
        {
            set;
            get;
        }

    }

    public static class keep
    {
        private static string repertoire = Environment.CurrentDirectory + @"/";

        public static List<Joueur> chargementJoueur()
        {
            FileStream fs = null;
            List<Joueur> listeJoueur = new List<Joueur>();
            string chemin = repertoire + "listeJoueur";
            if (File.Exists(chemin))
            {
                fs = new FileStream(chemin, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                listeJoueur = (List<Joueur>)formatter.Deserialize(fs);
                fs.Close();
            }
            return listeJoueur;
        }
        public static void save (List<Joueur> listeJoueur)
        {
            FileStream file = null;
            file = File.Open(repertoire + "listeJoueur", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, listeJoueur);
            file.Close();
        }
    }
}
