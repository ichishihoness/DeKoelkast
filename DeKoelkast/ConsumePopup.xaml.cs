using CommunityToolkit.Maui.Views;

namespace MauiToolkitPopupSample;

public partial class ConsumePopup : Popup
{
	public ConsumePopup()
	{
		InitializeComponent();
	}

    private void CancelConsumeButton_Clicked(object sender, EventArgs e)
    {
        Close();
    }

    private void ConfirmConsumeButton_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}