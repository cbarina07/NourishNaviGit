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

    //placeholder
    public string yourFunction()
    {
        return "you clicked the button yay";
    }
    //end of placeholder
}