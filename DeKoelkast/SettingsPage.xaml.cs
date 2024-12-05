namespace DeKoelkast;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
	{
		InitializeComponent();
	}

    private void BackToMainPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MVVM.Views.MainPage());
    }
}