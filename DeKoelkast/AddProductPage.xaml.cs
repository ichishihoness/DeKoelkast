using Microsoft.Maui.Layouts;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

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

    }

    private void AddProduct_Clicked(object sender, EventArgs e)
    {

    }

    private void Bottlebutton_Clicked(object sender, EventArgs e)
    {

        if (IsSelectedOrNot1)
        {
            IsSelectedOrNot1 = false;
            Bottlebutton.BackgroundColor = Color.FromHex("#ffffff");
        }
        else
        {
            IsSelectedOrNot1 = true;
            IsSelectedOrNot2 = false;
            Bottlebutton.BackgroundColor = Color.FromHex("#cdcdcd");
            Canbutton.BackgroundColor = Color.FromHex("#ffffff");
        }

    }

    private void Canbutton_Clicked(object sender, EventArgs e)
    {
        if (IsSelectedOrNot2)
        {
            IsSelectedOrNot2 = false;
            Canbutton.BackgroundColor = Color.FromHex("#ffffff");
        }
        else
        {
            IsSelectedOrNot2 = true;
            IsSelectedOrNot1 = false;
            Canbutton.BackgroundColor = Color.FromHex("#cdcdcd");
            Bottlebutton.BackgroundColor = Color.FromHex("#ffffff");
        }
    }

    private void CalculateButton_Clicked(object sender, EventArgs e)
    {
        if (PriceSwichState)
        {
            BalanceChangeLabel.Text = $"Balance + €{ProductPriceEntry.GetValue}";
        }
    }
}