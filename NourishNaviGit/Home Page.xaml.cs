namespace NourishNaviGit;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    private async void OnFormBtnClicked(object sender, EventArgs e)
    {
     await Navigation.PushAsync(new NourishNaviGit.FormPage());
    }

    private async void OnUserBtnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NourishNaviGit.AboutMe());
    }
}