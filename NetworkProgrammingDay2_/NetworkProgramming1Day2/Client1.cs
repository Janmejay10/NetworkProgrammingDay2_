using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace NetworkProgramming1Day2
{
    class Client1
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("192.168.1.51"), 2000);
            sck.Connect(endpoint);

            Console.Write("enter Message: ");
            string msg = Console.ReadLine();
            byte[] msgBuffer = Encoding.Default.GetBytes(msg);
            sck.Send(msgBuffer, 0, msgBuffer.Length, 0);

            byte[] buffer = new byte[255];
            int rec = sck.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            Console.WriteLine("received: {0}", Encoding.Default.GetString(buffer));
            sck.Close();
            Console.Read();
        }
    }
}
