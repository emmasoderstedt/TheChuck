using System;
using TheChuck.Services;
using TheChuck.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace TheChuck.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        APIService _APIService;

        public ICommand SearchCommand => new Command(SearchJoke);

        public string SearchInput { get; set; }
        public SearchReslut _searchReslut = new SearchReslut();
        public ObservableCollection<Joke> Jokes { get; set; }


        public SearchViewModel()
        {
            _APIService = new APIService();
            Jokes = new ObservableCollection<Joke>();       
        }

        async public void SearchJoke()
        {
            _searchReslut = await _APIService.SearchJoke(SearchInput);
            foreach (Joke joke in _searchReslut.result)
            {
                Jokes.Add(joke);
            }


        }
    }
}
