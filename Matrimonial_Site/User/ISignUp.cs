using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Matrimonial_Site.User
{
    [ServiceContract]
    public interface ISignup
    {
        [OperationContract]
        /*If user exist or not */
        bool Signup(user u);
    }
    [DataContract]
    public class user
    {
        public int Id { get; set; }
        string username = "user1";
        string email = "user1@gmail.com";
        string password = "user1@111";
        string mobileno = "1234567890";
        public user() { }
        public user(string uname, string email, string password, string mobileno)
        {
            this.username = uname;
            this.email = email;

            this.password = password;
            this.mobileno = mobileno;
        }
        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [DataMember]
        public string Mobileno
        {
            get { return mobileno; }
            set { mobileno = value; }
        }
    }
}
