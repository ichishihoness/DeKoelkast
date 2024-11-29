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
            if (isPasswordEmpty)
            {
                UsernameLoginEntry.Placeholder = "Enter a username";
                PasswordLoginEntry.Placeholder = "Enter a password";
            }
            else
            {
                UsernameLoginEntry.Placeholder = "Enter a username";
            }
        }
        if (isPasswordEmpty)
        {
            PasswordLoginEntry.Placeholder = "Enter a password";
        }
        else
        {
            if (App.UserRepository.GetLogin(UsernameLoginEntry.Text, PasswordLoginEntry.Text))
            {
                Navigation.PushAsync(new MVVM.Views.MainPage());
            }
            else
            {
                UsernameLoginEntry.Text = "";
                PasswordLoginEntry.Text = "";
                UsernameLoginEntry.Placeholder = "User not found";
                PasswordLoginEntry.Placeholder = "User not found";
            }
        }
    }

    private void RegistrationPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistrationPage());
    }
}