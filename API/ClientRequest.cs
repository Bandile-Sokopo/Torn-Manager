using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;

namespace API
{
    public class ClientRequest<T>
    {
        private static ISelector _select;
        ClientRequest(ISelector select)
        {
            _select = select;
        }

        public async Task<T> SelectAsync(string resourceID, string endpoint, string apiKey)
        {
            var client = _select.Client();
            var response = await client.GetAsync($"{_select.EndpointSelect()}?selections={_select.IdSelect()}&key={_select.ApiKeySelect()}");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<T>(responseString);

            return responseObject;
        }
    }
}
