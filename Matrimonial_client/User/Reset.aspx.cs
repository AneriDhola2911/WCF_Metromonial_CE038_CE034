using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Matrimonial_client.User
{
    public partial class Reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reset_button_Click(object sender, EventArgs e)
        {
            string quid = Request.QueryString["Uid"];
            ResetServiceReference.ResetClient rc = new ResetServiceReference.ResetClient();
            if (password_input.Text == confirm_password.Text)
            {
                bool res = rc.Reset(quid, password_input.Text);
                if (res)
                {
                    Response.Redirect("login.aspx");
                }
                Alert.show("Request Not found Please Try Again");
            }
            Alert.show("Password And Confirm Must Match");
        }
    }
}