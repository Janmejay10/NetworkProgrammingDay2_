using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace NetworkProgrammingDay2
{
    class N2
    {
        static void Main(string[] args)
        {                                         // Retrive the Name of HOST  
            string hostName = Dns.GetHostName();
            Console.WriteLine(hostName);
            // Get the IPAddress 
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            Console.WriteLine("My IP Address is :" + myIP);
            Console.ReadKey();
        }// or we could have used gethostbyname also instead of gethostentry
    }
}