
using Matrimonial_client.LoginServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Matrimonial_client.User
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void login_button_Click(object sender, EventArgs e)
        {
            LoginServiceReference.LoginClient service_login = new LoginServiceReference.LoginClient();
            bool exist = service_login.Login(username_input.Text, password_input.Text);
            if (!exist)
            {
                Alert.show("UserName/PAssword are not valid");
            }
            else
            {
                Alert.show("success");
            }
        }
    }
}