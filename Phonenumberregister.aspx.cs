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
    public partial class Phonenumberregister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "update Login1 set phn_number=@phone where Username=@user";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@phone", TextBox1.Text);
            com.Parameters.AddWithValue("@user", TextBox2.Text);
            com.ExecuteNonQuery();
            Response.Redirect("Emailauthenticationregistration.aspx");
            conn.Close();
        }
    }
}