using Matrimonial_client.SignupServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Matrimonial_client.User
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Register(object sender, EventArgs e)
        {
            SignupServiceReference.SignupClient service_signup = new SignupServiceReference.SignupClient();
            user u = new user();
            u.Username = UserName_Input.Text;
            u.Email = Email_Input.Text;
            u.Mobileno = Mobileno_Input.Text;
            u.Password = Password_Input.Text;
            if(Password_Input.Text == ConfirmPass_Input.Text)
            {
                bool exist = service_signup.Signup(u);
                if(!exist)
                {
                    Alert.show("UserName/PAssword Already Exist");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Alert.show("Password and Confirm PAssword must be same");
            }
        }
    }
}