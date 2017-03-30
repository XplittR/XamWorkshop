using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using PropertyChanged;
using Xamarin.Forms;
using XamWorkshop.Models;
using XamWorkshop.Services;
using XamWorkshop.Views;

namespace XamWorkshop.ViewModels {
    [ImplementPropertyChanged]
    public class MoviesViewModel  {
        private INavigation _navigation;
        public MoviesViewModel(INavigation navigation) {
            _navigation = navigation;
            Films = new List<Movie>();
            GetFilms();
        }
        
        public IList<Movie> Films { get; set; }

        public Movie SelectedFilm {
            set {
                if (value != null) {
                    var viewModel = new FilmViewModel(){Film = value,};
                    var page = new FilmPage(viewModel);
                    _navigation.PushAsync(page);
                }
            }
        }

        private async void GetFilms() {
            var swapi = new SwapiService();
            MoviesResponse result = await swapi.GetFilms();
            if (result != null)
                Films = result.Results.ToList();

        }

        /*public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/
    }
}