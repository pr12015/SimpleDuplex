using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using System.ServiceModel;

namespace DuplexService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    class Duplex : IDuplex
    {
        public void SignIn(int value)
        {
            Console.WriteLine("Client Signed in with value: " + value);
            GetBill(value);
        }

        public static void GetBill(int value)
        {
            Console.WriteLine("Client sent: " + CallBack.SubtractOne(value));
        }

        static IDuplexCallBack CallBack
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IDuplexCallBack>();
            }
        }
    }
}
