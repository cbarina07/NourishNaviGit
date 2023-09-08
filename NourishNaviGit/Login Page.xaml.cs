namespace NourishNaviGit;

public partial class Login_Page : ContentPage
{
	public Login_Page()
	{
		InitializeComponent();
	}

	void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}

   