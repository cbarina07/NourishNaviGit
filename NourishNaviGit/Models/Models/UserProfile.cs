using System;

namespace NourishNaviGit.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public int UserId { get; set; }
        public string Bio { get; set; }
        public string ProfileImage { get; set; }
        // Other profile-specific fields
        public User User { get; set; }
    }
}