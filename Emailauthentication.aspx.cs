using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPAS
{
    public partial class Emailauthentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "SELECT * FROM Login1 WHERE Username=@username and email=@email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                SqlDataReader sda = cmd.ExecuteReader();
                if (sda.Read() == true)
                {
                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    Response.Redirect("Unauthorizedpage.aspx");
                }
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}