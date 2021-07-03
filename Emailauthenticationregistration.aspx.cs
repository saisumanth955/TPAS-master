using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPAS
{
    public partial class Emailauthenticationregistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "update Login1 set email = @email where Username = @user";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@email", TextBox2.Text);
            com.Parameters.AddWithValue("@user", TextBox1.Text);
            com.ExecuteNonQuery();
            Response.Write("You have successfully registered");
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}