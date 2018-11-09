using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contracts
{
   [ServiceContract(CallbackContract = typeof(IDuplexCallBack))] 
    public interface IDuplex
    {
        [OperationContract]
        void SignIn(int value);
    }
}
