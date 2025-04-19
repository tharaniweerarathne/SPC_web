using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class DrugDetails : System.Web.UI.Page
    {
        DrugServiceReference.DrugDetailsWebServiceSoapClient obj =
   new DrugServiceReference.DrugDetailsWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDrugId.Text = obj.AutoDrugId();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblText.Text = "Data validated"; 

                string sourceType = dlSource.SelectedItem.Text;
                int quantity;

                try
                {
                    quantity = Convert.ToInt32(txtQuantity.Text);

                    string value = obj.insertDrug(
                        txtDrugId.Text,
                        txtDrugrname.Text,
                        txtcategory.Text,
                        quantity, 
                        txtDrugPrice.Text,
                        sourceType 
                    );

                    int norecord = 0;
                    if (Int32.TryParse(value, out norecord)) 
                    {
                        if (norecord > 0)
                        {
                            lblText.Text = "Record Successfully Added";
                        }
                        else
                        {
                            lblText.Text = "Failed to Add Record";
                        }
                    }
                    else
                    {
                        lblText.Text = "An error occurred while adding the record.";
                    }
                }
                catch (FormatException)
                {
                    lblText.Text = "Please enter a valid quantity.";
                }
            }
            else
            {
                lblText.Text = "Please fill in all required fields correctly.";
            }

        }
    }
}