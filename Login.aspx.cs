using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Configuration;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace TPAS
{
    public partial class Login : System.Web.UI.Page
    {
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
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            if (!this.IsPostBack)
            {
                Session["Reset"] = true;
                Configuration config = WebConfigurationManager.OpenWebConfiguration("~/Web.Config");
                SessionStateSection section = (SessionStateSection)config.GetSection("system.web/sessionState");
                int timeout = (int)section.Timeout.TotalMinutes * 50 * 25;
                ClientScript.RegisterStartupScript(this.GetType(), "SessionAlert", "SessionExpireAlert(" + timeout + ");", true);
            }
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }
        protected void sgnin_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text != "" && pwdtxt.Text != "")
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SumanthConnectionString"].ConnectionString);
                con.Open();
                string query = "SELECT * FROM Login1 WHERE Username=@username and Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", usernametxt.Text);
                cmd.Parameters.AddWithValue("@password", pwdtxt.Text);
                SqlDataReader sda = cmd.ExecuteReader();
                if (sda.Read() == true)
                {
                    Response.Redirect("Loginauthenticationcheck.aspx");
                    Response.Write("Login Success");
                }
                else
                {
                    Response.Write("Please check your username and password");

                }
                con.Close();
            } 
        }
        protected void sgnup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}