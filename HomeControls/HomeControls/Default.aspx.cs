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
        ParticleIOTools io = new ParticleIOTools();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStatus.Text = LightStatus();
            lblGarage.Text = GarageStatus();
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
            //string result;
            //using (WebClient client = new WebClient())
            //{

            //    byte[] response = client.UploadValues("https://api.spark.io/v1/devices/3f0023000347353138383138/bmtLt/", new NameValueCollection()
            //    {
            //        { "access_token", "9e2f1eb662521f4e62ec31452d16c851bf42b989" },
            //        { "parms", command }
            //    });

            //    result = System.Text.Encoding.UTF8.GetString(response);
            //    //return result;                
            //}
            string id = "3f0023000347353138383138";
            string function = "bmtLt";
            string token = "9e2f1eb662521f4e62ec31452d16c851bf42b989";            
            return io.CallParticleFunction(id, function, token, command);


        }

        public string GarageButton()
        {
            //string result;
            //string command = "push";
            //using (WebClient client = new WebClient())
            //{

            //    byte[] response = client.UploadValues("https://api.spark.io/v1/devices/1e003b001747353236343033/nGarage/", new NameValueCollection()
            //    {
            //        { "access_token", "9e2f1eb662521f4e62ec31452d16c851bf42b989" },
            //        { "parms", command }
            //    });

            //    result = System.Text.Encoding.UTF8.GetString(response);
            //    return result;
            //}
            string id = "1e003b001747353236343033";
            string function = "nGarage";
            string token = "9e2f1eb662521f4e62ec31452d16c851bf42b989";
            string command = "push";
            return io.CallParticleFunction(id, function, token, command);

        }

        public string TestSwitch(string blinks)
        {
            //string result;
            //using (WebClient client = new WebClient())
            //{

            //    byte[] response = client.UploadValues("https://api.spark.io/v1/devices/3f0023000347353138383138/tstLt/", new NameValueCollection()
            //    {
            //        { "access_token", "9e2f1eb662521f4e62ec31452d16c851bf42b989" },
            //        { "parms", blinks }
            //    });

            //    result = System.Text.Encoding.UTF8.GetString(response);
            //    return result;
            //}
            string id = "3f0023000347353138383138";
            string function = "tstLt";
            string token = "9e2f1eb662521f4e62ec31452d16c851bf42b989";
            return io.CallParticleFunction(id, function, token, blinks);
        }

       
        public string LightStatus()
        {
            //string result;
            //string ret;
            //using (WebClient client = new WebClient())
            //{   
            //    result = client.DownloadString("https://api.spark.io/v1/devices/3f0023000347353138383138/readLt\\?access_token=9e2f1eb662521f4e62ec31452d16c851bf42b989");
            //}

            //"result": -1
            string id = "3f0023000347353138383138";
            string varb = "readLt";
            string token = "9e2f1eb662521f4e62ec31452d16c851bf42b989";
            string result = io.GetParticleVariableData(id, varb, token);
            return result.Contains("\"result\": 1") ? "Light Status: ON." : "Light Status: OFF.";            
            
        }


        public string GarageStatus()
        {
            //string result;
            //string ret;
            //using (WebClient client = new WebClient())
            //{
            //    result = client.DownloadString("https://api.spark.io/v1/devices/1e003b001747353236343033/magnt\\?access_token=9e2f1eb662521f4e62ec31452d16c851bf42b989");
            //}            
            //"result": -1
            string id = "1e003b001747353236343033";
            string varb = "magnt";
            string token = "9e2f1eb662521f4e62ec31452d16c851bf42b989";
            string result = io.GetParticleVariableData(id, varb, token);
            return result.Contains("OPEN") ? "Garage Status: OPEN." : "Garage Status: CLOSED.";
            
        }
        

        protected void btnCheckLight_Click(object sender, EventArgs e)
        {
            lblStatus.Text = LightStatus();
        }

        protected void btnGarage_Click(object sender, EventArgs e)
        {
            if (tbPasscode.Text == "5440")
            {
                lblGarage.Text = GarageButton();
                lblGarage.Text = GarageStatus();
            }
        }
    }
}
