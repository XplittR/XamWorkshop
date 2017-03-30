using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamWorkshop.ViewModels;

namespace XamWorkshop.Views {
    public partial class FilmPage : ContentPage {
        public FilmPage() {
            InitializeComponent();
        }

        public FilmPage(FilmViewModel viewModel)
            : this() {
            BindingContext = viewModel;
        }
    }
}
