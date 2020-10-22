using System;
using System.Collections.Generic;
using TheChuck.ViewModels;
using TheChuck.Services;
using TheChuck.Models;
using Xamarin.Forms;

namespace TheChuck.Pages
{
    public partial class JokePage : ContentPage
    {
        JokeViewModel viewModel;

        public JokePage(string category)
        {
            InitializeComponent();
            BindingContext = viewModel = new JokeViewModel(category);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.GetJoke();
            
        }

        void OnImageButtonClicked(object sender, EventArgs e)
        {
            viewModel.UpdateIsFavorite();
        }
    }
}
