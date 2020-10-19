using System;
namespace TheChuck.ViewModels
{
    public class JokeViewModel :BaseViewModel
    {
        public string Joke { get; set; } = "Det var en gång en tomat...";

        public JokeViewModel()
        {
        }
    }
}
