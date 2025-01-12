using CommunityToolkit.Maui.Views;
using DeKoelkast.MVVM.Views;
using Microsoft.Maui.Controls;
using DeKoelkast.MVVM.Models;
using DeKoelkast.Repositories;

namespace DeKoelkast;

public partial class ProductPage : ContentPage
{
    private readonly BaseRepository<Products> _productsRepository;
    private readonly BaseRepository<Users> _usersRepository;
    private MVVM.Models.Products _product;
    private readonly Users _currentUser;

    public ProductPage(MVVM.Models.Products product, Users currentUser)
    {
        InitializeComponent();
        _productsRepository = new BaseRepository<Products>();
        _usersRepository = new BaseRepository<Users>();
        _product = product;
        _currentUser = currentUser;
        BindingContext = _product;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (Changeiconlabel != null)
        {
            Console.WriteLine($"Changeiconlabel.Text: {Changeiconlabel.Text}"); 

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
        Navigation.PushAsync(new MainPage(_currentUser));
    }

    private void ProductSettingsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProductSettingsPage(_currentUser, _product));
    }


    private void ConsumeButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(_product.Amount, out int amount) && amount > 0)
        {
            if (decimal.TryParse(_product.Price, out decimal price))
            {
                _product.Amount = (amount - 1).ToString();
                _currentUser.Balance -= price;
                _productsRepository.SaveEntity(_product);
                _usersRepository.SaveEntity(_currentUser);
                AmountLabel.Text = $"Aantal = {_product.Amount}";
            }
            else
            {
                _product.Amount = (amount - 1).ToString();
                _currentUser.Balance -= price;
                _productsRepository.SaveEntity(_product);
                _usersRepository.SaveEntity(_currentUser);
                AmountLabel.Text = $"Aantal = {_product.Amount}";
            }
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
            if (decimal.TryParse(_product.Price, out decimal price))
            {
                _product.Amount = (amount + 1).ToString();
                _currentUser.Balance += price;
                _productsRepository.SaveEntity(_product);
                _usersRepository.SaveEntity(_currentUser);
                AmountLabel.Text = $"Aantal = {_product.Amount}";
            }
            else
            {
                _product.Amount = (amount + 1).ToString();
                _currentUser.Balance += price;
                _productsRepository.SaveEntity(_product);
                _usersRepository.SaveEntity(_currentUser);
                AmountLabel.Text = $"Aantal = {_product.Amount}";
            }
        }
    }
}
