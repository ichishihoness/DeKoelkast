using DeKoelkast.MVVM.Views;

namespace DeKoelkast;

public partial class ProductPage : ContentPage
{
    private MVVM.Models.Products _product;

    public ProductPage(MVVM.Models.Products product)
    {
        InitializeComponent();
        _product = product;
        BindingContext = _product;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (Changeiconlabel != null)
        {
            Console.WriteLine($"Changeiconlabel.Text: {Changeiconlabel.Text}"); // Debug statement

            if (Changeiconlabel.Text == "greybottleicon.png")
            {
                ProductIcon.Source = "bottleicon.png";
            }
            else
            {
                ProductIcon.Source = "canicon.png";
            }
        }
        else
        {
            ProductIcon.Source = "settingsicon.png";
        }
    }

    private void BackToMainPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void ProductSettingsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProductSettingsPage());
    }
}

