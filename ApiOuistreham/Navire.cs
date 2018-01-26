using System;


namespace ApiOuistreham
{
    [Serializable]

    public class Navire
    {        
        public string NoCIN
        {
            set;
            get;
        }

        public string NomNavire
        {
            get;
            set;
        }

        public string LibelleFret
        {
            get;
            set;
        }

        public int QuantiteFret
        {
            get;
            set;
        }

        public Navire(string numCIN, string nomNavire)
        {
            NoCIN = numCIN;
            NomNavire = nomNavire;
        }
        
        public Navire(string numCIN, string nomNavire, string libelleFret)
        {
            NoCIN = numCIN;
            NomNavire = nomNavire;
            LibelleFret = libelleFret;
        }

        public Navire(string numCIN, string nomNavire,string libelleFret,int quantiteFret)
        {
            NoCIN = numCIN;
            NomNavire = nomNavire;
            LibelleFret = libelleFret;
            QuantiteFret = quantiteFret;
        }

        public void Decharger(int quantiteDecharger)
        {
            if (QuantiteFret > quantiteDecharger)
            {
                QuantiteFret -= quantiteDecharger;
            }
        }

        public bool EstDecharger()
        {
            return QuantiteFret == 0;
        }

    }
}
