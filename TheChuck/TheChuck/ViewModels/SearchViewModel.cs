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

        public ICommand SearchCommand => new Command(SearchJoke);

        public string SearchInput { get; set; }
        public SearchReslut _searchReslut = new SearchReslut();
        public ObservableCollection<Joke> Jokes { get; set; }


        public SearchViewModel()
        {
            Jokes = new ObservableCollection<Joke>();       
        }

        async public void SearchJoke()
        {
            Jokes.Clear();
            _searchReslut = await APIService.SearchJoke(SearchInput);
            foreach (Joke joke in _searchReslut.result)
            {
                Jokes.Add(joke);
            }

        }
    }
}
