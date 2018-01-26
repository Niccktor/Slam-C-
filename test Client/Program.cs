using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace test_Client
{
    class Program
    {
        static void lectureMsg()
        {
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            List<Exception> listLog = new List<Exception>();
            bool connecter = false;

            Thread msg = new Thread(new ThreadStart(lectureMsg));
            //Console.WriteLine("Saisir le message a envoyer.");
            //byte[] msg = ASCIIEncoding.Default.GetBytes(Console.ReadLine());
               
            //try
            //{
            //    socket.Connect(new IPEndPoint(IPAddress.Parse("192.168.43.108"), 123));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Bug {0}",e);
            //    Console.ReadKey();
            //    Environment.Exit(0);                
            //}
            //socket.Send(msg);
            //socket.Close();

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            while (!connecter)
            {
                Console.WriteLine("Saisir l'adresse IP du serveur de chat.");
                string ipServeur = Console.ReadLine();
                try
                {
                    socket.Connect(new IPEndPoint(IPAddress.Parse(ipServeur), 123));
                    connecter = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Le serveur n'est pas ouvert ou l'adresse IP {0} n'est pas valide.", ipServeur);
                    listLog.Add(e);
                }
            }
            
        }

    }
}
