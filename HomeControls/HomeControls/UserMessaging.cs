using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeControls
{
    public class UserMessagingBase: System.Web.UI.Page
    {
        private string user_message;
        private string user_header;
        private string user_subtitle;

        public String UserMessage
        {
            get { return user_message; }
            set { user_message = value; }
        }

        public String UserHeader
        {
            get { return user_header; }
            set { user_header = value; }
        }

        public String UserSubTitle
        {
            get { return user_subtitle; }
            set { user_subtitle = value; }
        }
        
       
        public void DisplayUserMessage(string header, string subtitle, string message)
        {
            Session["userheader"] = header;
            Session["usersubtitle"] = subtitle;
            Session["usermessage"] = message;
            Response.Redirect("Message4U.aspx");
        }

        public void ClearUserMessage()
        {
            Session["userheader"] = "";
            Session["usersubtitle"] = "";
            Session["usermessage"] = "";
        }

        //lblMessage.Text = Session["usermsg"].ToString();
        //lblHeader.Text = Session["userheader"].ToString();
        //lblSubtitle.Text = Session["usersubtitle"].ToString();
    }
}