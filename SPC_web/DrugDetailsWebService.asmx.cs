using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SPC_web
{
    /// <summary>
    /// Summary description for DrugDetailsWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DrugDetailsWebService : System.Web.Services.WebService
    {

        SqlConnection sqlCon = null;
        public SqlConnection getConnection()
        {
            try
            {
                sqlCon = new SqlConnection
          ("data source=LAPTOP-M91CBP08\\SQLEXPRESS01;initial catalog=SPC_DB;user id=sa;password=tharani@2003");

                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Db" + ex);
            }
            return sqlCon;
        }

        [WebMethod]
        public string AutoDrugId()
        {
            string DrugID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select DrugID from TableDrug", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                bool records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    string idString = id.Substring(1);
                    int CTR = Int32.Parse(idString);
                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;
                        DrugID = "D00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        DrugID = "D0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        DrugID = "D" + CTR;
                    }
                }
                else
                {
                    DrugID = "D001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                DrugID = e1.ToString();
            }
            return DrugID;
        }

        [WebMethod]
        public string insertDrug(string DrugID, string Name, string Category, int Quantity, string UnitPrice, string SourceType)
        {
            int NoRows = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO TableDrug (DrugID, Name, Category, Quantity, UnitPrice, SourceType) VALUES ('" +
                          DrugID + "','" + Name + "','" + Category + "'," + Quantity + ",'" + UnitPrice + "','" + SourceType + "');", sqlCon);


                NoRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return NoRows.ToString();
        }

        [WebMethod]
        public bool AddStock(string DrugID, int newStock)
        {
            bool records = false;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("update TableDrug set Quantity = Quantity+" + newStock + "where DrugID='" + DrugID + "'", sqlCon);

                SqlDataReader dr = cmd.ExecuteReader();
                records = dr.HasRows;
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating in the Drug stock" + ex);
            }
            return records;
        }

        [WebMethod]
        public DataSet SearchStock(string Name)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();

                string query = string.IsNullOrEmpty(Name) ?
                   "SELECT * FROM TableDrug" :
                   "SELECT * FROM TableDrug WHERE Name = '" + Name + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TableDrug");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Drug Stock" + ex);
            }
            return ds;
        }


        [WebMethod]
        public string AutoOrderId()
        {
            string OrderID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select OrderID from TableOrder", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                bool records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    string idString = id.Substring(2);
                    int CTR = Int32.Parse(idString);
                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;
                        OrderID = "OR00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        OrderID = "OR0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        OrderID = "OR" + CTR;
                    }
                }
                else
                {
                    OrderID = "OR001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                OrderID = e1.ToString();
            }
            return OrderID;
        }

        [WebMethod]
        public bool PlaceOrder(string OrderID, string DrugID, string PharmacyID, int Quantity)
        {
            bool records = false;
            try
            {
                getConnection();

                SqlCommand cmdUpdateStock = new SqlCommand("UPDATE TableDrug SET Quantity = Quantity - " + Quantity + " WHERE DrugID = '" + DrugID + "' AND Quantity >= " + Quantity, sqlCon);

                int rowsAffected = cmdUpdateStock.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    SqlCommand cmdInsertOrder = new SqlCommand("INSERT INTO TableOrder (OrderID, DrugID, PharmacyID, Quantity) VALUES ('" + OrderID + "', '" + DrugID + "', '" + PharmacyID + "', " + Quantity + ")", sqlCon);
                    int orderRowsAffected = cmdInsertOrder.ExecuteNonQuery();

                    if (orderRowsAffected > 0)
                    {
                        records = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing order: " + ex);
            }
            return records;
        }


        [WebMethod]
        public DataSet SearchStockPharmacy(string Name)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();

                string query = string.IsNullOrEmpty(Name) ?
                    "SELECT * FROM TableDrug" :
                    "SELECT * FROM TableDrug WHERE Name = '" + Name + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TableDrug");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Drug stock: " + ex);
            }
            return ds;
        }

        [WebMethod]
        public DataSet getPharmacyName()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdDrug = new SqlCommand("Select PharmacyName from PharmaciesTable",
                    sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdDrug);

                da.Fill(ds, "PharmaciesTable");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Pharmacy Name" + ex);
            }
            return ds;
        }

        [WebMethod]
        public string getPharmacyId(string PharmacyName)
        {
            string PharmacyID = "";
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand
                ("Select PharmacyID from  PharmaciesTable where PharmacyName  ='" +
                PharmacyName + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                Boolean records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        PharmacyID = dr[0].ToString();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Pharmacy Name" + ex);
            }
            return PharmacyID;
        }

        [WebMethod]
        public DataSet getDrugName()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select Name from TableDrug", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "TableDrug");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Drug Name " + ex);
            }
            return ds;
        }

        [WebMethod]
        public string getDrugId(string Name)
        {
            string DrugID = "";
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select DrugID from TableDrug where Name = '" + Name + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                Boolean records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        DrugID = dr[0].ToString();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Drug Name" + ex);
            }
            return DrugID;
        }

        [WebMethod]
        public DataSet SearchOrdersByPharmacy(string PharmacyName)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();

                string pharmacyID = getPharmacyId(PharmacyName);

                if (string.IsNullOrEmpty(pharmacyID))
                {
                    Console.WriteLine("No pharmacy found with the given name.");
                    return ds; 
                }

                string query = "SELECT TOP (1000) OrderID, DrugID, PharmacyID, Quantity FROM TableOrder WHERE PharmacyID = '" + pharmacyID + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TableOrder");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching orders: " + ex);
            }
            return ds;
        }

    }
}
