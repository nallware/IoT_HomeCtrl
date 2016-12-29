﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeControls
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var firstname = Session["firstname"];
            if (firstname != null)
            {
                lblUser.Text = "Hello, "+Session["firstname"].ToString();
            }
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("KatLogin.aspx");
        }
    }
}
