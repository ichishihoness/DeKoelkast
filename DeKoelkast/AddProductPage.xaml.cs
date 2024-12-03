using Microsoft.Maui.Controls.Compatibility.Platform;
using Microsoft.Maui.Layouts;

namespace DeKoelkast;

public partial class AddProductPage : ContentPage
{
    private bool IsSelectedOrNot1 = false;
    private bool IsSelectedOrNot2 = false;
    private bool PriceSwichState = false;

    public AddProductPage()
    {
        InitializeComponent();
    }

    private void CancelAddProduct_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MVVM.Views.MainPage());
    }

    private void AddProduct_Clicked(object sender, EventArgs e)
    {

        bool isNameEmpty = string.IsNullOrEmpty(ProductNameEntry.Text);
        bool isAmountEmpty = string.IsNullOrEmpty(ProductAmountEntry.Text);
        bool isPriceEmpty = string.IsNullOrEmpty(ProductPriceEntry.Text);

        if (IsSelectedOrNot1) 
        {
            if (isNameEmpty)
            {
                if (isAmountEmpty)
                {
                    if (isPriceEmpty)
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing name, amount and price";
                    }

                    else
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ErrorAddProductLabel.Text = "Missing name and amount";
                    }
                }
                else
                {
                    if (isPriceEmpty)
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing name and price";
                    }
                    else
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ErrorAddProductLabel.Text = "Missing name";
                    }
                }
            }
            else
            {
                if (isAmountEmpty)
                {
                    if (isPriceEmpty)
                    {
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing amount and price";
                    }
                    else
                    {
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ErrorAddProductLabel.Text = "Missing amount";
                    }
                }
                else
                {
                    if (isPriceEmpty)
                    {
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing price";
                    }
                    else
                    {
                        App.ProductRepository.SaveEntity(new MVVM.Models.Products { Productname = ProductNameEntry.Text, Amount = ProductAmountEntry.Text, Price = ProductPriceEntry.Text });
                        Navigation.PushAsync(new MVVM.Views.MainPage());
                    }
                }
            }
        }
        else if (IsSelectedOrNot2)
        {
            if (isNameEmpty)
            {
                if (isAmountEmpty)
                {
                    if (isPriceEmpty)
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing name, amount and price";
                    }

                    else
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ErrorAddProductLabel.Text = "Missing name and amount";
                    }
                }
                else
                {
                    if (isPriceEmpty)
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing name and price";
                    }
                    else
                    {
                        ProductNameEntry.Placeholder = "Enter a name";
                        ErrorAddProductLabel.Text = "Missing name";
                    }
                }
            }
            else
            {
                if (isAmountEmpty)
                {
                    if (isPriceEmpty)
                    {
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing amount and price";
                    }
                    else
                    {
                        ProductAmountEntry.Placeholder = "Enter an amount";
                        ErrorAddProductLabel.Text = "Missing amount";
                    }
                }
                else
                {
                    if (isPriceEmpty)
                    {
                        ProductPriceEntry.Placeholder = "Enter a price";
                        ErrorAddProductLabel.Text = "Missing price";
                    }
                    else
                    {
                        App.ProductRepository.SaveEntity(new MVVM.Models.Products { Productname = ProductNameEntry.Text, Amount = ProductAmountEntry.Text, Price = ProductPriceEntry.Text });
                        Navigation.PushAsync(new MVVM.Views.MainPage());
                    }
                }
            }
        }
        else
        {
            Bottlebutton.BackgroundColor = Color.FromHex("#ff7373");
            Canbutton.BackgroundColor = Color.FromHex("#ff7373");
            ErrorAddProductLabel.Text = "Missing an icon";
        }
    }

    private void Bottlebutton_Clicked(object sender, EventArgs e)
    {
        if (IsSelectedOrNot1)
        {
            IsSelectedOrNot1 = false;
            IconLabel.Text = "";
            Bottlebutton.BackgroundColor = Color.FromHex("#ffffff");
        }
        else
        {
            IsSelectedOrNot1 = true;
            IsSelectedOrNot2 = false;
            IconLabel.Text = "bottleicon.png";
            Bottlebutton.BackgroundColor = Color.FromHex("#cdcdcd");
            Canbutton.BackgroundColor = Color.FromHex("#ffffff");
        }
    }

    private void Canbutton_Clicked(object sender, EventArgs e)
    {
        if (IsSelectedOrNot2)
        {
            IsSelectedOrNot2 = false;
            IconLabel.Text = "";
            Canbutton.BackgroundColor = Color.FromHex("#ffffff");
        }
        else
        {
            IsSelectedOrNot2 = true;
            IsSelectedOrNot1 = false;
            IconLabel.Text = "canicon.png";
            Canbutton.BackgroundColor = Color.FromHex("#cdcdcd");
            Bottlebutton.BackgroundColor = Color.FromHex("#ffffff");
        }
    }

    private void PriceSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        if (PriceSwichState)
        {
            PriceSwichState = false;
        }
        else
        {
            PriceSwichState = true;
        }
    }

    private void CalculateButton_Clicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(ProductPriceEntry.Text, out decimal price))
        {
            if (PriceSwichState == true)
            {
                BalanceChangeLabel.Text = $"Balance + €{price:F2}";
            }
            else
            {
                if (decimal.TryParse(ProductAmountEntry.Text, out decimal amount))
                {
                    decimal total = price * amount;
                    BalanceChangeLabel.Text = $"Balance + €{total:F2}";
                }
                else
                {
                    BalanceChangeLabel.Text = "Invalid amount";
                }
            }
        }

        else
        {
            BalanceChangeLabel.Text = "Invalid price";
        }
    }
}
