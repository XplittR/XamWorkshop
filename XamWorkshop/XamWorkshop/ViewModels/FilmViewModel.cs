using System.ComponentModel;
using System.Runtime.CompilerServices;
using PropertyChanged;
using XamWorkshop.Models;

namespace XamWorkshop.ViewModels {
    [ImplementPropertyChanged]
    public class FilmViewModel {
        public Movie Film { get; set; }
    }
}
