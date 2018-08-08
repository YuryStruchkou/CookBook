using System;
using DomainLayer.Models.Entities;
using DomainLayer.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DomainLayer.DatabaseContext
{
    public static class ModelBuilderExtensions
    {
        static readonly User User1 = new User
        {
            Id = 1,
            Username = "user1",
            Email = "user1@example.com",
            PasswordHash = "yfhrhr838319-sdkkie92-sdew2",
            CreationDate = new DateTime(2018, 8, 1),
            Role = Role.User,
        };

        static readonly User User2 = new User
        {
            Id = 2,
            Username = "user2",
            Email = "user2@example.com",
            PasswordHash = "yfhrhr838319-sdkkie92-sdew2",
            CreationDate = new DateTime(2018, 8, 1),
            Role = Role.Admin,
        };

        private static readonly UserProfile UserProfile1 = new UserProfile
        {
            UserId = 1,
            Avatar = "https://kek.com/kek.jpg",
            IsMuted = false,
            UserStatus = UserStatus.Active
        };

        private static readonly UserProfile UserProfile2 = new UserProfile
        {
            UserId = 2,
            Avatar = "https://kek.com/kek.jpg",
            IsMuted = false,
            UserStatus = UserStatus.Active
        };

        static readonly Recipe Recipe1 = new Recipe
        {
            Id = 1,
            Name = "Something",
            Content = "Blah",
            Description = "Blah-blah",
            CreationDate = new DateTime(2018, 8, 1),
            EditDate = null,
            DeleteDate = null,
            RecipeStatus = RecipeStatus.Active,
            UserId = 1
        };

        static readonly Recipe Recipe2 = new Recipe
        {
            Id = 2,
            Name = "SomethingElse",
            Content = "Blah",
            Description = "Blah-blah",
            CreationDate = new DateTime(2018, 8, 1),
            EditDate = new DateTime(2018, 8, 2),
            DeleteDate = new DateTime(2018, 8, 4),
            RecipeStatus = RecipeStatus.Deleted,
            UserId = 1
        };

        static readonly Recipe Recipe3 = new Recipe
        {
            Id = 3,
            Name = "SomethingElseElse",
            Content = "Blah",
            Description = "Blah-blah",
            CreationDate = new DateTime(2018, 8, 1),
            EditDate = new DateTime(2018, 8, 3),
            DeleteDate = null,
            RecipeStatus = RecipeStatus.Active,
            UserId = 2
        };

        private static readonly Vote Vote1 = new Vote
        {
            Id = 1,
            RecipeId = 1,
            UserId = 1,
            Value = 5
        };

        private static readonly Vote Vote2 = new Vote
        {
            Id = 2,
            RecipeId = 1,
            UserId = 2,
            Value = 2
        };

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(User1);
           

            modelBuilder.Entity<User>()
                .HasData(User2);

            modelBuilder.Entity<UserProfile>()
                .HasData(UserProfile1);

            modelBuilder.Entity<UserProfile>()
                .HasData(UserProfile2);

            modelBuilder.Entity<Recipe>()
            .HasData(Recipe1);
            modelBuilder.Entity<Recipe>()
            .HasData(Recipe2);
            modelBuilder.Entity<Recipe>()
            .HasData(Recipe3);
            modelBuilder.Entity<Vote>()
            .HasData(Vote1);
            modelBuilder.Entity<Vote>()
            .HasData(Vote2);
}
    }
}
