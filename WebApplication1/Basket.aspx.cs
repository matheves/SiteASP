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
    public partial class Basket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadBasket();
        }

        protected void LoadBasket()
        {

            if (Session["Basket"] != null)
            {
                GridView1.DataSource = (Session["Basket"] as DataTable);
                GridView1.DataBind();

                if ((Session["Basket"] as DataTable).Rows.Count != 0)
                {
                    Label3.Visible = false;
                }
                else
                {
                    Label3.Visible = true;
                }

            }
            else
            {
                Label3.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Add Qty Button
            string ID = ((sender as Button).Parent.FindControl("Label2") as Label).Text;

            foreach(DataRow DR in (Session["Basket"] as DataTable).Rows)
            {
                if(DR["Product_id"].ToString() == ID)
                {
                    Int32 qty = Convert.ToInt32(DR["Qty"].ToString());
                    qty += 1;
                    DR["Qty"] = qty.ToString();
                }
            }
            LoadBasket();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Sub Qty Button
            string ID = ((sender as Button).Parent.FindControl("Label2") as Label).Text;

            foreach (DataRow DR in (Session["Basket"] as DataTable).Rows)
            {
                if (DR["Product_id"].ToString() == ID)
                {
                    Int32 qty = Convert.ToInt32(DR["Qty"].ToString());
                    qty -= 1;
                    if (qty == 0)
                    {
                        DR.Delete();
                        break;
                    } 
                    else
                    {
                        DR["Qty"] = qty.ToString();
                    }
                }
            }
            LoadBasket();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Payment button ( Create Factor )-------------------------------------------------------------
            if (Session["Basket"] != null && Session["UserID"] != null)
            {
                if ((Session["Basket"] as DataTable).Rows.Count != 0)
                {
                    // Payment Button ( Create Factor ) -------------------------------
                    // Create Connection
                    SqlConnection SC = new SqlConnection();
                    SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
                    SC.Open();
                    // Create the Command
                    SqlDataAdapter SDA = new SqlDataAdapter();
                    SDA.InsertCommand = new SqlCommand();
                    SDA.InsertCommand.CommandType = CommandType.Text;
                    SDA.InsertCommand.CommandText = "insert into Factors values (@p1,@p2,@p3)";
                    SDA.InsertCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(Session["UserID"].ToString()));
                    SDA.InsertCommand.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    SDA.InsertCommand.Parameters.AddWithValue("@p3", 0);
                    SDA.InsertCommand.Connection = SC;
                    // Execute the Command
                    SDA.InsertCommand.ExecuteNonQuery();

                    // Get The Last Factor ID -------------------------------------------------
                    // Step 2 - Create the Command
                    SqlDataAdapter SDA2 = new SqlDataAdapter();
                    SDA2.SelectCommand = new SqlCommand();
                    SDA2.SelectCommand.CommandType = CommandType.Text;
                    SDA2.SelectCommand.Connection = SC;
                    SDA2.SelectCommand.CommandText = "select top 1 * from Factors order by Factore_id desc";
                    // Step 3 - Fill the dataset
                    DataSet DS = new DataSet();
                    SDA2.Fill(DS);
                    // Step 4 - Filling the Form
                    string FID = DS.Tables[0].Rows[0]["Factore_id"].ToString();

                    // Create on Insert The Items for this Factors -------------------------------------
                    SqlDataAdapter SDA3 = new SqlDataAdapter();
                    foreach (DataRow DR in (Session["Basket"] as DataTable).Rows)
                    {
                        SDA3.InsertCommand = new SqlCommand();
                        SDA3.InsertCommand.CommandType = CommandType.Text;
                        SDA3.InsertCommand.CommandText = "insert into FactorItems values (@p1,@p2,@p3,@p4,@p5)";
                        SDA3.InsertCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(FID));
                        SDA3.InsertCommand.Parameters.AddWithValue("@p2", Convert.ToInt32(DR["Product_id"].ToString()));
                        SDA3.InsertCommand.Parameters.AddWithValue("@p3", Convert.ToInt32(DR["Qty"].ToString()));
                        SDA3.InsertCommand.Parameters.AddWithValue("@p4", Convert.ToDouble(DR["Product_Price"].ToString()));
                        Double Sum = Convert.ToInt32(DR["Qty"].ToString()) * Convert.ToDouble(DR["Product_Price"].ToString());
                        SDA3.InsertCommand.Parameters.AddWithValue("@p5", Sum);

                        SDA3.InsertCommand.Connection = SC;
                        SDA3.InsertCommand.ExecuteNonQuery();
                    }
                    SC.Close();
                }
            }
        }
    }
}