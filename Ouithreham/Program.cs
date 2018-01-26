using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApiOuistreham;

namespace Ouithreham
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CHARGER DONNEES
            List<Navire> collectionNavire = Persistance.ChargeNavire();
            List<ZoneDeStockage> collectionStockage = Persistance.ChargeZoneDeStockage();
            #endregion

            #region VARIABLES ==> Utilisées pour la structure WHILE (menu)
            int choix;
            bool sortir = false;
            #endregion

            #region VARIABLES ==> Utilisées pour stocker les données métiers
            Navire unNavire = null;
            ZoneDeStockage zoneDeStockage = null;
            string numCin, nomNavire, libelleFret;
            int quantiteFret , numZoneDeStockage, capaciteMaxiamelDeStockage, capaciteStockageDisponible;

            #endregion

            #region VARIABLES (dénombrements et structures itératives)

            #endregion

            #region VARIABLES DIVERSES

            #endregion

            do
            {
                Console.Clear();
                textM("------------------------------------------------------------------------");
                textM("0 - Sortir du programme.");
                textM("1 - Ajouter un  Navire.");
                textM("2 - Ajouter une Zone de stockage.");
                textM("3 - Afficher la liste des navire.");
                textM("4 - Afficher la liste des zone de stockage.");
                textM("5 - Supprimer un navire.");
                textM("6 - Supprimer une zone de stockage.");

                textM("------------------------------------------------------------------------");
                Console.WriteLine("");


                choix = Convert.ToInt32(Console.ReadLine());


                switch (choix)
                {
                    case 1:

                        Console.Clear();

                        textM("------------------------------------------------------------------------");
                        textM("Saisir le numéro CIN.");
                        numCin = Console.ReadLine();
                        textM("Saisir le nom du navire.");
                        nomNavire = Console.ReadLine();
                        textM("Saisir le nom de la marchandise.");
                        libelleFret = Console.ReadLine();
                        textM("Saisir la quantite de marchandise.");
                        quantiteFret = Convert.ToInt32(Console.ReadLine());

                        unNavire = new Navire(numCin, nomNavire);
                        unNavire.LibelleFret = libelleFret;
                        unNavire.QuantiteFret = quantiteFret;
                        collectionNavire.Add(unNavire);
                        textM("Le navire a été ajouter.");
                        textM("------------------------------------------------------------------------");
                        break;

                    case 2:

                        textM("------------------------------------------------------------------------");
                        textM("Saisir le numéro de la zone de stockage.");
                        numZoneDeStockage =Convert.ToInt32(Console.ReadLine());
                        textM("Saisir la capactité de stockage maximale.");
                        capaciteMaxiamelDeStockage = Convert.ToInt32(Console.ReadLine());
                        textM("Saisir la capacite de stockage disponible.");
                        capaciteStockageDisponible = Convert.ToInt32(Console.ReadLine());


                        zoneDeStockage = new ZoneDeStockage(numZoneDeStockage, capaciteMaxiamelDeStockage);
                        zoneDeStockage.CapaciteStockageDisponible = capaciteStockageDisponible;
                        collectionStockage.Add(zoneDeStockage);

                        textM("La zone de stockage a été ajouter.");
                        textM("------------------------------------------------------------------------");
                        break;

                    case 3:
                        Console.Clear();
                        AffichageCollectionNavire(collectionNavire);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        AffichageCollectionZoneDeStockage(collectionStockage);
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        AffichageCollectionNavire(collectionNavire);

                        textM("------------------------------------------------------------------------");
                        textM("Saisir le numéros  ");
                        numCin = Console.ReadLine();
                        textM("------------------------------------------------------------------------");

                        




                        break;

                    case 0:

                        #region SAUVEGARDE DES DONNEES
                        Persistance.Sauvegarde(collectionNavire);
                        Persistance.Sauvegarde(collectionStockage);
                        #endregion

                        sortir = true;
                        break;

                    default:
                        sortir = true;
                        break;


                }

            } while (!sortir);

        }
        private static void textM(string T)
        {
            int esp = (Console.WindowWidth - T.Length) / 2;
            Console.SetCursorPosition(esp, Console.CursorTop);
            Console.WriteLine(T);
        }
        private static void AffichageCollectionNavire(List<Navire> collectionNavire)
        {
            if (collectionNavire.Count == 0)
            {
                textM("------------------------------------------------------------------------");
                textM("Aucun navire n'est référencé.");
                textM("------------------------------------------------------------------------");
                Console.ReadKey();                
            }
            else
            {
                Console.WriteLine("[Numéro CIN] [Nom navire] [ Fret ] [Quantite Fret]");

                foreach (Navire i in collectionNavire)
                {
                    Console.WriteLine();
                    Console.Write("[ {0} ] ", i.NoCIN);
                    Console.Write("[ {0} ] ", i.NomNavire);
                    Console.Write("[ {0} ] ", i.LibelleFret);
                    Console.Write("[ {0} ] ", i.QuantiteFret);
                }
            }
        }
        private static void AffichageCollectionZoneDeStockage(List<ZoneDeStockage> collectionStockage)
        {
            if (collectionStockage.Count == 0)
            {
                textM("------------------------------------------------------------------------");
                textM("Aucun navire n'est référencé.");
                textM("------------------------------------------------------------------------");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("[Numero Zone Stockage] [Capacité Maximale] [Capacité Disponible]");

                foreach (ZoneDeStockage i in collectionStockage)
                {
                    Console.WriteLine();
                    Console.Write("[ {0} ] ", i.NumZoneStockage);
                    Console.Write("[ {0} ] ", i.CapaciteStockageMaximale);
                    Console.Write("[ {0} ] ", i.CapaciteStockageDisponible);
                }
            }

        }
    }
}

