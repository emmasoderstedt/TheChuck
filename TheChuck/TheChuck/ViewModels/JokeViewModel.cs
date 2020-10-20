using System;
namespace TheChuck.ViewModels
{
    public class JokeViewModel :BaseViewModel
    {
        public string Joke { get; set; }
        public string Category { get; set; }

        public JokeViewModel(string category)
        {
            Category = category;
        }

        public async void GetJoke()
        {
            var joke = await APIService.GetJoke(Category);
            Joke = joke.Value;
            OnPropertyChanged(nameof(Joke));
        }
    }
}
