using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class SupplierForm : System.Web.UI.Page
    {
        SupplierServiceReference.SupplierWebServiceSoapClient obj =
    new SupplierServiceReference.SupplierWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtSupplierId.Text = obj.AutoSupplierId();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblText.Text = "Data validated"; 

                string supplierId = txtSupplierId.Text;
                string supplierName = txtSuppliername.Text;
                string supplierEmail = txtSupplierEmail.Text;
                string supplierPhone = txtSupplierPhone.Text;

                string value = obj.insertSupplier(supplierId, supplierName, supplierEmail, supplierPhone);

                int norecord = 0;
                if (Int32.TryParse(value, out norecord)) 
                {
                    if (norecord > 0)
                    {
                        lblText.Text = "Supplier registration completed successfully";  
                    }
                    else
                    {
                        lblText.Text = "Supplier registration failed";      
                    }
                }
                else
                {
                    lblText.Text = "An error occurred while adding the record."; 
                }
            }
            else
            {
                lblText.Text = "Please fill in all required fields correctly.";
            }

        }
    }
}