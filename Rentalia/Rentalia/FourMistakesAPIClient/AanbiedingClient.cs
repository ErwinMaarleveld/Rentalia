using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rentalia.Data;
using System.Net.Http.Headers;

namespace Rentalia.FourMistakesAPIClient
{
    class AanbiedingClient
    {
        private readonly HttpClient Client;

        private readonly string Url;

        public AanbiedingClient()
        {
            Url = "http://192.168.56.102:80/api/aanbieding/";
            Client = new HttpClient { BaseAddress = new Uri(Url) };
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Aanbieding> Get()
        {
            string content = Client.GetStringAsync(Url).Result;
            JArray json = JArray.Parse(content);
            return json.ToObject<List<Aanbieding>>();
        }

        public Aanbieding Get(string code)
        {
            string content = Client.GetStringAsync(Url + $"/{code}").Result;
            JObject json = JObject.Parse(content);
            return json.ToObject<Aanbieding>();
        }

        public void Post(Aanbieding aanbieding)
        {
            string json = JsonConvert.SerializeObject(aanbieding);
            var response = Client.PostAsync(Url, new StringContent(json)).Result;
        }
    }
}
