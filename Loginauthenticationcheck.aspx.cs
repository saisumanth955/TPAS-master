using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace TPAS
{
    public partial class Loginauthenticationcheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
            con.Open();

            if (CheckBoxList1.Text == "")
            {
                Response.Write("Please Check the authentication option");
            }
            else
            {
                string query = "SELECT * FROM Login1 where frstauthoption=@frstauthoption and Username=@username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@frstauthoption", CheckBoxList1.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    Response.Redirect("LoginColorCombinationCheck.aspx");
                    Response.Write("u verified your first auth option");
                    rd.Close();
                }
                else
                {
                    Response.Redirect("" + CheckBoxList1.Text + ".aspx");
                }
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
            con.Open();

            if (CheckBoxList1.Text == "")
            {
                Response.Write("Please check second authentication option");
            }
            else
            {
                string query = "SELECT * FROM Login1 where scndauthoption=@scndauthoption and Username=@username ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@scndauthoption", CheckBoxList1.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    Response.Write("u verified your second auth option");
                    rd.Close();
                }
                else
                {
                    Response.Redirect("" + CheckBoxList1.Text + ".aspx");
                }
                con.Close();
            }
        }
    }
}