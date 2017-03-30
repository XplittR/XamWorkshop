using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using XamWorkshop.Models;
using XamWorkshop.Services;

namespace XamWorkshop.ViewModels {
    public class MoviesViewModel : INotifyPropertyChanged {
        public MoviesViewModel() {
            Films = new List<Movie>();
            GetFilms();
        }

        //private INavigation _navigation;
        private IList<Movie> _films;
        public IList<Movie> Films {
            get { return _films; }
            set {
                if (_films != value) {
                    _films = value;
                    OnPropertyChanged();
                }
            }
        }

        private async void GetFilms() {
            var swapi = new SwapiService();
            MoviesResponse result = await swapi.GetFilms();
            if (result != null)
                Films = result.Results.ToList();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}