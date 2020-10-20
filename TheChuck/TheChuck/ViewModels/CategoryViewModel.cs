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
        APIService _APIService;

        public ICommand ListCategories => new Command(GetAllCategories);

        public ObservableCollection<string> Categories { get; set; }
        public string[] _categories { get; set; }

        public string CategoryName { get; set; }
        public string SelectedCategory { get; set; }

        public CategoryViewModel()
        {
            _APIService = new APIService();
            Categories = new ObservableCollection<string>();
        }

        async public void GetAllCategories()
        {
            _categories = await _APIService.GetCategories();
            foreach (string category in _categories)
            {
                Categories.Add(category);
            }
        }

    }
}
