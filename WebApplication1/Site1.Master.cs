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
    public partial class Site1 : System.Web.UI.MasterPage
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
            SDA.SelectCommand.CommandText = "Select * from Counters where Counter_id = 1";

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Filling the form
            Label1.Text = DS.Tables[0].Rows[0]["Counter1"].ToString();
            Label2.Text = DS.Tables[0].Rows[0]["Counter2"].ToString();

            SC.Close();
        }
    }
}