namespace DeKoelkast.MVVM.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BackToLoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        private void ProductButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as ImageButton;
            var product = button?.BindingContext as MVVM.Models.Products;
            if (product != null)
            {
                Navigation.PushAsync(new ProductPage(product));
            }
        }

        private void AddProductButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProductPage());
        }

        private void AddUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddUserPage());
        }

        private void TruthOrDrinkButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TruthOrDrinkGamePage());
        }
    }

}
