﻿using NourishNaviGit;

namespace NourishNaviGit;

public partial class FormPage : ContentPage
{
    //int count = 0;

    private readonly Dictionary<string, List<RadioButton>> radioButtonGroups = new Dictionary<string, List<RadioButton>>();

    public FormPage()
    {
        InitializeComponent();

        // Adding radio buttons to dictionary so that clicking a radio button in one section doesnt unclick radio buttons in other sections 
        AddRadioButtonToGroup("Gender", MaleRadioButton);
        AddRadioButtonToGroup("Gender", FemaleRadioButton);
        AddRadioButtonToGroup("Gender", NonBinaryRadioButton);
        AddRadioButtonToGroup("Gender", OtherRadioButton);
        
        AddRadioButtonToGroup("Activity", NoActivityRadioButton);
        AddRadioButtonToGroup("Activity", LittleActivityRadioButton);
        AddRadioButtonToGroup("Activity", QuiteActiveRadioButton);
        AddRadioButtonToGroup("Activity", VeryActiveRadioButton);

        AddRadioButtonToGroup("Diet", NoRestrictionsRadioButton);
        AddRadioButtonToGroup("Diet", VegetarianRadioButton);
        AddRadioButtonToGroup("Diet", PescetarianRadioButton);
        AddRadioButtonToGroup("Diet", GlutenFreeRadioButton);
        AddRadioButtonToGroup("Diet", HalalRadioButton);
        AddRadioButtonToGroup("Diet", OtherDietRadioButton);


        //UNCERTAIN IF I NEED THIS SO JUST UNCOMMENTING FOR NOW
        AddRadioButtonToGroup("Dislikes", NoDislikes);
        AddRadioButtonToGroup("Dislikes", YesDislikes);

        AddRadioButtonToGroup("Likes", NoLikes);
        AddRadioButtonToGroup("Likes", YesLikes);



        // adding check changed to each radio button
        foreach (var group in radioButtonGroups.Values)
        {
            foreach (var radioButton in group)
            {
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
            }
        }
    }

    // Helper method to add radio buttons to a group in the dictionary
    private void AddRadioButtonToGroup(string groupName, RadioButton radioButton)
    {
        if (!radioButtonGroups.ContainsKey(groupName))
        {
            radioButtonGroups[groupName] = new List<RadioButton>();
        }

        radioButtonGroups[groupName].Add(radioButton);
    }

    // Event handler for radio button checked changes
    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton radioButton && radioButton.IsChecked)
        {
            // Get the group name of the selected radio button
            string groupName = radioButton.GroupName;

            // Deselect other radio buttons in the same group
            foreach (var otherRadioButton in radioButtonGroups[groupName].Where(rb => rb != radioButton))
            {
                otherRadioButton.IsChecked = false;
            }
            // Check if the selected radio button is not the "Other (Please specify)" option
            if (radioButton != OtherDietRadioButton)
            {
                // If anything is checked other than "Other," hide the entry field
                entryDiet.IsVisible = false;
            }
            else
            {
                // If "Other" is checked, show the entry field
                // means that people wont be able to select vegeterian and then also type something in "other"
                entryDiet.IsVisible = true;
            }

        }
    }

    // means that the extended prompt answer will only show if circumstance is met
    private void NoDietRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            // If "No" is checked, hide the entry field
            entryDiet.IsVisible = false;
        }
        else
        {
            // If "No" is unchecked, show the entry field
            entryDiet.IsVisible = true;
        }
    }
    private void NoAllergiesRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            // If "No" is checked, hide the entry field
            entryAllergy.IsVisible = false;
        }
        else
        {
            // If "No" is unchecked, show the entry field
            entryAllergy.IsVisible = true;
        }
    }
    private void NoDislikesRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            // If "No" is checked, hide the entry field
            entryDislikes.IsVisible = false;
        }
        else
        {
            // If "No" is unchecked, show the entry field
            entryDislikes.IsVisible = true;
        }
    }

    private void NoPreferencesRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            // If "No" is checked, hide the entry field
            entryLikes.IsVisible = false;
        }
        else
        {
            // If "No" is unchecked, show the entry field
            entryLikes.IsVisible = true;
        }
    }
    //MAKE CHECKBOX INTO STRING DEPENDING ON SELECTION
    private string GetSelectedMeals()
    {
        List<string> selectedMeals = new List<string>();

        if (BreakfastCheckbox.IsChecked)
        {
            selectedMeals.Add("Breakfast");
        }

        if (LunchCheckbox.IsChecked)
        {
            selectedMeals.Add("Lunch");
        }

        if (DinnerCheckbox.IsChecked)
        {
            selectedMeals.Add("Dinner");
        }

        if (SnacksCheckbox.IsChecked)
        {
            selectedMeals.Add("Snacks");
        }

        // Combine the selected meals into a string with "AND" before the last option
        if (selectedMeals.Count > 1)
        {
            string lastMeal = selectedMeals.Last();
            selectedMeals[selectedMeals.Count - 1] = "and " + lastMeal;
        }

        string selectedMealsString = string.Join(", ", selectedMeals);

        return selectedMealsString;
    }


    //GET USER INPUT TOTAL METHOD
    private async void OnPromptClicked(object sender, EventArgs e)
    {

        // Gather user input
        string age = entryAge.Text;
        
        //PREFFERRED GENDER
        string gender = "";
        if (MaleRadioButton.IsChecked)
        {
            gender = "Male";
        }
        else if (FemaleRadioButton.IsChecked)
        {
            gender = "Female";
        }
        else if (NonBinaryRadioButton.IsChecked)
        {
            gender = "Non-Binary";
        }
        else if (OtherRadioButton.IsChecked)
        {
            gender = "NA"; 
        }


        //ACTIVITY LEVEL
        string activity = "";
        if (NoActivityRadioButton.IsChecked)
        {
            activity = "Low (0-1 days a week)";
        }
        else if (LittleActivityRadioButton.IsChecked)
        {
            activity = "Fair (1-2 days a week)";
        }
        else if (QuiteActiveRadioButton.IsChecked)
        {
            activity = "Active (2-4 days a week)";
        }
        else if (VeryActiveRadioButton.IsChecked)
        {
            activity = "Very Active (5+ days a week)";
        }

        //NUMBER OF MEALS DESIRED

        string meals = GetSelectedMeals();



        // SPECIFIC DIETS//
        string diet = "";
        
        if (NoRestrictionsRadioButton.IsChecked)
        {
            diet = "Unrestricted";
        }      
        else if (VegetarianRadioButton.IsChecked)
        {
            diet = "Vegetarian";
        }
        else if (PescetarianRadioButton.IsChecked)
        {
            diet = "Pescetarian";
        }
        else if (GlutenFreeRadioButton.IsChecked)
        {
            diet = "Gluten-Free";
        }
        else if (HalalRadioButton.IsChecked)
        {
            diet = "Halal";
        }
        else if (OtherDietRadioButton.IsChecked)
        {
            diet = entryDiet.Text;
        }


        //ALLERGIES
        string allergy;
        if (YesAllergy.IsChecked)
        {
            allergy = entryAllergy.Text;
        }
        else
        {
            allergy = "no food";
        }



        //DISLIKES//
        string dislikes;
        if (YesDislikes.IsChecked)
        {
            dislikes = entryDislikes.Text;
        }
        else
        {
            dislikes = "there is nothing ";
        }


        //LIKES//
        string likes;
        if (YesLikes.IsChecked)
        {
            likes = entryLikes.Text;
        }
        else
        {
            likes = "no specific foods";
        }





        // Display "Generating" on the button
        PromptBtn.Text = "Generating...";

        // Delay for 5 seconds
        await Task.Delay(2000);

        string generatedPrompt = PromptGenerator.WritePrompt(age, gender, activity, meals, diet, allergy, dislikes, likes);

        // Navigate to the generation page
        await Navigation.PushAsync(new GenerationPage(generatedPrompt));
    }
}
        