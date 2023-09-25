using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NourishNaviGit
{
    public class PromptGenerator
    {
        public static string WritePrompt(string age, string gender, string activity, string meals, string diet, string allergy, string dislikes, string likes)
        {
            // Define the prompt sections and other variables here
            string sectionAge = "I am a ";
            string sectionActivity = ", my activity level is ";
            string sectionMeals = ", I want my meal plan to only include ";
            string sectionDiet = ", my diet is ";
            string sectionAllergy = ", I am allergic to ";
            string sectionDislikes = ", I'd rather not have ";
            string sectionLikes = ", and I would like ";
            string promptOpen = "Write me a daily meal plan for the next week, ";
            string promptSimple = "and return only the titles of each meal";

            // Construct the prompt based on input parameters
            string promptAge = sectionAge + age;
            string promptActivity = sectionActivity + activity;
            string promptMeals = sectionMeals + meals;
            string promptDiet = sectionDiet + diet;
            string promptAllergy = sectionAllergy + allergy;
            string promptDislikes = sectionDislikes + dislikes;
            string promptLikes = sectionLikes + likes;

            // Construct the full prompt
            string promptFull = promptOpen + promptSimple + ". " + promptAge + " year old " + gender + promptActivity + promptMeals + promptDiet + promptAllergy + promptDislikes + promptLikes + " to be included at least once.";

            return promptFull;
        }
    }
}