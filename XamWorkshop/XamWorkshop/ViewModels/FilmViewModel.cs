using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XamWorkshop.Models;

namespace XamWorkshop.ViewModels {
    public class FilmViewModel : INotifyPropertyChanged {
        private Movie _film;

        public Movie Film {
            get { return _film; }
            set {
                if (_film != value) {
                    _film = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
