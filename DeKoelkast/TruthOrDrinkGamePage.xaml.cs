using DeKoelkast.Api;
using DeKoelkast.MVVM.Views;
using DeKoelkast.MVVM.Models;

namespace DeKoelkast;

public partial class TruthOrDrinkGamePage : ContentPage
{
    private readonly Users _currentUser;

    public TruthOrDrinkGamePage(Users currentUser)
    {
        InitializeComponent();
        _currentUser = currentUser;
    }

    private async void PLayAPIButton_Clicked(object sender, EventArgs e)
    {
        var result = await ApiQuestion.GetTruth();
        QuestionBox.Text = result.question;
        PLayAPIButton.Text = "Next question";
    }

    private void BackToMainPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage(_currentUser));
    }
}
