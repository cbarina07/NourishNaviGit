using System;

namespace NourishNaviGit.Models
{
    public class SurveyResponse
    {
        public int SurveyResponseId { get; set; }
        public int UserId { get; set; }
        public DateTime ResponseDate { get; set; }
        // Other survey-specific fields
        public User User { get; set; }
    }
}