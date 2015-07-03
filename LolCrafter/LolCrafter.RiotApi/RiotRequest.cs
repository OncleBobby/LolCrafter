using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LolCrafter.RiotApi
{
    public class RiotRequest : IRiotRequest
    {
        #region Properties
        public string EndPoint { get; set; }
        public string ApiKey { get; set; }
        public string Region { get; set; }
        public string Version { get; set; }
        #endregion

        #region Public Methods
        public string Request(string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(GetRequestUriString(parameters));

            request.Method = "GET";
            request.ContentLength = 0;
            request.ContentType = "text/xml";
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException(
                        String.Format("Request failed. Received HTTP {0}", response.StatusCode));
                }

                // grab the response
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                }

                return responseValue;
            }
        }
        #endregion

        #region Private
        private string GetRequestUriString(string parameters)
        {
            return String.Format(
                        "{0}{1}/{2}/{3}?api_key={4}",
                        EndPoint,
                        Region,
                        Version,
                        parameters,
                        ApiKey
                        );
        }
        #endregion
    }
}
