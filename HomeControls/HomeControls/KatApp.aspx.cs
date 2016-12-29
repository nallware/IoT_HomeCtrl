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
    public partial class KatApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"].ToString() == "" || Session["username"] == null || Session["username"].ToString() == string.Empty)
                {
                    Response.Redirect("KatLogin.aspx");
                }
                else
                {
                    if (!IsPostBack)
                    {
                        fillDropDownList();
                    }
                }
            }
            catch
            {
                Response.Redirect("KatLogin.aspx");
            }
        }

      



        public void fillDropDownList()
        {
            string query = "SELECT site_name FROM KatKeep_Sites WHERE user_id = @userid ORDER BY site_name";
            List<String> columnData = new List<String>();
            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {                    
                    try
                    {
                        sqlCon.Open();
                        cmd.Parameters.AddWithValue("@userid", Session["userid"]);
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
                    ddlSites.Items.Clear();
                    ddlSites.Items.Add("-SELECT-");
                    foreach(string site in columnData)
                    {
                        ddlSites.Items.Add(site);
                    }

                }
            }
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KatKeep_Sites WHERE site_name = @sitename AND user_id = @userid";
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    try
                    {
                        sqlCon.Open();
                        cmd.Parameters.AddWithValue("@sitename", ddlSites.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@userid", Session["userid"]);
                        using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                        {
                            a.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        lblNotes.Text = "SITE NOT FOUND!";
                    }
                    NallCrypt nc = new NallCrypt();
                    foreach (DataRow row in dt.Rows)
                    {
                        lblSiteName.Text = row[1].ToString();
                        hlSiteUrl.NavigateUrl = row[2].ToString();                        
                        hlSiteUrl.Text = row[2].ToString();
                        lblUsername.Text = row[3].ToString();
                        lblPassword.Text = nc.Decrypt(row[4].ToString());
                        lblNotes.Text = row[5].ToString();
                    }

                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO KatKeep_Sites (site_name, site_url, site_uname, site_pword, site_notes, user_id) VALUES (@site, @url, @username, @password, @notes, @userid)";
            List<String> columnData = new List<String>();

            string url = tbNewSiteUrl.Text;
            string htext = url.Substring(0, 7);
            if (htext != "http://")
            {
                url = "http://" + url;
            }
            using (SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KatKeep"].ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    try
                    {
                        NallCrypt nc = new NallCrypt();
                        sqlCon.Open();
                        cmd.Parameters.AddWithValue("@site", tbNewSiteName.Text);
                        cmd.Parameters.AddWithValue("@url", url);
                        cmd.Parameters.AddWithValue("@username", tbNewSiteUsername.Text);
                        cmd.Parameters.AddWithValue("@password", nc.Encrypt(tbNewSitePassword.Text));
                        cmd.Parameters.AddWithValue("@notes", tbNewSiteNotes.Text);
                        cmd.Parameters.AddWithValue("@userid", Session["userid"]);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                    }

                    tbNewSiteName.Text = string.Empty;
                    tbNewSiteNotes.Text = string.Empty;
                    tbNewSitePassword.Text = string.Empty;
                    tbNewSiteUrl.Text = string.Empty;
                    tbNewSiteUsername.Text = string.Empty;
                    fillDropDownList();
                }
            }
        }
    }
}