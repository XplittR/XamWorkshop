using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamWorkshop.ViewModels {
    public class MoviesViewModel : INotifyPropertyChanged {
        public MoviesViewModel() {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}