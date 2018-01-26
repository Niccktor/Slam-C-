using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace test_Client_Serveur
{
    class Program
    {

        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Parse("192.168.43.108"), 123));

            socket.Listen(1);
            Socket sockClient = socket.Accept();

            byte[] buf = new byte[50];
            sockClient.Receive(buf);
            Console.WriteLine(ASCIIEncoding.Default.GetString(buf));
            Console.ReadKey();

        }
    }
}

