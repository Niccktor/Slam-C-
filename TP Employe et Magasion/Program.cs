using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe_et_Magasion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sortir = false;
            int numEmpoyer = 0 , numChoisie;
            string nomEmployer, magasinChoisie, prenomEmployer, nomMagasin;
            List<Employe> listEmployer = new List<Employe>();
            List<Magasin> listMagasin = new List<Magasin>();
            Employe nouvelleEmploye = null, employeChoisi = null;
            Magasin nouveauMagasin = null, magasinChoisi = null;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("0 - Sortir du programme.");
                Console.WriteLine("1 - Ajouter un employé.");
                Console.WriteLine("2 - Ajouter un magasin.");
                Console.WriteLine("3 - Ajouter un employé a un magasin.");
                Console.WriteLine("4 - Afficher toute les information d'un employer.");
                Console.WriteLine("5 - AFficher toute les information de tous les employer d'un magasin.");
                Console.WriteLine("6 - Supprimer un employer d'un magasin.");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        nouvelleEmploye = null;
                        nomEmployer = null;
                        prenomEmployer = null;

                        Console.WriteLine("Saisir le nom de l'employer.");
                        nomEmployer = Console.ReadLine();

                        Console.WriteLine("Saisir le prenom de l'employer");
                        prenomEmployer = Console.ReadLine();

                        nouvelleEmploye = new Employe(numEmpoyer, nomEmployer, prenomEmployer);
                        listEmployer.Add(nouvelleEmploye);
                        numEmpoyer++;

                        break;

                    case "2":
                        nouveauMagasin = null;
                        nomMagasin = null;

                        Console.WriteLine("Saisir le nom du magasin.");
                        nomMagasin = Console.ReadLine();

                        nouveauMagasin = new Magasin(nomMagasin);
                        listMagasin.Add(nouveauMagasin);

                        break;

                    case "3":
                        employeChoisi = null;
                        magasinChoisie = null;

                        foreach (Employe courant in listEmployer)
                        {
                            Console.WriteLine("Num : {0} , Nom : {1} , Prenom : {2}", courant.Numero, courant.Nom, courant.Prenom);
                        }
                        Console.WriteLine("Saisir le num de l'employer a ajouter.");
                        numChoisie = Convert.ToInt32(Console.ReadLine());
                        foreach (Employe courant in listEmployer)
                        {
                            if (numChoisie == courant.Numero)
                            {
                                employeChoisi = courant;
                            }
                        }

                        if (employeChoisi == null)
                        {
                            goto case "3";
                        }

                        foreach (Magasin courant in listMagasin)
                        {
                            Console.WriteLine("Nom du magasin : {0}", courant.NomMagasin);
                        }
                        Console.WriteLine("Saisir le nom du magasin.");
                        magasinChoisie = Console.ReadLine();
                        foreach (Magasin courant in listMagasin)
                        {
                            if (courant.NomMagasin == magasinChoisie)
                            {
                                courant.AjouterEmployer(employeChoisi);
                            }
                        }

                        break;

                    case "5":

                        foreach (Magasin courant in listMagasin)
                        {
                            Console.WriteLine("Nom du magasin : {0}", courant.NomMagasin);
                        }
                        Console.WriteLine("Saisir le nom du magasin.");
                        magasinChoisie = Console.ReadLine();

                        foreach (Magasin magCourant in listMagasin)
                        {
                            if (magCourant.NomMagasin == magasinChoisie)
                            {
                                foreach (Employe employeCourant in magCourant.ListEmploye)
                                {
                                    Console.WriteLine("Num : {0} , Nom : {1} , Prenom : {2}", employeCourant.Numero,employeCourant.Nom,employeCourant.Prenom);
                                }
                            }
                        }


                        break;

                    case "4":
                        Console.WriteLine("Saisir le numero de l'employer a visialiser.");
                        numChoisie = Convert.ToInt32(Console.ReadLine());

                        foreach (Employe courant in listEmployer)
                        {
                            if (courant.Numero == numChoisie)
                            {
                                Console.WriteLine("Num : {0} , Nom : {1} , Prenom : {2}", courant.Numero, courant.Nom, courant.Prenom);
                            }
                        }
                        break;

                    case "6":

                        employeChoisi = null;
                        magasinChoisie = null;

                        foreach (Magasin courant in listMagasin)
                        {
                            Console.WriteLine("Nom du magasin : {0}", courant.NomMagasin);
                        }
                        Console.WriteLine("Saisir le nom du magasin.");
                        magasinChoisie = Console.ReadLine();

                        foreach (Magasin courant in listMagasin)
                        {
                            if (magasinChoisie == courant.NomMagasin)
                            {
                                foreach (Employe employeCourant in courant.ListEmploye)
                                {
                                    Console.WriteLine("Num : {0} , Nom : {1} , Prenom : {2}", employeCourant.Numero, employeCourant.Nom, employeCourant.Prenom);
                                }
                            }
                        }
                        Console.WriteLine("Saisir le num de l'meployer");
                        numChoisie = Convert.ToInt32(Console.ReadLine());

                        foreach (Magasin courant in listMagasin)
                        {
                            if (magasinChoisie == courant.NomMagasin)
                            {
                                foreach (Employe employerCourant in courant.ListEmploye)
                                {
                                    if (employerCourant.Numero == numChoisie)
                                    {
                                        employeChoisi = employerCourant;
                                    }
                                }
                                 magasinChoisi = courant;
                            }
                        }
                        magasinChoisi.SupprimerEmployer(employeChoisi);
                            break;

                    case "0":
                        sortir = true;
                        break;
                }
            } while (!sortir);
        }
    }
}
