using System;
using System.Threading.Tasks;
using TheChuck.Models;

namespace TheChuck.Services
{
    public interface IAPIService
    {
        Task<ChuckData> GetDataAsync(string uri);
    }
}
