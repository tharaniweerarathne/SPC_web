using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class PharmacyDashboard : System.Web.UI.Page
    {
        DrugServiceReference.DrugDetailsWebServiceSoapClient obj =
   new DrugServiceReference.DrugDetailsWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtOrderID.Text = obj.AutoOrderId();

                DataSet dsPharmacy = obj.getPharmacyName();
                dlPharmacy.DataSource = dsPharmacy;
                dlPharmacy.DataValueField = "PharmacyName"; 
                dlPharmacy.DataBind();

                DataSet dsDrug = obj.getDrugName();
                dlDrug.DataSource = dsDrug;
                dlDrug.DataValueField = "Name"; 
                dlDrug.DataBind();

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = dlDrug.Text;

            DataSet stockData = obj.SearchStockPharmacy(Name);

            gvStock.DataSource = stockData;
            gvStock.DataBind();
        }

        protected void btnOrderStock_Click(object sender, EventArgs e)
        {
            String DrugID = obj.getDrugId(dlDrug.SelectedItem.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            string pharmacyName = dlPharmacy.SelectedItem.Text;  

            string pharmacyId = obj.getPharmacyId(pharmacyName);

            string orderId = obj.AutoOrderId();

            bool isOrderPlaced = obj.PlaceOrder(orderId, DrugID, pharmacyId, quantity);

            if (isOrderPlaced)
            {
                lblText.Text = "Order has been successfully placed!";
            }
            else
            {
                lblText.Text = "Failed to place the order. Please check stock or try again.";
            }

            gvStock.DataSource = obj.SearchStockPharmacy(DrugID);
            gvStock.DataBind();
        }
    }
}