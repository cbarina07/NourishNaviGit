namespace NourishNaviGit.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ICollection<UserFavorites> FavoritedByUsers { get; set; }
        // Add other product-specific fields here
    }
}