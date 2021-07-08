using System.Collections.ObjectModel;
using CarouselBug.Views;
using Xamarin.Forms;

namespace CarouselBug.ViewModels {
    public class AboutViewModel : BaseViewModel {
        public AboutViewModel() {
            ItemsView = new ObservableCollection<ContentView> {
                new View1(),
                new View1(),
                new View1(),
            };
        }

        public void UpdateContent() {
            ItemsView = new ObservableCollection<ContentView> {
                new View1(),
                new View1(),
                new View1(),
            };
        }

        private ObservableCollection<ContentView> _itemsView;
        public ObservableCollection<ContentView> ItemsView {
            get => _itemsView;
            set => SetProperty(ref _itemsView, value);
        }
    }
}