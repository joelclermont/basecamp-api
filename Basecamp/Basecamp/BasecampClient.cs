using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Http;
using System.Net;

namespace Basecamp
{
    public class BasecampClient
    {
        public string URL { get; set; }
        public string APIToken { get; set; }

        public BasecampClient(string url, string apiToken)
        {
            URL = url;
            APIToken = apiToken;
        }

        public string TestConnection()
        {
            HttpClient client = new HttpClient(URL);
            client.TransportSettings.Credentials = new NetworkCredential(APIToken, "");

            HttpResponseMessage msg = client.Get("account.xml");
            msg.EnsureStatusIsSuccessful();
            return msg.Content.ReadAsString();
        }
    }
}
