namespace NourishNaviGit;

public partial class Signup_Page : ContentPage
{
    //Placeholder: see Login Page for notes on how this works
    private void OnCreateBtnClicked(object sender, EventArgs e)
    {
        CreateAccount.Text = yourFunction();
    }
    //end of placeholder
    public Signup_Page()
	{
		InitializeComponent();
       
    }

    //placeholder (Will take user back to homepage to login after account created is displayed wait 5 seconds)
    public string yourFunction()
    {
        return "Account Created";
    }
    //end of placeholder
}