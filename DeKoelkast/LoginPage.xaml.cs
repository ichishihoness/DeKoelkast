namespace DeKoelkast;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        bool isUsernameEmpty = string.IsNullOrEmpty(UsernameLoginEntry.Text);
        bool isPasswordEmpty = string.IsNullOrEmpty(PasswordLoginEntry.Text);

        if (isUsernameEmpty)
        {
            UsernameLoginEntry.Placeholder = "Enter a username";
        }
        if (isPasswordEmpty)
        {
            PasswordLoginEntry.Placeholder = "Enter a password";
        }
        else
        {
            Navigation.PushAsync(new MainPage());
        }
    }

    private void RegistrationPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistrationPage());
    }
}