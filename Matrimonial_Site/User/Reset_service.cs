using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrimonial_Site.User
{
    public class Reset_service:IReset
        {

        Matrimonial_Model m1 = new Matrimonial_Model();
        public bool Reset(string token, string pass)
            {
            forgot fo = m1.Forgot.Where(se => se.Uid == token).FirstOrDefault<forgot>();
            if (fo == null)
            {
                return false;
            }
            user u1 = m1.Users.Where(us => us.Email == fo.Email).FirstOrDefault<user>();
            u1.Password = pass;
            m1.SaveChanges();
            return true;
        }
    }
}
