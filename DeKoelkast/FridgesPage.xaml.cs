using DeKoelkast.MVVM.Models;


namespace DeKoelkast;

public partial class FridgesPage : ContentPage
{
    private Users _currentUser;

    public FridgesPage(Users currentUser)
    {
        InitializeComponent();
        _currentUser = currentUser;

    }

    private void BackToLoginButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }

    private void FridgeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MVVM.Views.MainPage(_currentUser));
    }

    private void AddFridgeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewFridgePage(_currentUser));
    }

    /*private void QRLezer_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        var first = e.Results?.FirstOrDefault();

        Dispatcher.DispatchAsync(async () =>
        {
            await DisplayAlert("Barcode", first.Value, "OK");
        });
    }*/
}
