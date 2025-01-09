using CommunityToolkit.Maui.Views;
using DeKoelkast.MVVM.Views;
using Microsoft.Maui.Controls;
using DeKoelkast.MVVM.Models;
using DeKoelkast.Repositories;

namespace DeKoelkast;

public partial class ProductPage : ContentPage
{
    private readonly BaseRepository<Products> _productsRepository;
    private MVVM.Models.Products _product;

    public ProductPage(MVVM.Models.Products product)
    {
        InitializeComponent();
        _productsRepository = new BaseRepository<Products>();
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

    private void ConsumeButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(_product.Amount, out int amount) && amount > 0)
        {
            _product.Amount = (amount - 1).ToString();
            _productsRepository.SaveEntity(_product);
            AmountLabel.Text = $"Aantal = {_product.Amount}";
        }
        else     
        {
            AmountLabel.TextColor = Colors.Red;
        }
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(_product.Amount, out int amount))
        {
            _product.Amount = (amount + 1).ToString();
            _productsRepository.SaveEntity(_product);
            AmountLabel.Text = $"Aantal = {_product.Amount}";
        }
    }
}
