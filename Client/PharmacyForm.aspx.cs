using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class PharmacyForm : System.Web.UI.Page
    {
        UserServiceReference.UserWebServiceSoapClient obj =
new UserServiceReference.UserWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    txtPharmacyId.Text = obj.AutoPharmacyId();
                    txtUserId.Text = obj.AutoUserId();
                }
                catch (Exception ex)
                {
                    lblText.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblText.Text = "Data validated"; 

                try
                {

                    string value = obj.insertPharmacy(
                        txtPharmacyId.Text,
                        txtPharmacyname.Text,
                        txtLocation.Text,
                        txtContactNumber.Text,
                        txtUsername.Text,
                        txtPassword.Text
                    );

                    int norecord = 0;
                    if (Int32.TryParse(value, out norecord)) 
                    {
                        if (norecord > 0)
                        {
                            lblText.Text = "Pharmacy registration completed successfully";
                        }
                        else
                        {
                            lblText.Text = "Pharmacy Registration Failed";
                        }
                    }
                    else
                    {
                        lblText.Text = "An error occurred during registration.";
                    }
                }
                catch (Exception ex)
                {
                    lblText.Text = "An unexpected error occurred: " + ex.Message;
                }
            }
            else
            {
                lblText.Text = "Please fill in all required fields correctly.";
            }

        }
    }
}