using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace GeziRehberiWEB1
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            string resetCode = txtResetCode.Text;
            string newPassword = txtNewPassword.Text;

            if (Session["ResetCode"] != null && Session["Email"] != null)
            {
                if (resetCode == Session["ResetCode"].ToString())
                {
                    string email = Session["Email"].ToString();

                    string connString = ConfigurationManager.ConnectionStrings["UserDatabaseConnectionString"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string query = "UPDATE Kullanicilar SET Password=@Password WHERE Email=@Email";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@Email", email);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            lblMessage.Text = "Şifre başarıyla sıfırlandı!";
                            Response.Redirect("Login.aspx");
                        }
                        catch (Exception ex)
                        {
                            lblMessage.Text = "Hata: " + ex.Message;
                        }
                    }
                }
                else
                {
                    lblMessage.Text = "Geçersiz sıfırlama kodu.";
                }
            }
            else
            {
                lblMessage.Text = "Oturum süresi doldu. Lütfen tekrar deneyin.";
            }
        }
    }
}