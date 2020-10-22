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
        
        public CategoryPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CategoryViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.GetAllCategories();
        }

        async void SearchButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }

        void Categories_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var category = e.Item as string;
            
            viewModel.GoToCategory(category);
        }
    }
}
