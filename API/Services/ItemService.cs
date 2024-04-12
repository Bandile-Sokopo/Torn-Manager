using System.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace API.Services
{
    public class ItemService:ISelector
    {
        private static HttpClient httpClient;
        private static string _apiKey;
        private static int _ID = 0;

        public HttpClient HttpClient
        {
            get { return httpClient; }
            set { }
        }

        public ItemService(string apiKey, int ID)
        {
            _apiKey = apiKey;
            _ID = ID;
            httpClient.BaseAddress = new Uri("https://api.torn.com/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public int IdSelect()
        {
            return _ID;
        }

        public string EndpointSelect()
        {
            return "torn";
        }

        public string ApiKeySelect()
        {
            return _apiKey;
        }

        public HttpClient Client()
        {
            return httpClient;
        }
    }
}
