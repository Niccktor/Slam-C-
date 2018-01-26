using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe_et_Magasion
{
    class Employe
    {
        #region variable Private
        private int _Numero;
        private string _Nom;
        private string _Prenom;

        #endregion

        #region Asseceurs Mutateurs
        public int Numero
        {
            get { return _Numero; }
        }
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }
        #endregion 


        public Employe() { }
        public Employe(int numero,string nom, string prenom)
        {
            _Numero = numero;
            _Nom = nom;
            _Prenom = prenom;
        }


    }
}
