using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Matrimonial_client.User
{
    public partial class Forgot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ForgotServiceReference.ForgotClient fc = new ForgotServiceReference.ForgotClient();
            // string res= ;
            //Alert.show(email.Text);
            Alert.show(fc.Forgot(email_input.Text));
        }
    }
}