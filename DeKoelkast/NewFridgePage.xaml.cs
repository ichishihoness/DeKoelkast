using DeKoelkast.MVVM.Models;

namespace DeKoelkast;

public partial class NewFridgePage : ContentPage
{
    private Users _currentUser;

    public NewFridgePage(Users currentUser)
    {
        InitializeComponent();
        _currentUser = currentUser;
    }

    private void CancelAddFridge_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FridgesPage(_currentUser));
    }
}
