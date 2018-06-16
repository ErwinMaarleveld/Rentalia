using System;
using System.Collections.Generic;
using System.Text;
using Rentalia.Data;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Rentalia.FourMistakesAPIClient
{
    class AanbiedingClient
    {
        private readonly HttpWebRequest Request;

        private readonly string Url;

        public AanbiedingClient()
        {
            Url = "http://localhost:64838/api/aanbieding/";
            Request = WebRequest.CreateHttp(Url);
            Request.Accept = "application/json";
            Request.UserAgent = "Rentalia Xamarin app";
            Request.Timeout = 20 * 60 * 1000;
        }

        public void Get()
        {
            Request.Method = "GET";
            var response = Request.GetResponse();

            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }

            JArray json = JArray.Parse(content);
        }
    }
}
