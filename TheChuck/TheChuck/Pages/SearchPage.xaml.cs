using System;
using System.Collections.Generic;
using TheChuck.ViewModels;
using Xamarin.Forms;

namespace TheChuck.Pages
{
    public partial class SearchPage : ContentPage
    {
        SearchViewModel viewModel;


        public SearchPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SearchViewModel();
        }
    }
}
