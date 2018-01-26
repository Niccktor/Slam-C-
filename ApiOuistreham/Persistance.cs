using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ApiOuistreham
{

    /// <summary>
    /// Classe permetant de charger et de sauvegarder des collections de l'Api Ouistreham
    /// </summary>
    /// <remarks>Les données sont sérialisées puis sauvgardées dans un fichier</remarks>
    public static class Persistance
    {
        private static string repertoireApplication = Environment.CurrentDirectory + @"\";
        
        /// <summary>
        /// Retourne la collection de navires de l'application
        /// </summary>
       /// <returns>Retourne une collection de navires</returns>
       /// <remarks>La collection est vide si aucun Navire n'a été sauvegardé</remarks>
        public static List<Navire> ChargeNavire()
        {
            FileStream fs = null;
            List<Navire> listeItem = new List<Navire>();
            string chemin = repertoireApplication + "navire";
            if (File.Exists(chemin))
            {
                fs = new FileStream(chemin, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                listeItem = (List<Navire>)formatter.Deserialize(fs);
                fs.Close();
            }
            return listeItem;
        }

        /// <summary>
        /// Retourne la collection de zones de stockage de l'application
        /// </summary>
        /// <returns>Retourne une collection zone de stockage</returns>
        /// <remarks>La collection est vide si aucune zone n'a été sauvegardé</remarks>
        public static List<ZoneDeStockage> ChargeZoneDeStockage()
        {
            FileStream fs = null;
            List<ZoneDeStockage> listeItem = new List<ZoneDeStockage>();
            string chemin = repertoireApplication + "zone";
            if (File.Exists(chemin))
            {
                fs = new FileStream(chemin, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                listeItem = (List<ZoneDeStockage>)formatter.Deserialize(fs);
                fs.Close();
            }
            return listeItem;
        }



        /// <summary>
        /// Sauvegarde la collection de ZoneDeStockage transmis en paramètre
        /// </summary>
        /// <param name="collectionZoneDeStockage">une collection de ZoneDeStockage</param>
        /// <remarks>L'application ne sauvegarde qu'une seule collection de ZoneDeStockage</remarks>
        public static void Sauvegarde(List<ZoneDeStockage> collectionZoneDeStockage)
        {
            FileStream file = null;
            file = File.Open(repertoireApplication + "zone", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, collectionZoneDeStockage);
            file.Close();
        }

        /// <summary>
        /// Sauvegarde la collection de Navires transmis en paramètre
        /// </summary>
        /// <param name="collectionNavire">une collection de Navires</param>
        /// <remarks>L'application ne sauvegarde qu'une seule collection de Navires</remarks>
        public static void Sauvegarde(List<Navire> collectionNavire)
        {
            FileStream file = null;
            file = File.Open(repertoireApplication + "navire", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, collectionNavire);
            file.Close();
        }

     
    }
}


