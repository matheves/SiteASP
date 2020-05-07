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
    public partial class LastProducts : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
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
            SDA.SelectCommand.CommandText = "Select Top(" + Convert.ToInt32(HiddenField1.Value) + ") * from Products order by Product_id desc";

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Feed the GridView
            DataList1.DataSource = DS.Tables[0];
            DataList1.DataBind();

            SC.Close();
        }

        public string no_to_disp
        {
            get
            {
                return HiddenField1.Value;
            }
            set
            {
                HiddenField1.Value = value;
            }
        }
    }
}