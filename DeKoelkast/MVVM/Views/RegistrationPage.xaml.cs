using Microsoft.Maui.Devices.Sensors;
namespace DeKoelkast;

public partial class RegistrationPage : ContentPage
{
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
            UsernameRegistrationEntry.Placeholder = "Enter a username";
        }
        if (isPasswordEmpty)
        {
            PasswordRegistrationEntry.Placeholder = "Enter a password";
        }
        else
        {
            App.UserRepository.AddOrUpdate(new MVVM.Models.Users { Username = UsernameRegistrationEntry.Text, Password = PasswordRegistrationEntry.Text });
            Navigation.PushAsync(new MVVM.Views.MainPage());
        }
    }

    private void LoginPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
}