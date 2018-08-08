using CoreProject.DataConstants;
using DomainLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomainLayer.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<RecipeTag> RecipeTags { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionStrings.DefaultConnection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RecipeTag>()
                .HasKey(rt => new { rt.RecipeId, rt.TagId });
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Vote>()
                .HasOne(c => c.User)
                .WithMany(u => u.Votes)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.User)
                .WithMany(u => u.Recipes)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<User>()
                .HasAlternateKey(u => u.Username);
            modelBuilder.Entity<User>()
                .HasAlternateKey(u => u.Email);
            modelBuilder.Entity<Tag>()
                .HasAlternateKey(t => t.Content);
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username);
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email);
            modelBuilder.Entity<Tag>()
                .HasIndex(t => t.Content);
            modelBuilder.Seed();
            
        }
    }
}
