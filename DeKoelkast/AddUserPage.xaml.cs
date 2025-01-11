using QRCoder;
using DeKoelkast.MVVM.Models;

namespace DeKoelkast;

public partial class AddUserPage : ContentPage
{
    private readonly Users _currentUser;

    public AddUserPage(Users currentUser)
    {
        InitializeComponent();
        _currentUser = currentUser;
    }

    private void GenerateQRButton_Clicked(object sender, EventArgs e)
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        var qrcode = GenerateRandomCode(5);
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrcode, QRCodeGenerator.ECCLevel.L);
        PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeBytes = qRCode.GetGraphic(20);
        QrCodeImage.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        GenerateQRButton.IsEnabled = false;
    }

    private void GenerateCodeButton_Clicked(object sender, EventArgs e)
    {
        var code = GenerateRandomCode(5);
        InvitationCode.Text = code;
        GenerateCodeButton.IsEnabled = false;
    }

    private string GenerateRandomCode(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var random = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    private void ReturnToMainFromAddUser_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MVVM.Views.MainPage(_currentUser));
    }
}
