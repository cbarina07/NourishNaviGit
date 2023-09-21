namespace NourishNaviGit;

    public partial class Signup_Page : ContentPage
{
    public Signup_Page()
    {
        InitializeComponent();
    }

    private async void OnCreateBtnClicked(object sender, EventArgs e)
    {
        CreateAccount.Text = await yourFunction();
    }

    public async Task<string> yourFunction()
    {
        await Task.Delay(5000);
        await Navigation.PushAsync(new MainPage());
        return "Account Created";
    }
}
