using System;
using System.Threading.Tasks;

namespace TheChuck.Services
{
    public interface INavigationService
    {
        Task GoToCategory(string category);
    }
}
