﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Matrimonial_Site.User
{
    [ServiceContract]
    public interface IReset
    {
        [OperationContract]
        bool Reset(string token, string pass);
    }
}
