using System;
using TheChuck.Services;
using TheChuck.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using TheChuck.Pages;
using System.Threading.Tasks;

namespace TheChuck.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public ObservableCollection<string> Categories { get; set; }

        public string CategoryName { get; set; }


        public CategoryViewModel()
        { 
            Categories = new ObservableCollection<string>();
        }

        public async Task GetAllCategories()
        {
            var categories = await APIService.GetCategories();
            foreach (string category in categories)
            {
                Categories.Add(category);
            }
        }

        async public void GoToCategory(string category)
        {
            await NavigationService.GoToCategory(category);
        }

    }
}
