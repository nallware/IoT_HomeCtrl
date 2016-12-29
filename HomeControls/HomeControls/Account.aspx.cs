using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeControls
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"].ToString() == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("KatLogin.aspx");
            }

        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (CheckPass(tbOldPass.Text, Session["userid"].ToString()))
            {
                if(tbNewPass.Text == tbNewPassMatch.Text)
                {
                    if(!UpdatePassword(Session["userid"].ToString(), tbNewPass.Text))
                    {
                        Session["usermsg"] = "Your password could not be changed at this time.  Please contact the administrator at email: dev@nallware.com.  You should receive a response within 24-48 hours, if not immediately.";
                        Response.Redirect("Error.aspx");
                    }

                }
            }

        }

        protected void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (!UpdateEmail(Session["userid"].ToString(), tbEmail.Text))
            {
                Session["usermsg"] = "Your email could not be changed at this time.  Please contact the administrator at email: dev@nallware.com.  You should receive a response within 24-48 hours, if not immediately.";
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnChangeName_Click(object sender, EventArgs e)
        {
            if (!UpdateName(Session["userid"].ToString(), tbFirstName.Text, tbLastName.Text))
            {
                Session["usermsg"] = "Your name could not be changed at this time.  Please contact the administrator at email: dev@nallware.com.  You should receive a response within 24-48 hours, if not immediately.";
                Response.Redirect("Error.aspx");
            }
        }

        public bool CheckPass(string unencrypted_password, string userid)
        {
            NallCrypt nc = new NallCrypt();
            bool match = false;

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                string query = "SELECT pword from KatKeep_Login WHERE id=@userid";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);
                    try
                    {
                        sqlCon.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            if (nc.Decrypt(result.ToString()) == unencrypted_password)
                            {
                                match = true;
                            }
                            else
                            {
                                match = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        match = false;
                    }
                }
            }
            return match;
        }

        public bool UpdatePassword(string userid, string newpass)
        {
            NallCrypt nc = new NallCrypt();
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                string query = "UPDATE KatKeep_Login SET pword=@password WHERE id=@userid";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@password", nc.Encrypt(newpass));
                    try
                    {
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        success = false;
                    }
                }
            }
            return success;
        }


        public bool UpdateEmail(string userid, string email)
        {
            NallCrypt nc = new NallCrypt();
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                string query = "UPDATE KatKeep_Login SET email=@email WHERE id=@userid";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@email", nc.Encrypt(email));
                    try
                    {
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        success = false;
                    }
                }
            }
            return success;
        }


        public bool UpdateName(string userid, string firstname, string lastname)
        {
            NallCrypt nc = new NallCrypt();
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                string query = "UPDATE KatKeep_Login SET firstname=@firstname, lastname=@lastname WHERE id=@userid";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@firstname", nc.Encrypt(firstname));
                    cmd.Parameters.AddWithValue("@lastname", nc.Encrypt(lastname));
                    try
                    {
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        success = false;
                    }
                }
            }
            return success;
        }
    }
}