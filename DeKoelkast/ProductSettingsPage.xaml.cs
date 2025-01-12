using DeKoelkast.MVVM.Models;

namespace DeKoelkast;

public partial class ProductSettingsPage : ContentPage
{
    private readonly Users _currentUser;
    private readonly Products _product;

    public ProductSettingsPage(Users currentUser, Products product)
    {
        InitializeComponent();
        _currentUser = currentUser;
        _product = product;
    }

    private void BackToMainPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProductPage(_product, _currentUser));
    }
}