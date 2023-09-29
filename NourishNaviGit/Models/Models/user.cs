using System;
using System.Collections.Generic;

namespace NourishNaviGit.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<SurveyResponse> SurveyResponses { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<UserFavorites> Favorites { get; set; }
        public List<Order> Orders { get; set; }
    }
}