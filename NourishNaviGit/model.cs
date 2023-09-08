// User model
public class User
{
    public int User_ID { get; set; }
    public string Email { get; set; }
    public string Password_Hash { get; set; }
    public DateTime Created_At { get; set; }
}

// Preference model
public class Preference
{
    public int Preference_ID { get; set; }
    public int User_ID { get; set; }
    public string Liked_Foods { get; set; }
    public string Disliked_Foods { get; set; }
    public string Allergies { get; set; }
    public string Other_Preferences { get; set; }
    public DateTime Updated_At { get; set; }
}

// Menu model
public class Menu
{
    public int Menu_ID { get; set; }
    public int User_ID { get; set; }
    public string Menu_Content { get; set; }
    public DateTime Generated_At { get; set; }
}
