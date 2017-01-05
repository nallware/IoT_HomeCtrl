using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;

namespace HomeControls
{
    public class ParticleIOTools
    {
        /// <summary>
        /// This method will trigger a particle.io function      
        /// https://docs.particle.io/reference/firmware/photon/#particle-function-
        /// </summary>
        /// <param name="device_id"></param>
        /// <param name="function_name"></param>
        /// <param name="access_token"></param>
        /// <param name="command_args"></param>
        /// <returns>
        /// response from server
        /// </returns>
        public string CallParticleFunction(string device_id, string function_name, string access_token, string command_args)
        {
            string result;
            using (WebClient client = new WebClient())
            {
                string upVals = string.Format("https://api.spark.io/v1/devices/{0}/{1}/", device_id, function_name);
                byte[] response = client.UploadValues(upVals, new NameValueCollection()
                {
                    { "access_token", access_token },
                    { "parms", command_args }
                });

                result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }

        }


        /// <summary>
        /// This method will return the data associated with a particle.io variable
        /// https://docs.particle.io/reference/firmware/photon/#particle-variable-
        /// </summary>
        /// <param name="device_id"></param>
        /// <param name="variable_name"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        public string GetParticleVariableData(string device_id, string variable_name, string access_token)
        {
            string result;
            using (WebClient client = new WebClient())
            {
                string dlString = string.Format("https://api.spark.io/v1/devices/{0}/{1}\\?access_token={2}", device_id, variable_name, access_token);
                result = client.DownloadString(dlString);
            }

            return result;
        }
    }
}