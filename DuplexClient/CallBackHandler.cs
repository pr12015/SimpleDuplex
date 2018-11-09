using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace DuplexClient
{
    class CallBackHandler : IDuplexCallBack
    {
        public int SubtractOne(int value)
        {
            return --value;
        }
    }
}
