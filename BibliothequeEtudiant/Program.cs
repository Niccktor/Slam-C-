using System;
using System.Collections.Generic;
using ApiBibliotheque;



namespace Bibliotheque
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CHARGER DONNEES

            List<Livre> collectionLivres = Persistance.ChargeLivre();
            List<Adherent> collectionAdherents = Persistance.ChargeAdherent();
            List<Emprunt> collectionEmprunts = Persistance.ChargeEmprunt();

            #endregion


            #region VARIABLES ==> Utilisées pour la structure WHILE (menu)
            int choix;
            bool sortir = false;
            #endregion

            #region VARIABLES ==> Utilisées pour stocker les données métiers
            string numAdherent, nomAdherent, prenomAdherent, emailAdherent, adresseAdherent, villeAdherent, codePostalAdherent;
            string titreLivre, numLivre, auteur, isbn;
            string dateRetour;
            Livre unLivre = null;
            Adherent unAdherent = null;
            #endregion

            #region VARIABLES (dénombrements et structures itératives)
            int nbElement, compteur = 0, test;
            #endregion

            #region VARIABLES DIVERSES
            bool supprimer = false, trouver = false; 
            #endregion


            do
            {
                Console.Clear();
                textMillieu("------------------------------------------------------------------------");
                textMillieu("0- Sortir du programme");
                textMillieu("1- Ajouter un Livre");
                textMillieu("2- Ajouter un adhérent");
                textMillieu("3- Afficher la liste des adhérents");
                textMillieu("4- Afficher la liste des livres");
                textMillieu("5- Supprimer un adhérent");
                textMillieu("6- Supprimer un livre");
                textMillieu("7- Ajouter un emprunt");
                textMillieu("8- Liste des emprunts");
                textMillieu("9- Enregister le retour d'un livre");
                textMillieu("------------------------------------------------------------------------");
                Console.WriteLine("");



                choix = Convert.ToInt32(Console.ReadLine());


                switch (choix)
                {
                    case 1:

                        Console.Clear();

                        textMillieu("------------------------------------------------------------------------");

                        textMillieu("Le numéro de l'ouvrage :");
                        numLivre = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");

                        textMillieu("Titre de l'ouvrage :");
                        titreLivre = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");

                        textMillieu("Nom de l'auteur :");
                        auteur = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");

                        textMillieu("ISBN :");
                        isbn = Console.ReadLine();

                        unLivre = new Livre(numLivre, titreLivre, auteur, isbn);

                        collectionLivres.Add(unLivre);     
                        /* A compléter
                         * 
                         * Ecrire les instructions qui :
                         * 
                         * permettent à l'utilisateur de saisir le numéro, le titre, le nom de l'auteur et l'ISBN d'un livre
                         * initialise une variable de type livre à partir des valeurs saisies
                         * ajoute le livre à la collection de livres
                         * */

                        break;

                    case 2:

                        Console.Clear();

                        textMillieu("------------------------------------------------------------------------");

                        textMillieu("Saisir le numéro du nouvel adhérent");
                        numAdherent = Console.ReadLine();
                        int numeroAdherent = Convert.ToInt16(numAdherent);

                        textMillieu("------------------------------------------------------------------------");

                        textMillieu("Saisir le nom du nouvel adhérent");
                        nomAdherent = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir le prénom du nouvel adhérent");
                        prenomAdherent = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir l'adresse email du nouvel adhérent");
                        emailAdherent = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir l'adresse postale du nouvel adhérent");
                        adresseAdherent = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir la ville de résidence du nouvel adhérent");
                        villeAdherent = Console.ReadLine();

                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir le code postal de résidence du nouvel adhérent");
                        codePostalAdherent = Console.ReadLine();


                        Adherent nouveauAdherent = new Adherent(numeroAdherent, nomAdherent, prenomAdherent, emailAdherent, adresseAdherent, villeAdherent, codePostalAdherent);
                        collectionAdherents.Add(nouveauAdherent);


                        /* A compléter
                         * 
                         * Ecrire les instructions qui :
                         * initialise une variable de type Adhérent à partir des valeurs saisies
                         *  ajoute l'adhérent (la variable adhérent !) à la collection d'adhérents
                         * */
                        break;

                    case 3:

                        Console.Clear();

                        test = collectionAdherents.Count ;

                        if (test == 0)
                        {
                            Console.WriteLine("Aucun adherent n'est référencé");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Num Adherent [Nom Adherent] [Prenom Adherent] [Email Adherent] [Adresse Adherent] [Ville Adherent] [Code Postal Adherent]");
                            foreach (Adherent adherentsCourant in collectionAdherents)
                            {
                                Console.WriteLine();
                                Console.Write(adherentsCourant.NumeroAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.NomAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.PrenomAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.EmailAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.AdresseAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.VilleAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.CodePostalAdherent);
                                Console.WriteLine();
                            }
                        }
                        Console.ReadKey();
                        /* A compléter
                        * 
                        * Ecrire les instructions qui :    
                        * parcours la collection d'adhérents et affiche à chaque itération, les informations de l'adhérents courant
                        * */
                        break;

                    case 4:

                        /*
                         * Modifier le bloc d'instruction ci-dessous comme suit :
                         * Si aucun livre n'est référencé, le programme en informe l'utilisateur
                         * dans le cas contraire elle affiche la collection de livres
                         * 
                            */
                        Console.Clear();

                        test = collectionLivres.Count;
                        if (test == 0)
                        {
                            textMillieu("------------------------------------------------------------------------");
                            textMillieu("Aucun livre n'est référencé.");
                            textMillieu("------------------------------------------------------------------------");

                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("[Num livre] [Titre livre] [Auteur livre] [ISBN]");

                            foreach (Livre livreCourant in collectionLivres)
                            {
                                Console.WriteLine();
                                Console.Write(livreCourant.NumLivre);
                                Console.Write(" [ {0} ]", livreCourant.TitreLivre);
                                Console.Write(" [ {0} ]", livreCourant.Auteur);
                                Console.Write(" [ {0} ]", livreCourant.Isbn);
                                Console.WriteLine();
                            }
                        }
                        Console.ReadKey();
                        break;
                   
                    case 5:
                        Console.Clear();

                        #region Affichage adherents

                        test = collectionAdherents.Count;

                        if (test == 0)
                        {
                            textMillieu("------------------------------------------------------------------------");
                            textMillieu("Aucun adherent n'est référencé");
                            textMillieu("------------------------------------------------------------------------");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Num Adherent [Nom Adherent] [Prenom Adherent] [Email Adherent] [Adresse Adherent] [Ville Adherent] [Code Postal Adherent]");
                            foreach (Adherent adherentsCourant in collectionAdherents)
                            {
                                Console.WriteLine();
                                Console.Write(adherentsCourant.NumeroAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.NomAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.PrenomAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.EmailAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.AdresseAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.VilleAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.CodePostalAdherent);
                                Console.WriteLine();
                            }
                        }
                        #endregion

                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir le nom de l'adhérent à supprimer");
                        textMillieu("------------------------------------------------------------------------");
                        nomAdherent = Console.ReadLine();
                        /* A compléter
                        * 
                        * Ecrire les instructions qui :    
                        * parcours la collection d'adhérents et 
                        *   Supprime l'adhérent lorsque le nom de l'adhérent parcouru (courant) est équivalent à celui saisi par l'utilisateur
                        *   Rappel : Une collection (LIST) parcouru à l'aide d'un FOREACH est en lecture seule. 
                        *   La méthode Remove de la classe LIST peut etre utilisée à condition de sortir prématurément 
                        *   du parcours à l'aide d'une BREAK 
                        *   
                        *   Vous proposerez deux parcours (itération) différents, l'un avec la structure foreach, l'autre avec la structure While
                        */


                        Console.WriteLine("Méthode Foreach ou While:");
                        switch (Console.ReadLine())
                        {
                            case "Foreach":
                                compteur = 0;
                                supprimer = false;
                                foreach (Adherent adherentCourant in collectionAdherents)
                                {
                                    if (adherentCourant.NomAdherent == nomAdherent)
                                    {
                                        supprimer = true;
                                        collectionAdherents.RemoveAt(compteur);
                                        Console.WriteLine("{0} a été supprimer avec la fonction foreach.", nomAdherent);
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        compteur++;
                                    }
                                }
                                break;

                            case "While":

                                compteur = 0;
                                supprimer = false;
                                while (compteur < collectionAdherents.Count)
                                {
                                    if (collectionAdherents[compteur].NomAdherent == nomAdherent)
                                    {
                                        supprimer = true;
                                        collectionAdherents.RemoveAt(compteur);
                                        Console.WriteLine("{0} a été supprimer avec la fonction while.", nomAdherent);                                        
                                        break;
                                    }
                                    compteur++;
                                }
                                break;
                        }
                        if (supprimer == false)
                        {
                            Console.WriteLine("Le livre rechrché n'est pas référencés");
                            
                        }
                        Console.ReadKey();
                        break;

                    case 6:
                        
                        Console.Clear();

                        #region Affichage livre

                        test = collectionLivres.Count;
                        if (test == 0)
                        {
                            textMillieu("------------------------------------------------------------------------");
                            textMillieu("Aucun livre n'est référencé.");
                            textMillieu("------------------------------------------------------------------------");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("[Num livre] [Titre livre] [Auteur livre] [ISBN]");

                            foreach (Livre livreCourant in collectionLivres)
                            {
                                Console.WriteLine();
                                Console.Write(livreCourant.NumLivre);
                                Console.Write(" [ {0} ]", livreCourant.TitreLivre);
                                Console.Write(" [ {0} ]", livreCourant.Auteur);
                                Console.Write(" [ {0} ]", livreCourant.Isbn);
                                Console.WriteLine();
                            }
                        }
                        #endregion
                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir le numéro ISBN du livre à supprimer");
                        isbn = Console.ReadLine();
                        nbElement = collectionLivres.Count; //nbElement contient le nombre de livres présent dans la collection
                                                            //compteur = 0;//

                        /*A compléter
                        *
                        *Ecrire les instructions qui:
                        * 
                        * Parcours à l'aide d'une boucle While la collection de livres.
                        *   recherche l'indice correspondant à l'emplacement ou se trouve le livre dans la collection
                        *   supprime l'élément en s'appuyant sur la méthode "removeAt" de la classe LIST
                        *   
                        * L'application affichera un message de confirmation 
                        * ou un message indiquant l'absence du livre recherché dans la collection de livres référencés.
                         * */

                        supprimer = false;

                        for (int i = 0; i < nbElement; i++)
                        {                            
                            if (collectionLivres[i].Isbn == isbn)
                            {
                                supprimer = true;
                                collectionLivres.RemoveAt(i);
                                Console.WriteLine("ISBN {0} a été supprimer.",isbn);
                                break;
                            }
                        }
                        if(supprimer == false)
                        {
                            Console.WriteLine("Le livre rechrché n'est pas référencés");
                        }
                        Console.ReadKey();
                        break;

                    case 7:

                        Console.Clear();
                        /*A compléter
                        *
                        *Ecrire les instructions qui:
                        * 
                        * 1) Affiche la collection de livres référencés
                        * 2) Permet la saisie d'un numéro de livre [correspond à la sélection d'un livre]
                        * ou S pour sortir du traitement en cours [Utilisez le break pour sortir du case en cours]
                        * 3) Le systeme recherche "le livre" à partir de la valeur précédement saisie
                        * Si le numéro de livre est erroné, le "case" 7 est relancé [utilisez l'instruction goto]
                        * dans le cas contraire il est stocké dans la variable "unLivre" de type Livre
                        * 
                        * 4)Effectuer le traitement similaire permettant de sélectionner un adhérent
                        * Celui-ci sera stocké dans la variable "unAdherent" de type Adherent
                        *
                        * */

                        #region Affichage livre

                        test = collectionLivres.Count;
                        if (test == 0)
                        {
                            Console.WriteLine("Aucun livre n'est référencé.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("[Num livre] [Titre livre] [Auteur livre] [ISBN]");

                            foreach (Livre livreCourant in collectionLivres)
                            {
                                Console.WriteLine();
                                Console.Write(livreCourant.NumLivre);
                                Console.Write(" [ {0} ]", livreCourant.TitreLivre);
                                Console.Write(" [ {0} ]", livreCourant.Auteur);
                                Console.Write(" [ {0} ]", livreCourant.Isbn);
                                Console.WriteLine();
                            }
                        }
                        #endregion

                        #region saisie livre

                        trouver = false;

                        Console.WriteLine("Saisir le numéro de livre (S pour sortir du traitement)");
                        numLivre = Console.ReadLine();
                        if (numLivre == "s" || numLivre == "S")
                        {
                            Console.WriteLine("Sortie du traitement.");
                            Console.ReadKey();
                            break;
                        }
                        foreach (Livre livreCourant in collectionLivres)
                        {
                            if (Convert.ToString(livreCourant.NumLivre) == numLivre)
                            {
                                trouver = true;
                                unLivre = livreCourant;
                            }                        
                        }
                        if (trouver == false)
                        {
                            Console.WriteLine("Le numéro de livre est erroné.");
                            Console.ReadKey();
                            goto case 7;
                        }
                        #endregion

                        #region Affichage adherent 

                        test = collectionAdherents.Count;
                        if (test == 0)
                        {
                            Console.WriteLine("Aucun adherent n'est référencé");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Num Adherent [Nom Adherent] [Prenom Adherent] [Email Adherent] [Adresse Adherent] [Ville Adherent] [Code Postal Adherent]");
                            foreach (Adherent adherentsCourant in collectionAdherents)
                            {
                                Console.WriteLine();
                                Console.Write(adherentsCourant.NumeroAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.NomAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.PrenomAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.EmailAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.AdresseAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.VilleAdherent);
                                Console.Write(" [ {0} ]", adherentsCourant.CodePostalAdherent);
                                Console.WriteLine();
                            }
                        }
                        #endregion

                         #region saisie adherent
                        trouver = false;

                        Console.WriteLine("Saisir le numéro d'adherent.");
                        numAdherent = Console.ReadLine();
                        if (numAdherent =="s" || numAdherent=="S")
                        {
                            Console.WriteLine("Sortie du traitement.");
                            Console.ReadKey();
                            break;
                        }
                        foreach (Adherent adherentCourant in collectionAdherents)
                        {
                            if (Convert.ToString(adherentCourant.NumeroAdherent)== numAdherent)
                            {
                                trouver = true;
                                unAdherent = adherentCourant;
                            }
                        }
                        if (trouver== false)
                        {
                            Console.WriteLine("Le numéro d'adherent est erroné.");
                            Console.ReadKey();
                            goto case 7;
                        }
                        #endregion 

                        Console.WriteLine("Saisir la date de retour prévue");
                        DateTime dt = Convert.ToDateTime(Console.ReadLine());
                        Emprunt nouvelleEmprunt = new Emprunt(unAdherent, unLivre, dt);
                        collectionEmprunts.Add(nouvelleEmprunt);

                        /*A compléter
                        *
                        *Ecrire les instructions qui:
                         * 
                         * initialise un objet de type emprunt à partir des variables objets Livre (unLivre) 
                         * et Adherent (unAdherent) précédemment valorisées ainsi que la date d'emprunt stockée
                         * dans une structure (similaire à un objet) de type dateTime (dt)
                         * 
                         * Ajoute l'emprunt à la collection d'emprunt
                         * 
                         * */

                        break;

                    case 8:

                        Console.Clear();
                        foreach (Emprunt empruntCourant in collectionEmprunts)
                        {
                            Console.WriteLine("Date de l'emprunt : {0} \nDate de retour prévue {1} \nAdhérent : {2} \nLivre {3} ", empruntCourant.DateEmprunt.ToString(), empruntCourant.DateRetour.ToString(), empruntCourant.UnAdherent.NomAdherent, empruntCourant.UnLivre.TitreLivre);
                        }
                        Console.ReadKey();
                        break;

                    case 9:

                        /*A compléter
                        *
                        * Ecrire les instructions qui:
                        * A partir d'un numéro d'adhérent et d'un numéro de livre, recherche l'emprunt correspondant
                        * et enregistre son retour.
                        * 
                        * */

                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir le numéro d'adhérent:");
                        numAdherent = Console.ReadLine();
                        textMillieu("------------------------------------------------------------------------");


                        textMillieu("------------------------------------------------------------------------");
                        textMillieu("Saisir le numéro de livre:");
                        numLivre = Console.ReadLine();
                        textMillieu("------------------------------------------------------------------------");

                        foreach (Emprunt item in collectionEmprunts)
                        {
                            if (Convert.ToString(item.UnAdherent.NumeroAdherent) == numAdherent && Convert.ToString(item.UnLivre.NumLivre)==numLivre)
                            {
                                item.RetourEmprunt();
                            }
                        }
                        break;

                    case 0:

                        #region SAUVEGARDE DES DONNEES
                        Persistance.Sauvegarde(collectionLivres);
                        Persistance.Sauvegarde(collectionEmprunts);
                        Persistance.Sauvegarde(collectionAdherents);
                        #endregion

                        sortir = true;
                        break;

                    default:
                        sortir = true;
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

}

