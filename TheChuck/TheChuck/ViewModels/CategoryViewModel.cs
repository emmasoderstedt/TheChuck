using System;
using TheChuck.Services;
using TheChuck.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace TheChuck.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        //public ICommand GetCategoriesCommand { get; }
        //public ObservableCollection<ChuckData> Categories { get; set; } = new ObservableCollection<ChuckData>();



        public CategoryViewModel()
        {
           // GetCategoriesCommand = new Command(async () => await APIService.GetDataAsync(Constants.AllCategoriesEndpoint));
        }

    }
}
