namespace DeKoelkast
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
            Navigation.PushAsync(new ProductPage());
        }

        private void AddProductButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProductPage());
        }

        private void AddUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddUserPage());
        }

    }

}
