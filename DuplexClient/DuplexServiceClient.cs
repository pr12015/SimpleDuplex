using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Contracts;

namespace DuplexClient
{
    class DuplexServiceClient : DuplexChannelFactory<IDuplex>, IDisposable
    {
        IDuplex proxy;

        public DuplexServiceClient(CallBackHandler handler, NetTcpBinding binding, string address) 
            : base(new InstanceContext(handler), binding, address)
        {
            proxy = this.CreateChannel();
        }

        public void Dispose()
        {
            if (proxy != null)
                proxy = null;

            this.Close();
        }

        public void SignIn(int value)
        {
            proxy.SignIn(value);
        }
    }
}
