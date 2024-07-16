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
            //var test = OpenFoodApiService.GetFoodTypeByBarcode(1);
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);

            App.Current.MainPage = new NavigationPage(new BarCodeReaderPage());
            
        }

        private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
        {
            //Dispatcher wird benötigt, dass das ganze auf dem MainThread ausgeührt wird. GUI Änderungen müssen immer auf dem Main Thread passieren, sonst kommt es zu einem Crash
            Dispatcher.Dispatch(() =>
            {
                barcodeResult.Text = e.Results[0].Value;
            });
            
        }
    }

}
