using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeControls
{
    public partial class Admin : UserMessagingBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] == null)
            {
                Response.Redirect("KatLogin.aspx");
            }
            else if (Session["username"].ToString() != "admin")
            {
                Response.Redirect("KatLogin.aspx");
            }
            else
            {
                if(!IsPostBack)
                fillDropDownList();
            }
            
        }

        protected void btnAddNewUser_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO KatKeep_Login (uname, pword, email, firstname, lastname) VALUES (@username, @password, @email, @firstname, @lastname)";

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                NallCrypt nc = new NallCrypt();

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    try
                    {
                        sqlCon.Open();
                        cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                        cmd.Parameters.AddWithValue("@password", nc.Encrypt(tbPassword.Text));
                        cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                        cmd.Parameters.AddWithValue("@firstname", tbFirstName.Text);
                        cmd.Parameters.AddWithValue("@lastname", tbLastName.Text);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                    }

                    tbUsername.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                    tbEmail.Text = string.Empty;
                    tbFirstName.Text = string.Empty;
                    tbLastName.Text = string.Empty;
                    fillDropDownList();
                }
            }
        }

        public void fillDropDownList()
        {
            string query = "SELECT uname FROM KatKeep_Login ORDER BY uname";
            List<String> columnData = new List<String>();
            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    try
                    {
                        sqlCon.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnData.Add(reader.GetString(0));
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    ddlResetUser.Items.Clear();
                    ddlResetUser.Items.Add("-SELECT-");
                    foreach (string site in columnData)
                    {
                        ddlResetUser.Items.Add(site);
                    }

                }
            }
        }


        public void resetPassword()
        {
            string query = "UPDATE KatKeep_Login SET pword=@pword where uname=@uname";
            string temppass = "";

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                NallCrypt nc = new NallCrypt();

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    Random r = new Random();
                    int num1 = r.Next(100, 500);
                    int num2 = r.Next(501, 999);

                    char[] ckr = "$%#@!*abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();

                    Random n = new Random();
                    temppass = ckr[n.Next(0, 59)].ToString() + ckr[n.Next(0, 59)] + ckr[n.Next(0, 59)] + num1 + ckr[n.Next(0, 59)] + ckr[n.Next(0, 59)] + ckr[n.Next(0, 59)] + num2;

                    try
                    {
                        sqlCon.Open();
                        cmd.Parameters.AddWithValue("@uname", ddlResetUser.Text);
                        cmd.Parameters.AddWithValue("@pword", nc.Encrypt(temppass));

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                    }

                    //send email to user
                    sendDeadlyEmail(ddlResetUser.SelectedValue.ToString(), temppass, getUserEmailAddress(ddlResetUser.Text));

                    tbUsername.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                    tbEmail.Text = string.Empty;
                    tbFirstName.Text = string.Empty;
                    tbLastName.Text = string.Empty;                    
                }
            }
        }





        public string getUserEmailAddress(string username)
        {
            string email = "nall.kelly@gmail.com";

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                string query = "SELECT email from KatKeep_Login WHERE uname=@uname";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@uname", username);
                    try
                    {
                        sqlCon.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            email = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return email;
        }

        public void sendDeadlyEmail(string username, string password, string email)
        {            
            var fromAddress = new MailAddress("gimli19670@gmail.com", "OnBehalf OfKatApp");
            var toAddress = new MailAddress(email, username);
            string fromPassword = "Bubba6969";
            string subject = "Password reset for KatApp";
            string body = username+", your password has been reset.  The current password is "+password+ ". You can log in with the new password here: http://www.nallweb.com/KatLogin.aspx";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }



        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            resetPassword();
        }

        protected void btnEncDec_Click(object sender, EventArgs e)
        {
            string plaintext;
            string encryptedtext;
            NallCrypt nc = new NallCrypt();

            if(tbEncrypted.Text != "") //encrypted to text
            {
                plaintext = nc.Decrypt(tbEncrypted.Text);
                if(plaintext == "")
                {
                    DisplayUserMessage("Error!", "An error has occurred...", "Text failed to decrypt.  Bad encryption string.");
                }
                else
                {
                    DisplayUserMessage("Information", "Your decrypted string", "The text was able to decrypt successfully.  The decrypted text is: <span style=\"color: red;\">" + plaintext+"</span>.");
                }
                                
            }
            else //text to encrypted
            {
                encryptedtext = nc.Encrypt(tbDecrypted.Text);
                DisplayUserMessage("Information", "Encryption", "The text was able to encrypt successfully.  The encrypted text is: <span style=\"color: red;\">" + encryptedtext+ "</span>.");
            }
        }
    }
     
}