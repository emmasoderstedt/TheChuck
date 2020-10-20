using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using TheChuck.Pages;


namespace TheChuck.Services
{
    public class NavigationService : INavigationService
    {
        private Page MainPage => Application.Current.MainPage;

        public async Task GoToCategory(string category)
        {
            await MainPage.Navigation.PushAsync(new JokePage(category));
        }
    }
}
