using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamWorkshop.ViewModels;

namespace XamWorkshop.Views {
    
    public partial class MoviesPage : ContentPage {
        public MoviesPage() {
            InitializeComponent();
            BindingContext = new MoviesViewModel();
        }
    }
}
