using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listeCapitale;
            listeCapitale = new List<string>();

            string uneChaine = "Paris";

            listeCapitale.Add(uneChaine);
            listeCapitale.Add("Madrid");
            listeCapitale.Add("Stockholm");
            listeCapitale.Add("Londres");
            listeCapitale.Add("Anvers");

            bool suppression = listeCapitale.Remove("Madrid");

            foreach (string capitaleCourante in listeCapitale)
            {
                Console.WriteLine(capitaleCourante);
            }

            Console.WriteLine("Saisir une capitale européenne");
            string capitaleSaisie = Console.ReadLine();
            foreach (string capitaleCourante in listeCapitale)
            {
                if(capitaleCourante == capitaleSaisie)
                {
                    break;
                }
            }

            bool trouve = listeCapitale.Contains("Rome");

            string capitale = listeCapitale[0];
            Console.WriteLine(capitale);

            for (int i = 0; i < listeCapitale.Count; i++)
            {
                Console.WriteLine(listeCapitale[i]);
            }

        }
    }
}
