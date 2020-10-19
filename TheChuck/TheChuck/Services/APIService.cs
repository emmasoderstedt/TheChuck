using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TheChuck.Models;

namespace TheChuck.Services
{
    public class APIService :IAPIService
    {
        HttpClient _client;

        public APIService()
        {
            _client = new HttpClient();
        }

        public async Task<ChuckData> GetDataAsync(string uri)
        {
            ChuckData chuckData = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    chuckData = JsonConvert.DeserializeObject<ChuckData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return chuckData;
        }


    }
}
