using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace NetworkProgramming1Day2
{
    class Client2
    {
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.51"), 1234);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch
            {
                Console.WriteLine("unable to connect to remote end point!\r\n");
                Main(args);
            }
            Console.Write("Enter Text ");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);

            sck.Send(data);
            Console.WriteLine("data sent!\r\n");
            Console.WriteLine("press any key to continue....");
            Console.Read();
            sck.Close();
        }
    }
}
