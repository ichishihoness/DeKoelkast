using DeKoelkast.MVVM.Models; // Add this using directive

namespace DeKoelkast;

public partial class FridgesPage : ContentPage
{
    private Users _currentUser;

    public FridgesPage(Users currentUser)
    {
        InitializeComponent();
        _currentUser = currentUser;
    }

    private void JoinFridgeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MVVM.Views.MainPage(_currentUser));
    }

    private void BackToLoginButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
}
