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
    public partial class ProductManagement : System.Web.UI.Page
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
            LoadData();
        }

        protected void LoadData()
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

            //Step 4 - Feed the GridView
            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();

            SC.Close();

        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (PathImage.HasFile == true)
            {
                LabelImage.Text = "file is selected";
                string virtual_path = "~/img/";
                string physical_path = Server.MapPath(virtual_path);
                PathImage.SaveAs(physical_path + PathImage.FileName);
                LabelImage.Text = "file saved";
                Image1.ImageUrl = virtual_path + PathImage.FileName;
            }
            else
            {
                LabelImage.Text = "please select a file";
            }
        }

        protected void ButtonADD_Click(object sender, EventArgs e)
        {
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.InsertCommand = new SqlCommand();
            SDA.InsertCommand.CommandType = CommandType.Text;
            SDA.InsertCommand.CommandText = "insert into Products(Product_Name, Product_Category, Product_Price, Product_Image, Product_Status) values (@p1,@p2,@p3,@p4,@p5)";
            SDA.InsertCommand.Parameters.AddWithValue("@p1", TextName.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p2", TextCategory.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p3", Convert.ToDouble(TextPrice.Text));
            if (LabelImage.Text.Equals("file saved"))
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p4", Image1.ImageUrl.ToString());
            }
            else
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p4", "~/img/default.jpeg");
            }

            SDA.InsertCommand.Parameters.AddWithValue("@p5", Convert.ToInt16(TextStatut.Text));

            SDA.InsertCommand.Connection = SC;
            // Execute the Command
            SDA.InsertCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.UpdateCommand = new SqlCommand();
            SDA.UpdateCommand.CommandType = CommandType.Text;
            SDA.UpdateCommand.CommandText = "Update Products set Product_Name=@p1,Product_Category = @p3, Product_Price = @p4, Product_Image = @p5, Product_Status = @p6 where Product_id=@p2";
            SDA.UpdateCommand.Parameters.AddWithValue("@p1", TextName.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p2", Convert.ToInt32(Label3.Text));
            SDA.UpdateCommand.Parameters.AddWithValue("@p3", TextCategory.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p4", Convert.ToDouble(TextPrice.Text));
            SDA.UpdateCommand.Parameters.AddWithValue("@p5", Image1.ImageUrl.ToString());
            SDA.UpdateCommand.Parameters.AddWithValue("@p6", Convert.ToInt16(TextStatut.Text));

            SDA.UpdateCommand.Connection = SC;
            // Execute the Command
            SDA.UpdateCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ID = ((sender as Button).Parent.FindControl("Label2") as Label).Text;
            int Id = Convert.ToInt32(ID);

            //Step 1 -  Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            //Step 2 -  Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = new SqlCommand();
            SDA.SelectCommand.CommandType = CommandType.Text;
            SDA.SelectCommand.Connection = SC;
            SDA.SelectCommand.CommandText = "Select * from Products where Product_id = @p1";
            SDA.SelectCommand.Parameters.AddWithValue("@p1", Id);

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Filling the form
            TextName.Text = DS.Tables[0].Rows[0]["Product_Name"].ToString();
            TextCategory.Text = DS.Tables[0].Rows[0]["Product_Category"].ToString();
            TextPrice.Text = DS.Tables[0].Rows[0]["Product_Price"].ToString();
            Image1.ImageUrl = DS.Tables[0].Rows[0]["Product_Image"].ToString();
            TextStatut.Text = DS.Tables[0].Rows[0]["Product_Status"].ToString();

            Label3.Text = DS.Tables[0].Rows[0]["Product_id"].ToString();

            SC.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
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
            SDA.DeleteCommand.CommandText = "delete from Products where Product_id = @p1";
            SDA.DeleteCommand.Parameters.AddWithValue("@p1", Id);

            SDA.DeleteCommand.Connection = SC;

            //Execute the command
            SDA.DeleteCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Management.aspx");
        }
    }
}