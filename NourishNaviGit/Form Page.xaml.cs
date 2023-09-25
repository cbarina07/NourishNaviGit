using NourishNaviGit;

namespace NourishNaviGit;

public partial class FormPage : ContentPage
{
    //int count = 0;

    public FormPage()
    {
        InitializeComponent();
    }

    private async void OnPromptClicked(object sender, EventArgs e)
    {

        // Gather user input
        string age = entryAge.Text;
        string gender = entryGender.Text;
        string activity = entryActivity.Text;
        string meals = entryMeals.Text;
        string diet = entryDiet.Text;
        string allergy = entryAllergy.Text;
        string dislikes = entryDislikes.Text;
        string likes = entryLikes.Text;

        // Display "Generating" on the button
        PromptBtn.Text = "Generating...";

        // Delay for 5 seconds
        await Task.Delay(2000);

        string generatedPrompt = PromptGenerator.WritePrompt(age, gender, activity, meals, diet, allergy, dislikes, likes);

        // Navigate to the generation page
        await Navigation.PushAsync(new GenerationPage(generatedPrompt));
    }
}
        