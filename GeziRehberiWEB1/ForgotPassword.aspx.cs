using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Web.UI;
using System.Net;

namespace GeziRehberiWEB1
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            string connString = ConfigurationManager.ConnectionStrings["UserDatabaseConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT COUNT(1) FROM Kullanicilar WHERE Email=@Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        // Rastgele bir kod oluştur
                        string resetCode = Guid.NewGuid().ToString();
                        Session["ResetCode"] = resetCode;
                        Session["Email"] = email;

                        // Kodu e-posta ile gönder
                        bool emailSent = SendResetCodeEmail(email, resetCode);
                        if (emailSent)
                        {
                            lblMessage.Text = "Sıfırlama kodu e-posta adresinize gönderildi.";
                            Response.Redirect("ResetPassword.aspx");
                        }
                        else
                        {
                            lblMessage.Text = "E-posta gönderme sırasında bir hata oluştu. Lütfen daha sonra tekrar deneyin.";
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Bu e-posta kayıtlı değil.";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Hata: " + ex.Message;
                }
            }
        }

        private bool SendResetCodeEmail(string email, string resetCode)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress("karakar232@gmail.com");
                mail.Subject = "Şifre Sıfırlama Kodu";
                mail.Body = "Şifre sıfırlama kodunuz: " + resetCode;

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential("karakar232@gmail.com", "ytp sxhl zxud ytds"), // Uygulama şifresi kullanın
                    EnableSsl = true
                };

                smtp.Send(mail);
                return true;
            }
            catch (SmtpException smtpEx)
            {
                lblMessage.Text = "SMTP hatası: " + smtpEx.Message;
                return false;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Posta gönderme hatası: " + ex.Message;
                return false;
            }
        }
    }
}
