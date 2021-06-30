using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;
namespace TPAS
{
    public partial class Logincolorcombinationcheck : System.Web.UI.Page
    {
        static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            { 
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData)); 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
            conn.Open();
            string Query = "select * from Login1 where colorsequence =@colorsequence and Username=@username";
            SqlCommand cmd = new SqlCommand(Query, conn);
            string sha256 = ComputeSha256Hash(TextBox2.Text);
            cmd.Parameters.AddWithValue("@colorsequence", sha256);
            cmd.Parameters.AddWithValue("@username",TextBox3.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            //  If the record can be queried, it means passing verification, then open another form.  
            if (rd.HasRows)
            {
                Response.Redirect("Loginauthenticationcheck.aspx");
                conn.Close();
            }
            else
            {
                Response.Write("Please enter the color sequence which we have sent to your mail ID at the time of Registration");
                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Loginauthenticationcheck.aspx");
        }
    }
}