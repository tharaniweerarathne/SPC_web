using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class AddStock : System.Web.UI.Page
    {
        DrugServiceReference.DrugDetailsWebServiceSoapClient obj =
   new DrugServiceReference.DrugDetailsWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dsDrug = obj.getDrugName();
                dlDrug.DataSource = dsDrug;
                dlDrug.DataValueField = "Name";
                dlDrug.DataBind();

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = dlDrug.Text;

            DataSet stockData = obj.SearchStock(Name);

            gvStock.DataSource = stockData;
            gvStock.DataBind();

            gvStock.DataSource = obj.SearchStock(dlDrug.Text);
            gvStock.DataBind();
        }

        protected void btnAddStock_Click(object sender, EventArgs e)
        {
            String DrugID = obj.getDrugId(dlDrug.SelectedItem.Text);
            int stockQuantity = Convert.ToInt32(txtStockQuantity.Text);

            bool isSuccess = obj.AddStock(DrugID, stockQuantity);

            gvStock.DataSource = obj.SearchStock(DrugID);
            gvStock.DataBind();

            if (isSuccess)
            {
                lblText.Text = "Failed to add stock. Please try again.";
            }
            else
            {
                lblText.Text = "Stock added successfully!";
            }
        }
    }
}