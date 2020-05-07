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
    public partial class NewsList : System.Web.UI.Page
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
            SDA.SelectCommand.CommandText = "Select * from News";

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
            Response.Redirect("NewsItem.aspx?ID=" + ID);
        }
    }
}