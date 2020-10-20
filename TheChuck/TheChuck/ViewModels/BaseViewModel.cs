using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using TheChuck.Services;


namespace TheChuck.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IAPIService APIService { get; set; }
        public INavigationService NavigationService { get; set; }

        public BaseViewModel()
        {
            APIService = DependencyService.Get<IAPIService>();
            NavigationService = DependencyService.Get<INavigationService>();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
