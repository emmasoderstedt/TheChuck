using System;
using TheChuck.Models;
using System.Threading.Tasks;

namespace TheChuck.Services
{
    public interface IAPIService
    {
        Task<SearchReslut> SearchJoke(string search);

        Task<string[]> GetCategories();

        Task<Joke> GetJoke(string category);

        Task<string> GetDataAsync(string uri);


    }
}
