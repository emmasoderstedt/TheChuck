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
        public ICommand AddCategoryCommand => new Command(AddCategory);
        public ICommand RemoveCategoryCommand => new Command(RemoveCategory);

        public ObservableCollection<string> Categories { get; set; }
        public string CategoryName { get; set; }
        public string SelectedCategory { get; set; }

        public CategoryViewModel()
        {
            Categories = new ObservableCollection<string>();

            Categories.Add("Animal");
            Categories.Add("Fashion");
            Categories.Add("Food");
        }

        public void AddCategory()
        {
            Categories.Add(CategoryName);
        }

        public void RemoveCategory()
        {
            Categories.Remove(SelectedCategory);
        }

    }
}
