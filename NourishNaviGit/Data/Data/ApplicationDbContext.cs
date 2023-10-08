//using Android.Content;
//using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NourishNaviGit.Models;

namespace NourishNaviGit.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for your models
        public DbSet<User> Users { get; set; }
        public DbSet<SurveyResponse> SurveyResponses { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserFavorites> UserFavorites { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships, indexes, etc., here if needed

            // Configure User entity
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            // Configure SurveyResponse entity
            modelBuilder.Entity<SurveyResponse>()
                .HasKey(sr => sr.SurveyResponseId);

            // Configure UserFavorites entity
            modelBuilder.Entity<UserFavorites>()
                .HasKey(uf => uf.UserFavoritesId);

            // Configure UserProfile entity
            modelBuilder.Entity<UserProfile>()
                .HasKey(up => up.UserProfileId);

            // Configure Product entity
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);

            // Configure Order entity
            modelBuilder.Entity<Order>()
                .HasKey(o => o.OrderId);

            // Define relationships
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SurveyResponse>()
                .HasOne(sr => sr.User)
                .WithMany(u => u.SurveyResponses)
                .HasForeignKey(sr => sr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserFavorites>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(uf => uf.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserFavorites>()
                .HasOne(uf => uf.Product)
                .WithMany(p => p.FavoritedByUsers)
                .HasForeignKey(uf => uf.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserProfile>()
                .HasOne(up => up.User)
                .WithOne(u => u.UserProfile)
                .HasForeignKey<UserProfile>(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }
    }
}