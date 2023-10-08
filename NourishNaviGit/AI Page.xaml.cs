using static Microsoft.Maui.ApplicationModel.Permissions;
using System.Diagnostics;
using System.Reflection;
using ChatGptNet;
using ChatGptNet.Models;
using Azure;
using Microsoft.Maui.Controls;

namespace NourishNaviGit;

    public partial class AIPage : ContentPage
    {
        public AIPage(string aiResponse)
        {
            InitializeComponent();

        // Display the AI response in the UI
        GeneratedResponseTextBlock.Text = aiResponse;
        }
    }
