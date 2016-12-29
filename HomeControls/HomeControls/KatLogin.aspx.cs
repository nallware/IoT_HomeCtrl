using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeControls
{
    public partial class KatLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckLogin(tbUsername.Text, tbPassword.Text))
            {
                if(Session["username"].ToString()=="admin")
                {
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    Response.Redirect("KatApp.aspx");
                }                
            }
        }






        public bool CheckLogin(string username, string password)
        {
            NallCrypt nc = new NallCrypt();
            string name = "";
            string query = "SELECT * FROM KatKeep_Login WHERE uname=@name AND pword=@pass";

            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {
                
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@pass", nc.Encrypt(password));
                    try
                    {
                        sqlCon.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        {
                            foreach(DataRow row in dt.Rows)
                            {
                                Session["userid"] = row[0].ToString();
                                Session["username"] = row[1].ToString();
                                Session["useremail"] = row[3].ToString();
                                Session["firstname"] = row[4].ToString();
                                Session["lastname"] = row[5].ToString();

                            }

                            if (Session["userid"].ToString() != "")
                            {


                                lblMessage.Text = "User " + Session["firstname"] + " logged in.";
                                return true;
                            }
                            else
                            {
                                lblMessage.Text = "User " + username + " not found.";
                                Session["username"] = "";
                                return false;
                            }
                        }

                            
                    }
                    catch (Exception ex)
                    {
                        lblMessage.Text = "User " + username + " not found.";
                        Session["username"] = "";
                        return false;
                    }   
                }
            }
        }







    }
}