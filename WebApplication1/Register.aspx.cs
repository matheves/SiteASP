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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Create Connection
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
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
            if(LabelImage.Text.Equals("file saved"))
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p5", Image1.ImageUrl.ToString());
            } else
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p5", "~/img/default.jpeg");
            }
            
            if (TxtPassword.Text.Equals(TxtRepeatPassword.Text))
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p6", WebApplication1.App_Code.UtilityClass.Hash_Me(TxtPassword.Text));
            } else
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p6", WebApplication1.App_Code.UtilityClass.Hash_Me("default"));
            }

            SDA.InsertCommand.Connection = SC;
            // Execute the Command
            SDA.InsertCommand.ExecuteNonQuery();

            SC.Close();
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
    }
}