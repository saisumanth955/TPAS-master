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
        int GenerateRandomNo()
        {
            int min = 0000;
            int max = 9999;
            Random rdm = new Random();
            return rdm.Next(min, max);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        protected void Button2_Click(object sender, EventArgs e)
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
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("vsumanthsai549@gmail.com");
                    mail.To.Add(TextBox2.Text);
                    mail.Subject = "Your OTP ";
                    
                    mail.Body = "Mr '" + TextBox1.Text + "' Your OTP is: '" + GenerateRandomNo() + "'";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("vsumanthsai549@gmail.com", "Sumanth@gmail");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    Response.Write("Successfully sent OTP");  
                }
                else
                {
                    Response.Write("You are not an authorized user");

                }
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GenerateRandomNo() == Convert.ToInt32(TextBox3.Text))
            {
                Response.Redirect("");
            }
            else
            {
                Response.Write("You haven't verified successfully");
            }
        }
    }
}