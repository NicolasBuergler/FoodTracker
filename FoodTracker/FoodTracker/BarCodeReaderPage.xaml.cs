using ZXing.Net.Maui;
using FoodTracker.Service;

namespace FoodTracker;

public partial class BarCodeReaderPage : ContentPage
{
    public BarCodeReaderPage()
    {
        InitializeComponent();
    }

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        //Dispatcher wird ben�tigt, dass das ganze auf dem MainThread ausgef�hrt wird. GUI �nderungen m�ssen immer auf dem Main Thread passieren, sonst kommt es zu einem Crash
        Dispatcher.Dispatch(() =>
        {
            var barcodeResult = e.Results[0].Value;
            DataBaseService.AddFood(barcodeResult);
        });
    }
}