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
            string sectionMeals = ", I want my meal plan to include just ";
            string sectionDiet = ", my diet is ";




            // Construct the prompt based on input parameters
            string promptAge = sectionAge + age;
            string promptActivity = sectionActivity + activity;
            string promptMeals = sectionMeals + meals;
            string promptDiet = sectionDiet + diet;


            // Construct the full prompt
            string promptPrimary = promptAge + " year old " + gender + promptActivity + promptMeals + promptDiet + allergy + " " + dislikes + likes;

            return promptPrimary;

        }
    }
}