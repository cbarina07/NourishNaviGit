namespace NourishNaviGit;

public partial class Login_Page : ContentPage
{
	public Login_Page()
	{
		InitializeComponent();
	}
	private async void OnLogBtnClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HomePage());
	}
}


