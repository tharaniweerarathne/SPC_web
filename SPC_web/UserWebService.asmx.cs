using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SPC_web
{
    /// <summary>
    /// Summary description for UserWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWebService : System.Web.Services.WebService
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
        public string AutoPharmacyId()
        {
            string PharmacyID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select PharmacyID from PharmaciesTable", sqlCon);
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
                        PharmacyID = "PH00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        PharmacyID = "PH0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        PharmacyID = "PH" + CTR;
                    }
                }
                else
                {
                    PharmacyID = "PH001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                PharmacyID = e1.ToString();
            }
            return PharmacyID;
        }

        [WebMethod]
        public string AutoUserId()
        {
            string UserID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select UserID from UserTable", sqlCon);
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
                        UserID = "U00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        UserID = "U0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        UserID = "U" + CTR;
                    }
                }
                else
                {
                    UserID = "U001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                UserID = e1.ToString();
            }
            return UserID;
        }

        [WebMethod]
        public string insertPharmacy(string PharmacyID, string PharmacyName, string Location, string ContactNo, string UserName, string Password)
        {
            int NoRows = 0;
            string UserID = AutoUserId();
            try
            {
                getConnection();

                SqlCommand cmd1 = new SqlCommand("INSERT INTO PharmaciesTable (PharmacyID, PharmacyName, Location, ContactNo) VALUES ('" +
                    PharmacyID + "', '" + PharmacyName + "', '" + Location + "', '" + ContactNo + "');", sqlCon);
                NoRows = cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("INSERT INTO UserTable (UserID, Username, Password, UserRole, PharmacyID) VALUES ('" +
                    UserID + "', '" + UserName + "', '" + Password + "', 'Pharmacy', '" + PharmacyID + "');", sqlCon);
                NoRows += cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            return NoRows.ToString();
        }

        [WebMethod]
        public string login(string UserName, string Password)
        {
            string result = "Invalid Credentials";
            try
            {
                getConnection();

                string query = "SELECT UserID, UserRole, Password FROM UserTable WHERE UserName = '" + UserName + "' AND Password = '" + Password + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string userRole = dr["UserRole"].ToString();
                        result = userRole + " Login Successful";
                    }
                }
                else
                {
                    result = "Invalid Credentials";
                }
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.ToString();
            }
            return result;
        }
    }
}
