using static Microsoft.Maui.ApplicationModel.Permissions;
using System.Diagnostics;
using System.Reflection;
namespace NourishNaviGit;

public partial class GenerationPage : ContentPage
{
    public GenerationPage(string generatedPrompt)
    {
        InitializeComponent();

        // Display the generated prompt
        GeneratedPromptTextBlock.Text = generatedPrompt;
    }
}