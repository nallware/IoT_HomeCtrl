using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeControls
{
    public partial class Error : UserMessagingBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Session["usermessage"].ToString();
            lblHeader.Text = Session["userheader"].ToString();
            lblSubtitle.Text = Session["usersubtitle"].ToString();
        }
    }
}