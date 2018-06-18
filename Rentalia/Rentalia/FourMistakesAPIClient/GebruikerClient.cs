using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Rentalia.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace Rentalia.FourMistakesAPIClient
{
    class GebruikerClient
    {
        private readonly HttpClient Client;

        private readonly string Url;

        public GebruikerClient()
        {
            Url = "http://192.168.56.102:80/api/gebruiker/";
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public Gebruiker Get(string code)
        {
            string content = Client.GetStringAsync(Url + $"/{code}").Result;
            JObject json = JObject.Parse(content);
            return json.ToObject<Gebruiker>();
        }
    }
}
