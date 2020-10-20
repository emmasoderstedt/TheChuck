﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using TheChuck.Services;


namespace TheChuck.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public APIService APIService { get; set; }

        public BaseViewModel()
        {
            APIService = DependencyService.Get<APIService>();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
