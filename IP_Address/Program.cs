using System;
using System.Net;

namespace IP_Address
{
    class Program
    {
        static void Main()
        {
            IPAddress[] ip;
            IPHostEntry entry;
            string hostName = "";

            hostName = Dns.GetHostName();
            Console.WriteLine("Hostname of computer: " + hostName);

            entry = Dns.GetHostEntry(hostName);
            ip = entry.AddressList;

            for (int i = 0; i < ip.Length; i++)
            {
                Console.WriteLine("IP Address: " + ip[i]);
            }
        }
    }
}
