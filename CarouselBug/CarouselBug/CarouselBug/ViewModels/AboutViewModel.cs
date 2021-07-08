using System.Collections.ObjectModel;
using CarouselBug.Views;
using Xamarin.Forms;

namespace CarouselBug.ViewModels {
    public class AboutViewModel {
        public AboutViewModel() {
            ItemsView = new ObservableCollection<ContentView> {
                new View1(),
                new View1(),
                new View1(),
            };
        }

        public void UpdateContent() {
            ItemsView[0] = new View1();
        }

        public ObservableCollection<ContentView> ItemsView { get; }
    }
}