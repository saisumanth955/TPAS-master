using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static TPAS.Rgstrcolorcomb;

namespace TPAS
{
    public partial class Phoneauthentication : System.Web.UI.Page
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
                string query = "SELECT * FROM Login1 WHERE Username=@username and phn_number=@phone";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", TextBox2.Text);
                cmd.Parameters.AddWithValue("@phone", TextBox1.Text);
                SqlDataReader sda = cmd.ExecuteReader();
                if (sda.Read() == true)
                {
                    Response.Redirect("Emailauthentication.aspx");
                    
                }
                else
                {
                    Response.Write("You are not an authorized user");

                }
                con.Close();
            }
        }
    }
}