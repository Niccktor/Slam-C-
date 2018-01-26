using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulation
{
    class Voiture
    {
        private string _marque;
        private string _modele;        
        private bool _demarrer;
        private decimal _vitesse;
        private decimal _vitesseMaxi;

        public string Marque { get => _marque; }
        public string Modele { get => _modele; }
        public bool Demarrer { get => _demarrer; }
        public decimal Vitesse { get => _vitesse; }
        public decimal VitesseMaxi { get => _vitesseMaxi; set => _vitesseMaxi = value; }

        public Voiture(string marque)
        {
            _marque = marque;
            _modele = "";
            _demarrer = false;
            _vitesse = 0m;
            _vitesseMaxi = 150;
        }
        public Voiture(string marque, string modele)
        {
            _marque = marque;
            _modele = modele;
            _demarrer = false;
            _vitesse = 0m;
            _vitesseMaxi = 150;
        }
        public Voiture(string marque,string modele, decimal vitesseMaxi)
        {
            _marque = marque;
            _modele = modele;
            _demarrer = false;
            _vitesse = 0m;
            _vitesseMaxi = vitesseMaxi;
        }

        public void Accelerer(decimal vitesseEnPlus)
        {
            if (_demarrer)
            {
                _vitesse += vitesseEnPlus;
                if (_vitesse > _vitesseMaxi)
                {
                    _vitesse = _vitesseMaxi;
                }
            }
        }

        public void Decelerer(decimal vitesseEnMoin)
        {            
            _vitesse -= vitesseEnMoin;
            if (_vitesse < 0)
            {
                _vitesse = 0;
            }
        }

        public void DemarrerVoiture()
        {
            _demarrer = true;
        }

        public void CouperLeContact()
        {
            _demarrer = false;
        }




    }
}
