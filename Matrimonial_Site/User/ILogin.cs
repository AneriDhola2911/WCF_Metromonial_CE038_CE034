using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Matrimonial_Site.User
{
       [ServiceContract]
        public interface ILogin
        {
            [OperationContract]
            /*If user exist or not */
            bool Login(string username,string password);
        }
    
}
