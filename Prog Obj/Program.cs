using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Box uneBox = new Box(6,5,4);
            uneBox.SetHeight(8);
            
            Box aBox = new Box();

            aBox.Lenght = 12;
            double volume = aBox.GetVolume(); // mettre un (double) a la place du (int)




            Console.ReadKey();

             
        }
        static void afficherVoiture(Box box)
        {
            Console.WriteLine(box.Lenght);
        }
    }
}
