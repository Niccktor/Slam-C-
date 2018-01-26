using System;
using System.Collections.Generic;


namespace ApiOuistreham
{
    [Serializable]
    /// <summary>
    /// Représente une zone de stockage sur le quai
    /// </summary>
    public class ZoneDeStockage
    {

        /// <summary>
        /// Obtient la capacité maximale de stockage de la zone de stockage
        /// </summary>
        public int CapaciteStockageMaximale { get; set; }


        /// <summary>
        /// Obtient le numéro de la zone de stockage
        /// </summary>
        public int NumZoneStockage { get; set; }

        /// <summary>
        /// Obtient la capacite de stockage restante de la zone de stockage
        /// </summary>
        public int CapaciteStockageDisponible { get; set; }

        /// <summary>
        /// Initialise une zone de Stockage
        /// </summary>
        /// <param name="numZoneDeStockage">Le numéro de la zone de stockage</param>
        /// <param name="capaciteStockage">La capacité maximale de la zone de stockage</param>
        public ZoneDeStockage(int numZoneDeStockage, int capaciteMaximaleDeStockage)
        {
            NumZoneStockage = numZoneDeStockage;
            CapaciteStockageMaximale = capaciteMaximaleDeStockage;
        }

        /// <summary>
        /// Stocke une quantité de fret sur la zone de stockage
        /// </summary>
        /// <param name="quantiteAStocker">La quantité de fret à stocker</param>
        ///<returns>La quantité n'ayant pu être stockée ou 0 si toute la quantité de fret a pu être stockée sur la zone</returns>
        public int Stocker(int quantiteAStocker)
        {
            int reste = CapaciteStockageDisponible - quantiteAStocker;
            if (reste < 0)
            {
                reste = Math.Abs(reste);
                CapaciteStockageDisponible = 0;
            }
            else
            {
                reste = 0;
                CapaciteStockageDisponible = CapaciteStockageDisponible - quantiteAStocker;
            }
            return reste;
        }

        /// <summary>
        /// Indique si la zone de stockage est vide ou non
        /// </summary>
        /// <returns>Vrai si la zone de stockage est vide, faux dans le cas contraire</returns>
        public bool EstVide()
        {
            return CapaciteStockageDisponible == 0;
        }

        /// <summary>
        /// Indique si la zone de stockage est remplie ou non
        /// </summary>
        /// <returns>Vrai si elle est remplie, faux dans le cas contraire</returns>
        public bool EstRempli()
        {
            return CapaciteStockageDisponible == CapaciteStockageMaximale;
        }

        /// <summary>
        /// Méthode qui retourne une collection de zone de stockage initialisée
        /// </summary>
        /// <returns>Une collection de ZoneDeStockage initialisée</returns>
        //public static List<ZoneDeStockage> SampleList()
        //{
        //    int[] tab = { 500, 648, 345, 812, 1000, 560, 2000, 896, 478, 256 };
        //    List<ZoneDeStockage> list = new List<ZoneDeStockage>();
        //    Random r = new Random();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        ZoneDeStockage z = new ZoneDeStockage(i + 1, tab[i]);
        //        list.Add(z);
        //    }
        //    return list;
        //}
    }
}
