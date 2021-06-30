using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;

namespace TPAS
{
    public partial class colorPage : System.Web.UI.Page
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=SUMANTH\SQLEXPRESS;Initial Catalog=munna;Integrated Security=True");
        //conn.Open();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SUMANTH\SQLEXPRESS;Initial Catalog=munna;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update Login1 set val='" + pwdrst.Text + "' where Username='"+ rstclrcombusrtxt.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void pwdrst_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int GenerateRandomNo()
            {
                int _min = 1000;
                int _max = 9999;
                Random _rdm = new Random();
                return _rdm.Next(_min, _max);
            }
            pwdrst.Text += GenerateRandomNo();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int GenerateRandomNo()
            {
                int _min = 1000;
                int _max = 9999;
                Random _rdm = new Random();
                return _rdm.Next(_min, _max);
            }
            pwdrst.Text += GenerateRandomNo();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int GenerateRandomNo()
            {
                int _min = 1000;
                int _max = 9999;
                Random _rdm = new Random();
                return _rdm.Next(_min, _max);
            }
            pwdrst.Text += GenerateRandomNo();
        }
    }
}