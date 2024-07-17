using FoodTracker.Service;
using ZXing.Net.Maui.Controls;

namespace FoodTracker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new BarCodeReaderPage());
            
        }

        private void FoodHistoryBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new FoodHistoryPage());
            
        }
    }

}
