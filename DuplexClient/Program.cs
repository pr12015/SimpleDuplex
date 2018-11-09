using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DuplexClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var binding = new NetTcpBinding();
            string address = "net.tcp://localhost:9998/Duplex";
            var handler = new CallBackHandler();

            using(var proxy = new DuplexServiceClient(handler, binding, address))
            {
                proxy.SignIn(100);
                Console.WriteLine("Signing in...");
                //while (true) ;
            }
        }
    }
}
