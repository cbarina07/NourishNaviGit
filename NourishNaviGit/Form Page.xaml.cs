namespace PromptCreate;

    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
                CounterBtn.Text = writePrompt();

        }

        //Initialising variables - defaults to null so program can detect which inputs exist and should be included in the final prompt.
        
        string userAge = "0";
        string userGender = "demo"; //eg. Female
        string userActivity = "demo"; //eg. Sedentary
        string userMeals = "demo"; //eg. breakfast, dinner
        string userDiet = "demo"; //eg. halal
        string userAllergy = "demo"; //eg. nuts

        // These two address cravings for the week - an additional feature that makes this entry non-permanent in menu completion section.
        string userDislikes = "demo"; //eg. broccoli
        string userLikes = "demo"; //eg. pumpkin

        //prompt section formats
        static string sectionAge = "I am a ";
        static string sectionActivity = ", my lifestyle is ";
        static string sectionMeals = ", I want to eat ";
        static string sectionDiet = ", my diet is ";
        static string sectionAllergy = ", I can't have ";
        static string sectionDislikes = ", I'd rather not have ";
        static string sectionLikes = ", I'm feeling like ";

        //prompt sections
        string promptAge;
        string promptActivity;
        string promptMeals;
        string promptDiet;
        string promptAllergy;
        string promptDislikes;
        string promptLikes;

        //prompt types
        static string promptOpen = "Write me a meal plan for the next week ";
        static string promptSimple = "and give me only the headings of each meal, ";
        string promptFull;
        protected string writePrompt() {
            // This design assumes the default value will be "None".
            if (entrySimple.IsChecked != true)
            {
                promptSimple = "";
            }
            userAge = entryAge.Text;
            promptAge = sectionAge + userAge;
            userGender = entryGender.Text;
            userActivity = entryActivity.Text;
 
            if (userActivity == "None")
            {
                promptActivity = "";
            }
            else
            {
                promptActivity = sectionActivity + userActivity;
            }
            userMeals = entryMeals.Text;
            if (userMeals == "None")
            {
                promptMeals = "";
            }
            else
            {
                promptMeals = sectionMeals + userMeals;
            }
            userDiet = entryDiet.Text;
            if (userDiet == "None") {
                promptDiet = "";
            }
            else
            {
                promptDiet = sectionDiet + userDiet;
            }
            userAllergy = entryAllergy.Text;
            if (userAllergy == "None")
            {
                promptAllergy = "";
            }
            else
            {
                promptAllergy = sectionAllergy + userAllergy;
            }
            userDislikes = entryDislikes.Text;
            if (userDislikes == "None")
            {
                promptDislikes = "";
            }
            else
            {
                promptDislikes = sectionDislikes + userDislikes;
            }
            userLikes = entryLikes.Text;
            if (userLikes == "None")
            {
                promptLikes = "";
            }
            else
            {
                promptLikes = sectionLikes + userLikes;
            }
            //Expected output with sample variables: Write me a meal plan for the next week and give me only
            //the headings of each meal, I am a Female, my diet is Vegan, I am allergic to Peanuts.
            promptFull = promptOpen + promptSimple + ", " + promptAge + " year old " + userGender + promptActivity + promptMeals + promptDiet + promptAllergy + promptDislikes + promptLikes + ".";
            return promptFull;
        }
    }
