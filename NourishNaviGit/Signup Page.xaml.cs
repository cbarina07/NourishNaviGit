namespace NourishNaviGit
{
    public partial class Signup_Page : ContentPage
    {
        public Signup_Page()
        {
            InitializeComponent();
        }

        private async void OnCreateBtnClicked(object sender, EventArgs e)
        {
            // Display "Account Created" on the button
            CreateAccount.Text = "Account Created";

            // Delay for 5 seconds
            await Task.Delay(2000);

            // Navigate to the home page
            await Navigation.PushAsync(new MainPage());
        }
    }
}
