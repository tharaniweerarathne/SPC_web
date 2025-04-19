using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class SearchOrder : System.Web.UI.Page
    {
        DrugServiceReference.DrugDetailsWebServiceSoapClient obj =
  new DrugServiceReference.DrugDetailsWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dsPharmacy = obj.getPharmacyName();
                dlPharmacy.DataSource = dsPharmacy;
                dlPharmacy.DataTextField = "PharmacyName";
                dlPharmacy.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string pharmacyName = dlPharmacy.SelectedItem.Text;

            DataSet orderData = obj.SearchOrdersByPharmacy(pharmacyName);
            gvStock.DataSource = orderData;
            gvStock.DataBind();
        }
    }
}