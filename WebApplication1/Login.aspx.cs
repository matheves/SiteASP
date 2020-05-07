using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // Step 1 - Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Step 2 - Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = new SqlCommand();
            SDA.SelectCommand.CommandType = CommandType.Text;
            SDA.SelectCommand.Connection = SC;
            SDA.SelectCommand.CommandText = "select * from Users where Users_Email = @p1 and Users_Password=@p2";
            SDA.SelectCommand.Parameters.AddWithValue("@p1", TxtEmail.Text);
            SDA.SelectCommand.Parameters.AddWithValue("@p2", WebApplication1.App_Code.UtilityClass.Hash_Me(TxtPassword.Text));

            // Step 3 - Fill the dataset
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            // Step 4 - Check the User Authentifications
            if (DS.Tables[0].Rows.Count != 0)
            {
                // I need to do login process
                Label3.Text = "Login successfull !!!";

                // Create Basket varaible
                DataTable DT = new DataTable();
                DT.Columns.Add("Product_id");
                DT.Columns.Add("Product_Name");
                DT.Columns.Add("Product_Price");
                DT.Columns.Add("Qty");

                Session["Basket"] = DT;

                // create another variable for User ID

                Session["UserID"] = DS.Tables[0].Rows[0]["Users_id"].ToString();

                if (DS.Tables[0].Rows[0]["Users_Name"].ToString() == "admin")
                {
                    Session["IsAdmin"] = "yes";
                    Response.Redirect("Management.aspx");
                }
                else
                {
                    Session["IsAdmin"] = "no";
                    Response.Redirect("Homepage.aspx");
                }
            }
            else
            {
                //Something is wrong
                Label3.Text = "Users Email or Password is Incorrect";
            }

            SC.Close();
        }
    }
}