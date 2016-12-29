using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeControls
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStatus.Text = LightStatus();
        }

        protected void btnLightOn_Click(object sender, EventArgs e)
        {
            if (tbPasscode.Text == "5440")
            {
                lblStatus.Text = LightSwitch("on");
                lblStatus.Text = LightStatus();
            }
        }

        protected void btnLightOff_Click(object sender, EventArgs e)
        {
            if (tbPasscode.Text == "5440")
            {
                lblStatus.Text = LightSwitch("off");
                lblStatus.Text = LightStatus();
            }
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            if (tbPasscode.Text == "5440")
            {
                lblStatus.Text = TestSwitch(tbBlinks.Text);
                lblStatus.Text = LightStatus();
            }
        }

        public string LightSwitch(string command)
        {
            string result;
            using (WebClient client = new WebClient())
            {

                byte[] response = client.UploadValues("https://api.spark.io/v1/devices/3f0023000347353138383138/bmtLt/", new NameValueCollection()
                {
                    { "access_token", "9e2f1eb662521f4e62ec31452d16c851bf42b989" },
                    { "parms", command }
                });

                result = System.Text.Encoding.UTF8.GetString(response);
                return result;                
            }

        }

        public string TestSwitch(string blinks)
        {
            string result;
            using (WebClient client = new WebClient())
            {

                byte[] response = client.UploadValues("https://api.spark.io/v1/devices/3f0023000347353138383138/tstLt/", new NameValueCollection()
                {
                    { "access_token", "9e2f1eb662521f4e62ec31452d16c851bf42b989" },
                    { "parms", blinks }
                });

                result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }

        }


        public string LightStatus()
        {
            string result;
            string ret;
            using (WebClient client = new WebClient())
            {   
                result = client.DownloadString("https://api.spark.io/v1/devices/3f0023000347353138383138/readLt\\?access_token=9e2f1eb662521f4e62ec31452d16c851bf42b989");
            }

            //"result": -1

            if (result.Contains("\"result\": 1"))
            {
                ret = "Light Status: ON.";
            }
            else
            {
                ret = "Light Status: OFF.";
            }

            return ret;

        }
        

        protected void btnCheckLight_Click(object sender, EventArgs e)
        {
            lblStatus.Text = LightStatus();
        }
    }
}
