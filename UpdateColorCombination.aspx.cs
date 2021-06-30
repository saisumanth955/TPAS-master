using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace TPAS
{
    public partial class UpdateColorCombination : System.Web.UI.Page
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

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int GenerateRandomNo()
            {
                int min = 0000;
                int max = 9999;
                Random rdm = new Random();
                return rdm.Next(min, max);
            }
            TextBox3.Text += GenerateRandomNo();
            
        }

        protected void colorcombrst_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "UPDATE Login1 SET colorsequence = @colorsequence WHERE Username = '" + clrusrname.Text + "'";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            string sha256 = ComputeSha256Hash(TextBox1.Text);
            com.Parameters.AddWithValue("@colorsequence", sha256);
            com.ExecuteNonQuery();
            Response.Write("Successfully Updated your Color Combination");
            conn.Close();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("vsumanthsai549@gmail.com");
            mail.To.Add(TextBox2.Text);
            mail.Subject = "Your Color Combination";
            mail.Body = "Mr '" + clrusrname.Text + "' Updated Color Combination is: '" + TextBox3.Text + "'";
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("vsumanthsai549@gmail.com", "Sumanth@gmail");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int GenerateRandomNo()
            {
                int min = 0000;
                int max = 9999;
                Random rdm = new Random();
                return rdm.Next(min, max);
            }
            TextBox3.Text += GenerateRandomNo();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int GenerateRandomNo()
            {
                int min = 0000;
                int max = 9999;
                Random rdm = new Random();
                return rdm.Next(min, max);
            }
            TextBox3.Text += GenerateRandomNo();
            
        }
    }
}