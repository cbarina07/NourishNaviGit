namespace NourishNaviGit.Models
{
    public class UserFavorites
    {
        public int UserFavoritesId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        // Additional fields if needed
        public User User { get; set; }
        public Product Product { get; set; }
    }
}