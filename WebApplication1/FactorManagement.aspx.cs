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
    public partial class FactorManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsAdmin"] == null) // if anyone logged in ?
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (Session["IsAdmin"].ToString() == "no")
                {
                    Response.Redirect("AccessDenied.aspx");
                }
            }
            LoadDataFactor();
        }

        protected void LoadDataFactor()
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
            SDA.SelectCommand.CommandText = "Select * from Factors";

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Feed the GridView
            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();

            SC.Close();
        }

        protected void LoadDateFactorItem(int FactoreID)
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
            SDA.SelectCommand.CommandText = "select p.Product_Name, f.FactoreItem_No, f.FactoreItem_Sum from FactorItems f, Products p where f.Factore_id = @p1 and p.Product_id = f.Product_id;";
            SDA.SelectCommand.Parameters.AddWithValue("@p1", FactoreID);
            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Feed the GridView
            GridView2.DataSource = DS.Tables[0];
            GridView2.DataBind();

            SC.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ID = ((sender as Button).Parent.FindControl("Label2") as Label).Text;
            int Id = Convert.ToInt32(ID);
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.UpdateCommand = new SqlCommand();
            SDA.UpdateCommand.CommandType = CommandType.Text;
            SDA.UpdateCommand.CommandText = "Update Factors set Factore_Status=1 where Factore_id=@p1";
            SDA.UpdateCommand.Parameters.AddWithValue("@p1", Id);

            SDA.UpdateCommand.Connection = SC;
            // Execute the Command
            SDA.UpdateCommand.ExecuteNonQuery();

            SC.Close();

            LoadDataFactor();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string ID = ((sender as Button).Parent.FindControl("Label2") as Label).Text;
            int Id = Convert.ToInt32(ID);

            //Step 1 -  Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            //Step 2 -  Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.DeleteCommand = new SqlCommand();
            SDA.DeleteCommand.CommandType = CommandType.Text;
            SDA.DeleteCommand.CommandText = "delete from FactorItems where Factore_id = @p1";
            SDA.DeleteCommand.Parameters.AddWithValue("@p1", Id);

            SDA.DeleteCommand.Connection = SC;

            //Execute the command
            SDA.DeleteCommand.ExecuteNonQuery();

            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.DeleteCommand = new SqlCommand();
            SDA2.DeleteCommand.CommandType = CommandType.Text;
            SDA2.DeleteCommand.CommandText = "delete from Factors where Factore_id = @p1";
            SDA2.DeleteCommand.Parameters.AddWithValue("@p1", Id);

            SDA2.DeleteCommand.Connection = SC;

            //Execute the command
            SDA2.DeleteCommand.ExecuteNonQuery();

            SC.Close();

            LoadDataFactor();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string IDFactor = ((sender as Button).Parent.FindControl("Label2") as Label).Text;
            int IdFactor = Convert.ToInt32(IDFactor);

            //Step 1 -  Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            //Step 2 -  Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = new SqlCommand();
            SDA.SelectCommand.CommandType = CommandType.Text;
            SDA.SelectCommand.Connection = SC;
            SDA.SelectCommand.CommandText = "Select * from Factors where Factore_id = @p1";
            SDA.SelectCommand.Parameters.AddWithValue("@p1", IdFactor);

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Filling the form
            LabelDate.Text = DS.Tables[0].Rows[0]["Factore_DateTime"].ToString();
            LabelStatus.Text = DS.Tables[0].Rows[0]["Factore_Status"].ToString();
            int idUser = Convert.ToInt32(DS.Tables[0].Rows[0]["Users_id"].ToString());

            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.SelectCommand = new SqlCommand();
            SDA2.SelectCommand.CommandType = CommandType.Text;
            SDA2.SelectCommand.Connection = SC;
            SDA2.SelectCommand.CommandText = "Select * from Users where Users_id = @p1";
            SDA2.SelectCommand.Parameters.AddWithValue("@p1", idUser);

            //Step 3 - Fill the dataset 
            DataSet DS2 = new DataSet();
            SDA2.Fill(DS2);

            //Step 4 - Filling the form
            LabelName.Text = DS2.Tables[0].Rows[0]["Users_Name"].ToString();
            LabelEmail.Text = DS2.Tables[0].Rows[0]["Users_Email"].ToString();

            SC.Close();

            LoadDateFactorItem(IdFactor);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Management.aspx");
        }
    }
}