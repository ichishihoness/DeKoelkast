namespace DeKoelkast;

public partial class ProductPage : ContentPage
{
    private MVVM.Models.Products _product;
    public ProductPage(MVVM.Models.Products product)
	{
        _product = product;
        BindingContext = _product;
        InitializeComponent();
	}
}