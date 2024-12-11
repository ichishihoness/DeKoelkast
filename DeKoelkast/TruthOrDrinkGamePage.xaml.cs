using DeKoelkast.Api;

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
    }
}
