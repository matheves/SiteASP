using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace WebApplication1
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Step 1 -  Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            //Step 2 -  Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = new SqlCommand();
            SDA.SelectCommand.CommandType = CommandType.Text;
            SDA.SelectCommand.Connection = SC;
            SDA.SelectCommand.CommandText = "Select * from Products";

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Filling the form
            DataList1.DataSource = DS.Tables[0];
            DataList1.DataBind();

            SC.Close();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string ID = ((sender as LinkButton).Parent.FindControl("Label4") as Label).Text;
            Response.Redirect("ProductItem.aspx?ID=" + ID);
        }

        public string FixStatus(object o)
        {
            if (o.ToString() == "1")
            {
                return "availlable";
            } else
            {
                return "not available";
            }
        }

        public Color FixColor(object o)
        {
            if (o.ToString() == "1")
            {
                return Color.Green;
            }
            else
            {
                return Color.Red;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Add to nasket button
            if (Session["Basket"] != null)
            {
                string ID = ((sender as Button).Parent.FindControl("Label4") as Label).Text;
                string Name = ((sender as Button).Parent.FindControl("Label6") as Label).Text;
                string Price = ((sender as Button).Parent.FindControl("Label7") as Label).Text;
                (Session["Basket"] as DataTable).Rows.Add(ID, Name, Price, "1");
                Response.Redirect("Basket.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}