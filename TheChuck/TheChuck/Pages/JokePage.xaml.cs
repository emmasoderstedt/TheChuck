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
        APIService _APIService;


        public JokePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new JokeViewModel();
            _APIService = new APIService();


        }
    }
}
