using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPAS
{
    public partial class Register : System.Web.UI.Page
    {
        private int GetPasswordStrength(string password)
        {
            int Marks = 0;
            // here we will check password strength
            if (password.Length < 6)
            {
                // Very Week
                return 1;
            }
            else
            {
                Marks = 1;
            }
            if (Regex.IsMatch(password, "[a-z]"))
            {
                // 2    week
                Marks++;
            }
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                // 3    medium
                Marks++;
            }
            if (Regex.IsMatch(password, "[0-9]"))
            {
                //4     strong
                Marks++;
            }
            if (Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},?,:,;,|,',\\,.,/,~,`,-,=]"))
            {
                //5     very strong
                Marks++;
            }
            return Marks;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }
        public bool IsReCaptchValid()
        {
            var result = false;
            var captchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = ConfigurationManager.AppSettings["SecretKey"];
            var apiUrl = "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}";
            var requestUri = string.Format(apiUrl, secretKey, captchaResponse);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    JObject jResponse = JObject.Parse(stream.ReadToEnd());
                    var isSuccess = jResponse.Value<bool>("success");
                    result = isSuccess;
                }
            }
            return result;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblMessage.InnerHtml = (IsReCaptchValid())
            ? "<span style='color:green'>Captcha verification success</span>"
            : "<span style='color:red'>Captcha verification failed</span>";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
            con.Open();
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox2.ForeColor==Color.Green)
            {

                try
                {
                    string query = "SELECT Username FROM Login1 where Username = @username";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        Response.Write("You have already Registered");
                        rd.Close();
                        con.Close();
                    }

                    else
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "insert into Login1 (Username, Password) values(@username, @password)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@username", TextBox1.Text);
                        com.Parameters.AddWithValue("@password", TextBox2.Text);
                        com.ExecuteNonQuery();
                        Response.Redirect("Registrationauthentication.aspx");
                        conn.Close();
                    }
                }

                catch (Exception ex)
                {
                    Response.Write("Error:" + ex.ToString());

                }   
            }
            else
            {
                Response.Write("Please check your password strength");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int marks = GetPasswordStrength(TextBox2.Text);
            if (marks < 4)
            {
                TextBox2.ForeColor = Color.Red;
                return;
            }
            TextBox2.ForeColor = Color.Green;
        }
    }
}