namespace NourishNaviGit;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnLoginBtnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login_Page());
    }

    private async void OnSignupBtnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Signup_Page());
    }
}