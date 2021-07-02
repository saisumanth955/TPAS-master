using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TPAS
{
    public partial class Neededauth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (CheckBox1.Checked == true)
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set frstauthoption=@frstauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@frstauthoption", CheckBox1.Text);
                com.ExecuteNonQuery();
                Response.Redirect("Registercolorcombination.aspx");
            }
            else if (CheckBox2.Checked == true)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set frstauthoption=@frstauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@frstauthoption", CheckBox2.Text);
                com.ExecuteNonQuery();
                Response.Redirect("Phonenumberregister.aspx");
            }
            else if (CheckBox3.Checked == true)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set frstauthoption=@frstauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@frstauthoption", CheckBox3.Text);
                com.ExecuteNonQuery();
                // Response.Redirect("Facial.aspx");
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set frstauthoption=@frstauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@frstauthoption", CheckBox4.Text);
                com.ExecuteNonQuery();
                //Response.Redirect("Facial.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set scndauthoption=@scndauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@scndauthoption", CheckBox1.Text);
                com.ExecuteNonQuery();
                Response.Redirect("Registercolorcombination.aspx");
            }
            else if (CheckBox2.Checked == true)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set scndauthoption=@scndauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@scndauthoption", CheckBox2.Text);
                com.ExecuteNonQuery();
                Response.Redirect("Phoneauthenticationlogin.aspx");
            }
            else if (CheckBox3.Checked == true)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set scndauthoption=@scndauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@scndauthoption", CheckBox3.Text);
                com.ExecuteNonQuery();
                Response.Redirect("Facial.aspx");
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "update Login1 set scndauthoption=@scndauthoption where Username='" + TextBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@scndauthoption", CheckBox4.Text);
                com.ExecuteNonQuery();
                //Response.Redirect("Facial.aspx");
            }
        }
    }
}