﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contracts
{
    public interface IDuplexCallBack
    {
        [OperationContract]
        int SubtractOne(int value);
    }
}
