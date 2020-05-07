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
    public partial class NewsItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                String ID = Request.QueryString["ID"].ToString();
                BindItemInfo(Convert.ToInt32(ID));
            }
        }

        protected void BindItemInfo(Int32 ID)
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
            SDA.SelectCommand.CommandText = "Select * from News where News_id = @p1";
            SDA.SelectCommand.Parameters.AddWithValue("@p1", ID);

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Filling the form
            Label1.Text = DS.Tables[0].Rows[0]["News_title"].ToString();
            Image1.ImageUrl = DS.Tables[0].Rows[0]["News_img"].ToString();
            Label2.Text = DS.Tables[0].Rows[0]["News_date"].ToString();
            Label3.Text = DS.Tables[0].Rows[0]["News_body"].ToString();

            SC.Close();
        }
    }
}