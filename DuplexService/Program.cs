﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Contracts;
using System.Threading;

namespace DuplexService
{
    class Program
    {
        static void Main(string[] args)
        {
            var binding = new NetTcpBinding();
            string address = "net.tcp://localhost:9998/Duplex";

            var host = new ServiceHost(typeof(Duplex));
            host.AddServiceEndpoint(typeof(IDuplex), binding, address);

            host.Open();
            Console.WriteLine("Duplex WCF service is open. Press <enter> to finish...");
            Console.ReadKey(false);
        }
    }
}
