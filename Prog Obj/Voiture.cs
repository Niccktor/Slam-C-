using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Obj
{
    class Voiture
    {
        public string Marque
        {
            get;
            set;
        }
        private string Model;
        private int Test;

        public Voiture()
        {

        }

        public Voiture(string marque,string model, int test)
        {
            Marque = marque;
            Model = model;
            Test = test;
        }

    }
}
