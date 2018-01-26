using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBoite
{
    class Boite
    {
        private string _Constructeur;
        private string _Caracteristique;
        private double _Hauteur;
        private double _Longueur;
        private double _Largeur;

        public double Hauteur
        {
            get { return _Hauteur; }
            set { _Hauteur = value; }
        }
        public double Longueur
        {
            get { return _Longueur; }
            set { _Longueur = value; }
        }
        public double Largeur
        {
            get { return _Largeur; }
            set { _Largeur = value; }
        }


        public Boite(string Constructeur)
        {
            _Constructeur = Constructeur;
        }

        public Boite(string Constructeur, string Caracteristique)
        {
            _Constructeur = Constructeur;
            _Caracteristique = Caracteristique;
        }

        public Boite(string Constructeur,double Hauteur,double Longueur,double Largeur)
        {
            _Constructeur = Constructeur;
            _Hauteur = Hauteur;
            _Longueur = Longueur;
            _Largeur = Largeur;
        }

        public Boite(string Constructeur,string Caracteristique, double Hauteur, double Longueur, double Largeur)
        {
            _Constructeur = Constructeur;
            _Caracteristique = Caracteristique;
            _Hauteur = Hauteur;
            _Longueur = Longueur;
            _Largeur = Largeur;
        }

        public Boite(double Hauteur, double Longueur, double Largeur)
        {
            _Hauteur = Hauteur;
            _Longueur = Longueur;
            _Largeur = Largeur;
        }

        public double GetVolume()
        {
            double volume;
            volume = Hauteur * Largeur * Longueur;
            return volume;
        }

        public bool SameVolume(Boite uneBoite)
        {
            if (this.GetVolume() == uneBoite.GetVolume()) { return true; }
            else { return false; }
        }

        public bool IsCube()
        {
            if (Hauteur == Largeur && Largeur == Longueur) { return true; }
            else { return false; }
        }
    }
}
