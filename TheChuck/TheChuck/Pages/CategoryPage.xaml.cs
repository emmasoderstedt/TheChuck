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
        //CategoryViewModel viewModel;
        APIService _APIService;

        
        public CategoryPage()
        {
            InitializeComponent();
            //BindingContext = viewModel = new CategoryViewModel();
            _APIService = new APIService();


            //CategoryView.ItemsSource = ChuckCategories;

            //ChuckCategories.Add("Animal");
            //ChuckCategories.Add("Fashion");
            //ChuckCategories.Add("Food");

        }


        async void GetCategoriesButton_Clicked(System.Object sender, System.EventArgs e)
        {
            ChuckData chuckData = await _APIService.GetDataAsync(Constants.AllCategoriesEndpoint);
            BindingContext = chuckData;
        }

        async void SearchButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }

        async void JokeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new JokePage());
        }
    }
}
