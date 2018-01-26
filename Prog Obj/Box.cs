using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Obj
{
    class Box
    {
        private double _lenght;
        private double _breadth;
        private double _height;

        public double Lenght
        {
            get { return _lenght; }
            set { _lenght = value; }
        }

        public Box()
        {

        }

        public Box(double aLength,double aBreadth, double aHeight)
        {
            _lenght = aLength;
            _breadth = aBreadth;
            _height = aHeight;
        }

        public void SetLength(double len)
        {
            _lenght = len;
        }

        public void SetBreadth(double bre)
        {
            _breadth = bre;
        }

        public void SetHeight(double hei)
        {
            _height = hei;
        }

        public double GetVolume()
        {
            return _lenght * _breadth * _height;
        }

        public bool SameVolume(Box uneBox)
        {
            
            if (this.GetVolume() == uneBox.GetVolume())
            {
                return true;
            }
            else
            {
                return false;
            }
        }






    }
}
