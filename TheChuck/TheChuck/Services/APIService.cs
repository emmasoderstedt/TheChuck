using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TheChuck.Models;

namespace TheChuck.Services
{
    public class APIService : IAPIService
    {
        HttpClient _client;

        public APIService()
        {
            _client = new HttpClient();
        }

        public async Task<SearchReslut> SearchJoke(string search)
        {
            var data = await GetDataAsync(Constants.SearchEndpoint + search);
            return JsonConvert.DeserializeObject<SearchReslut>(data);
        }

        public async Task<Joke> GetJoke(string category)
        {
            var data = await GetDataAsync(Constants.JokeEndpoint + category);
            return JsonConvert.DeserializeObject<Joke>(data);
        }

        public async Task<string[]> GetCategories()
        {
            var data = await GetDataAsync(Constants.AllCategoriesEndpoint);
            return JsonConvert.DeserializeObject<string[]>(data);
        }

        public async Task<string> GetDataAsync(string uri)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                    
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return "";

        }


    }
}
