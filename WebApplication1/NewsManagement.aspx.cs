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
    public partial class NewsManagement : System.Web.UI.Page
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
            SDA.SelectCommand.CommandText = "Select * from News";

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.InsertCommand = new SqlCommand();
            SDA.InsertCommand.CommandType = CommandType.Text;
            SDA.InsertCommand.CommandText = "insert into News(News_title,  News_date, News_body, News_img) values (@p1,@p2,@p3,@p4)";
            SDA.InsertCommand.Parameters.AddWithValue("@p1", TextTitle.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p2", DayList.SelectedItem.ToString() + "/" + MonthList.SelectedItem.ToString() + "/" + YearList.SelectedItem.ToString());
            SDA.InsertCommand.Parameters.AddWithValue("@p3", TextBody.Text);
            if (LabelImage.Text.Equals("file saved"))
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p4", Image1.ImageUrl.ToString());
            }
            else
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p4", "~/img/default.jpeg");
            }

            SDA.InsertCommand.Connection = SC;
            // Execute the Command
            SDA.InsertCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            // Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.UpdateCommand = new SqlCommand();
            SDA.UpdateCommand.CommandType = CommandType.Text;
            SDA.UpdateCommand.CommandText = "Update News set News_title=@p1,News_date = @p3, News_body = @p4, News_img = @p5  where News_id=@p2";
            SDA.UpdateCommand.Parameters.AddWithValue("@p1", TextTitle.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p2", Convert.ToInt32(Label1.Text));
            SDA.UpdateCommand.Parameters.AddWithValue("@p3", DayList.SelectedItem.ToString() + "/" + MonthList.SelectedItem.ToString() + "/" + YearList.SelectedItem.ToString());
            SDA.UpdateCommand.Parameters.AddWithValue("@p4", TextBody.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p5", Image1.ImageUrl.ToString());
            SDA.UpdateCommand.Connection = SC;
            // Execute the Command
            SDA.UpdateCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string ID = ((sender as Button).Parent.FindControl("LabelID") as Label).Text;
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
            SDA.SelectCommand.CommandText = "Select * from News where News_id = @p1";
            SDA.SelectCommand.Parameters.AddWithValue("@p1", Id);

            //Step 3 - Fill the dataset 
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            //Step 4 - Filling the form
            TextTitle.Text = DS.Tables[0].Rows[0]["News_title"].ToString();
            TextBody.Text = DS.Tables[0].Rows[0]["News_body"].ToString();
            String fullDate = DS.Tables[0].Rows[0]["News_date"].ToString();
            string[] splitDate = fullDate.Split('/');
            DayList.Text = splitDate[0];
            MonthList.Text = splitDate[1];
            YearList.Text = splitDate[2];
            Image1.ImageUrl = DS.Tables[0].Rows[0]["News_img"].ToString();

            Label1.Text = DS.Tables[0].Rows[0]["News_Id"].ToString();

            SC.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string ID = ((sender as Button).Parent.FindControl("LabelID") as Label).Text;
            int Id = Convert.ToInt32(ID);
            //Step 1 -  Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            //Step 2 -  Create the Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.DeleteCommand = new SqlCommand();
            SDA.DeleteCommand.CommandType = CommandType.Text;
            SDA.DeleteCommand.CommandText = "delete from News where News_id = @p1";
            SDA.DeleteCommand.Parameters.AddWithValue("@p1", Id);

            SDA.DeleteCommand.Connection = SC;

            //Execute the command
            SDA.DeleteCommand.ExecuteNonQuery();

            SC.Close();

            LoadData();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Management.aspx");
        }
    }
}