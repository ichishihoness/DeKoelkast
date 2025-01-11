using Microsoft.Maui.Devices.Sensors;
namespace DeKoelkast;
using DeKoelkast.MVVM.Models;

public partial class RegistrationPage : ContentPage
{
    private Users _currentUser;

    public RegistrationPage()
    {
        InitializeComponent();
    }

    private void RegistrationButton_Clicked(object sender, EventArgs e)
    {
        bool isUsernameEmpty = string.IsNullOrEmpty(UsernameRegistrationEntry.Text);
        bool isPasswordEmpty = string.IsNullOrEmpty(PasswordRegistrationEntry.Text);

        if (isUsernameEmpty)
        {
            if (isPasswordEmpty)
            {
                UsernameRegistrationEntry.Placeholder = "Enter a username";
                PasswordRegistrationEntry.Placeholder = "Enter a password";
            }
            else
            {
                UsernameRegistrationEntry.Placeholder = "Enter a username";
            }
        }
        if (isPasswordEmpty)
        {
            PasswordRegistrationEntry.Placeholder = "Enter a password";
        }
        else
        {
            _currentUser = new Users { Username = UsernameRegistrationEntry.Text, Password = PasswordRegistrationEntry.Text };
            App.UserRepository.SaveEntity(_currentUser);
            Navigation.PushAsync(new FridgesPage(_currentUser));
        }
    }

    private void LoginPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
}
