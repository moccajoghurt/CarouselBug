using CarouselBug.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselBug.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage {
        AboutViewModel aboutViewModels;
        public AboutPage() {
            InitializeComponent();
            aboutViewModels = new AboutViewModel();
            BindingContext = aboutViewModels;
        }

        protected override void OnAppearing() {
            base.OnAppearing();
            aboutViewModels.UpdateContent();
        }
    }
}