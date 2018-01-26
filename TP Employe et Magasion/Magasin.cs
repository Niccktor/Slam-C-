using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Employe_et_Magasion
{
    class Magasin
    {
        #region Variable Private

        private string _NomMagasin;
        private List<Employe> _ListEmploye;

        #endregion

        #region Asseeceurs Mutateurs
        public string NomMagasin
        {
            get { return _NomMagasin; }
        }
        public List<Employe> ListEmploye
        {
            get { return _ListEmploye; }
        }

        #endregion

        #region Constructeur
        public Magasin() { }
        public Magasin(string nomMagasin)
        {
            _NomMagasin = nomMagasin;
            _ListEmploye = new List<Employe>();
        }

        #endregion

        #region Methodes
        public Magasin AjouterEmployer(Employe employeAAjouter)
        {
            _ListEmploye.Add(employeAAjouter);
            return this;
        }
        public Magasin SupprimerEmployer(Employe employeASupprimer)
        {
            _ListEmploye.Remove(employeASupprimer);
            return this;
        }

        #endregion


    }
}
