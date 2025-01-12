namespace DeKoelkast;
using DeKoelkast.MVVM.Models;

public partial class SettingsPage : ContentPage
{
    private readonly Users _currentUser;

    public SettingsPage(Users currentUser)
    {
        InitializeComponent();
        _currentUser = currentUser;
    }

    private void BackToMainPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MVVM.Views.MainPage(_currentUser));
    }
}
