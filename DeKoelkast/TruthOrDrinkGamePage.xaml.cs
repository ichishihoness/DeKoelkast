using DeKoelkast.Api;
using DeKoelkast.MVVM.Views;

namespace DeKoelkast;

public partial class TruthOrDrinkGamePage : ContentPage
{
    public TruthOrDrinkGamePage()
    {
        InitializeComponent();
    }

    private async void PLayAPIButton_Clicked(object sender, EventArgs e)
    {
        var result = await ApiQuestion.GetTruth();
        QuestionBox.Text = result.question;
        PLayAPIButton.Text = "Next question";
    }

    private void BackToMainPageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}
