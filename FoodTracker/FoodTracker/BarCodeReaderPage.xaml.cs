using ZXing.Net.Maui;
using FoodTracker.Service;
using FoodTracker.Models;

namespace FoodTracker;

public partial class BarCodeReaderPage : ContentPage
{
    public BarCodeReaderPage()
    {
        InitializeComponent();
    }

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        barcodeReader.IsDetecting = false;
        //Dispatcher wird benötigt, dass das ganze auf dem MainThread ausgeführt wird. GUI Änderungen müssen immer auf dem Main Thread passieren, sonst kommt es zu einem Crash
        Dispatcher.Dispatch(() =>
        {
            var barcodeResult = e.Results[0].Value;
            AddFood(barcodeResult);

        });
    }

    private async void AddFood(string barcodeResult)
    {
        var detailSite = new FoodDetailView(new Food());
        App.Current.MainPage = new NavigationPage(detailSite);
        var food = await DataBaseService.AddFood(barcodeResult);
        detailSite.SetBindingContext(food);
    }

    private void HomeBtn_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new MainPage());
    }
}