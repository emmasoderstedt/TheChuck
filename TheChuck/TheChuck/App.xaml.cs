using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TheChuck.Pages;
using TheChuck.Services;

namespace TheChuck
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RegisterService();
            MainPage = new NavigationPage(new CategoryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void RegisterService()
        {
            DependencyService.Register<IAPIService, APIService>();
            DependencyService.Register<INavigationService, NavigationService>();
        }
    }
}
