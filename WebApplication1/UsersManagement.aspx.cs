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
    public partial class UsersManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["IsAdmin"] == null) // if anyone logged in ?
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
               if( Session["IsAdmin"].ToString() == "no")
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
            SDA.SelectCommand.CommandText = "Select * from Users";

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Feed the GridView
            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();

            SC.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.InsertCommand = new SqlCommand();
            SDA.InsertCommand.CommandType = CommandType.Text;
            SDA.InsertCommand.CommandText = "insert into Users(Users_Name,  Users_BirthDate, Users_City, Users_Email, Users_Image, Users_Password) values (@p1,@p2,@p3,@p4,@p5,@p6)";
            SDA.InsertCommand.Parameters.AddWithValue("@p1", TxtName.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p2", TxtDay.SelectedItem.ToString() + "/" + TxtMonth.SelectedItem.ToString() + "/" + TxtYear.SelectedItem.ToString());
            SDA.InsertCommand.Parameters.AddWithValue("@p3", TxtCity.SelectedItem.ToString());
            SDA.InsertCommand.Parameters.AddWithValue("@p4", TxtEmail.Text);
            if (LabelImage.Text.Equals("file saved"))
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p5", Image1.ImageUrl.ToString());
            }
            else
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p5", "~/img/default.jpeg");
            }

            if (TxtPassword.Text.Equals(TxtRepeatPassword.Text))
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p6", WebApplication1.App_Code.UtilityClass.Hash_Me(TxtPassword.Text));
            }
            else
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p6", WebApplication1.App_Code.UtilityClass.Hash_Me("default"));
            }

            SDA.InsertCommand.Connection = SC;
            // Execute the Command
            SDA.InsertCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void Button2_Click(object sender, EventArgs e)
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            string ID = ((sender as Button).Parent.FindControl("Label1") as Label).Text;
            int Id = Convert.ToInt32(ID);
            //Step 1 -  Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            //Step 2 -  Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.DeleteCommand = new SqlCommand();
            SDA.DeleteCommand.CommandType = CommandType.Text;
            SDA.DeleteCommand.CommandText = "delete from Users where Users_id = @p1";
            SDA.DeleteCommand.Parameters.AddWithValue("@p1", Id);

            SDA.DeleteCommand.Connection = SC;

            //Execute the command
            SDA.DeleteCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string ID = ((sender as Button).Parent.FindControl("Label1") as Label).Text;
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
            SDA.SelectCommand.CommandText = "Select * from Users where Users_id = @p1";
            SDA.SelectCommand.Parameters.AddWithValue("@p1", Id);

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Filling the form
            TxtName.Text = DS.Tables[0].Rows[0]["Users_Name"].ToString();
            TxtEmail.Text = DS.Tables[0].Rows[0]["Users_Email"].ToString();
            TxtCity.Text = DS.Tables[0].Rows[0]["Users_City"].ToString();
            String fullDate = DS.Tables[0].Rows[0]["Users_BirthDate"].ToString();
            string[] splitDate = fullDate.Split('/');
            TxtDay.Text = splitDate[0];
            TxtMonth.Text = splitDate[1];
            TxtYear.Text = splitDate[2];
            Image1.ImageUrl = DS.Tables[0].Rows[0]["Users_Image"].ToString();
            TxtPassword.Text = DS.Tables[0].Rows[0]["Users_Password"].ToString();

            Label2.Text = DS.Tables[0].Rows[0]["Users_Id"].ToString();

            SC.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.UpdateCommand = new SqlCommand();
            SDA.UpdateCommand.CommandType = CommandType.Text;
            SDA.UpdateCommand.CommandText = "Update Users set Users_Name=@p1,Users_BirthDate = @p3, Users_City = @p4, Users_Email = @p5, Users_Image = @p6, Users_Password = @p7  where Users_Id=@p2";
            SDA.UpdateCommand.Parameters.AddWithValue("@p1", TxtName.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p2", Convert.ToInt32(Label2.Text));
            SDA.UpdateCommand.Parameters.AddWithValue("@p3", TxtDay.SelectedItem.ToString() + "/" + TxtMonth.SelectedItem.ToString() + "/" + TxtYear.SelectedItem.ToString());
            SDA.UpdateCommand.Parameters.AddWithValue("@p4", TxtCity.SelectedItem.ToString());
            SDA.UpdateCommand.Parameters.AddWithValue("@p5", TxtEmail.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p6", Image1.ImageUrl.ToString());
          

            if (TxtPassword.Text.Equals(TxtRepeatPassword.Text))
            {
                SDA.UpdateCommand.Parameters.AddWithValue("@p7", WebApplication1.App_Code.UtilityClass.Hash_Me(TxtPassword.Text));
            }
            else
            {
                SDA.UpdateCommand.Parameters.AddWithValue("@p7", WebApplication1.App_Code.UtilityClass.Hash_Me("default"));
            }

            SDA.UpdateCommand.Connection = SC;
            // Execute the Command
            SDA.UpdateCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Management.aspx");
        }
    }
}