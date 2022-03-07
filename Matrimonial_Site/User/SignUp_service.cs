using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrimonial_Site.User
{
    public class SignUp_service : ISignup
    {
        Matrimonial_Model m1 = new Matrimonial_Model();
        public bool Signup(user u)
        {
            if (m1.Users.Where(se => se.Username == u.Username || se.Email == u.Email).FirstOrDefault<user>() != null)
            {
                return false;
            }
            m1.Users.Add(u);
            m1.SaveChanges();
            return true;
        }
        public bool Login(user u)
        {
            if (m1.Users.Where(se => se.Username == u.Username && se.Password == u.Password).FirstOrDefault<user>() != null)
            {
                return true;
            }

            return false;
        }
    }
}
