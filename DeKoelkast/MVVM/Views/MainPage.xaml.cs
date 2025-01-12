using DeKoelkast.MVVM.Models;

namespace DeKoelkast.MVVM.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly Users _currentUser;

        public MainPage(Users currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void BackToLoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FridgesPage(_currentUser));
        }

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage(_currentUser));
        }

        private void ProductButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as ImageButton;
            var product = button?.BindingContext as MVVM.Models.Products;
            if (product != null)
            {
                Navigation.PushAsync(new ProductPage(product, _currentUser));
            }
        }

        private void AddProductButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProductPage(_currentUser));
        }

        private void TruthOrDrinkButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TruthOrDrinkGamePage(_currentUser));
        }

        private void AddUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddUserPage(_currentUser));
        }
    }
}
