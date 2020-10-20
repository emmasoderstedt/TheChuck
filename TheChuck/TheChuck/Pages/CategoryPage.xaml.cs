using System;
using System.Collections.Generic;
using TheChuck.ViewModels;
using TheChuck.Services;
using TheChuck.Models;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TheChuck.Pages
{
    public partial class CategoryPage : ContentPage 
    {
        CategoryViewModel viewModel;
        APIService _APIService;

        
        public CategoryPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CategoryViewModel();
            _APIService = new APIService();

        }

        async void SearchButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }
    }
}
