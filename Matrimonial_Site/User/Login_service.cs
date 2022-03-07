using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrimonial_Site.User
{
    class Login_service:ILogin
    {
        Matrimonial_Model m1 = new Matrimonial_Model();
        public bool Login(string username ,string password)
        {
            if (m1.Users.Where(se => se.Username == username && se.Password == password).FirstOrDefault<user>() != null)
            {
                return true;
            }
            return false;
        }

       
    }
}
