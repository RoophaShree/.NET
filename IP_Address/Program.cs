using System;
using System.Net;

namespace IP_Address
{
    class Program
    {
        static void Main()
        {
            IPAddress[] ips;
            IPHostEntry entry;
            string hostName = "";

            hostName = Dns.GetHostName();
            Console.WriteLine("Hostname of computer: " + hostName);

            entry = Dns.GetHostEntry(hostName);
            ips = entry.AddressList;

            for (int i = 0; i < ips.Length; i++)
            {
                Console.WriteLine("IP Address: " + ips[i]);
            }
        }
    }
}
