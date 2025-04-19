using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Login : System.Web.UI.Page
    {
        UserServiceReference.UserWebServiceSoapClient obj =
 new UserServiceReference.UserWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblText.Text = "Data validated";  

                string username = txtusername.Text;
                string password = txtPassword.Text;

                string loginResult = obj.login(username, password);

                lblText.Text = loginResult;

                if (loginResult.Contains("Pharmacy Login Successful"))
                {
                    Response.Redirect("PharmacyDashboard.aspx");
                }
                else if (loginResult.Contains("Staff Login Successful"))
                {
                    Response.Redirect("AddStock.aspx");
                }
                else
                {
                    lblText.Text = "Invalid credentials. Please try again.";
                }
            }
            else
            {
                lblText.Text = "Please fill in all required fields correctly.";
            }

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}