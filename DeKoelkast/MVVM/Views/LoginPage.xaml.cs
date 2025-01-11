namespace DeKoelkast;
using DeKoelkast.MVVM.Models;

public partial class LoginPage : ContentPage
{
    private Users _currentUser;

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
            _currentUser = App.UserRepository.GetEntities().FirstOrDefault(user => user.Username == UsernameLoginEntry.Text && user.Password == PasswordLoginEntry.Text);
            if (_currentUser != null)
            {
                Navigation.PushAsync(new FridgesPage(_currentUser));
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
