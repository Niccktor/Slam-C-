using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonhomme_qui_bouge
{
    class Program
    {
        private static void Main(string[] args)
        {

            int x = 0;
            int y = 0;
            int largeur = 40;
            int longueur = 22; 
            Console.WriteLine(@"          .   ,               ");
            Console.WriteLine(@"       '. '.  \  \            ");
            Console.WriteLine(@"      ._ '-.'. `\  \          ");
            Console.WriteLine(@"        '-._; .'; `-.'.       ");
            Console.WriteLine(@"       `~-.; '.       '.      ");
            Console.WriteLine(@"        '--,`           '.    ");
            Console.WriteLine(@"           -='.          ;    ");
            Console.WriteLine(@" .--=~~=-,    -.;        ;    ");
            Console.WriteLine(@" .-=`;    `~,_.;        /     ");
            Console.WriteLine(@"`  ,-`'    .-;         |      ");
            Console.WriteLine(@"   .-~`.    .;         ;      ");
            Console.WriteLine(@"    .;.-   .-;         ,\     ");
            Console.WriteLine(@"      `.'   ,=;     .-'  `~.-._");
            Console.WriteLine(@"       .';   .';  .'      .'   '-.  ");
            Console.WriteLine(@"          .\  ;  ;        ,.' _  a',   ");
            Console.WriteLine("         .'~\"; -`   ;  ;   \"~` `'-=.) ");
            Console.WriteLine(@"       .' .'   . _;  ;',  ;");
            Console.WriteLine(@"       '-.._`~`.'  \  ; ; :          ");
            Console.WriteLine(@"            `~'    _'\\_ \\_         ");
            Console.WriteLine("                  /=`^^=`\"\"/`)-.     ");
            Console.WriteLine(@"                  \ =  _ =     =\    ");
            Console.WriteLine(@"                   `""` `~-. =   ;");
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);

                switch (info.Key)                
                {
                    case ConsoleKey.Q:
                        if (x > 0)
                        {
                            Console.MoveBufferArea(x, y, largeur, longueur, x - 1, y);
                            x--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (x < Console.WindowWidth - largeur)
                        {
                            Console.MoveBufferArea(x, y, largeur, longueur, x + 1, y);
                            x++;
                        }
                        break;
                    case ConsoleKey.Z:
                        if (y > 0)
                        {
                            Console.MoveBufferArea(x, y, largeur, longueur, x, y - 1);
                            y--;
                        }
                        break;
                    case ConsoleKey.S:
                        Console.MoveBufferArea(x, y, largeur, longueur, x, y + 1);
                        y++;
                        break;
                }
                if (info.Key == ConsoleKey.Backspace)
                    break;
            }


        }
    }
}
