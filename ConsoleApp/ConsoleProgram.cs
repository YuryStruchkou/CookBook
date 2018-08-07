using System;
using System.IO;
using System.Xml.Serialization;
using BusinessLogicLayer.RecipeManagement;
using BusinessLogicLayer.UserManagement;
using BusinessLogicLayer.VoteManagement;
using CoreProject;
using CoreProject.DataConstants;
using DomainLayer.Models;

namespace ConsolePresentationLayer
{
    class ConsoleProgram
    {
        static readonly User User1 = new User
        {
            Id = 1,
            Username = "user1",
            Email = "user1@example.com",
            PasswordHash = "yfhrhr838319-sdkkie92-sdew2",
            CreationDate = new DateTime(2018, 8, 1),
            Role = Role.User,
            UserProfile = new UserProfile
            {
                UserId = 1,
                Avatar = "https://kek.com/kek.jpg",
                IsMuted = false,
                UserStatus = UserStatus.Active
            }
        };

        static readonly User User2 = new User
        {
            Id = 2,
            Username = "user2",
            Email = "user2@example.com",
            PasswordHash = "yfhrhr838319-sdkkie92-sdew2",
            CreationDate = new DateTime(2018, 8, 1),
            Role = Role.Admin,
            UserProfile = new UserProfile
            {
                UserId = 2,
                Avatar = "https://kek.com/kek.jpg",
                IsMuted = false,
                UserStatus = UserStatus.Active
            }
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
            RecipeId = 1,
            UserId = 1,
            Value = 5
        };

        private static readonly Vote Vote2 = new Vote
        {
            RecipeId = 1,
            UserId = 2,
            Value = 2
        };

        static void Main(string[] args)
        {

            var userManager = new UserManager();
            var recipeManager = new RecipeManager();
            var voteManager = new VoteManager();

            userManager.AddUser(User1);
            userManager.AddUser(User2);
            recipeManager.AddRecipe(Recipe1);
            recipeManager.AddRecipe(Recipe2);
            recipeManager.AddRecipe(Recipe3);
            voteManager.AddVote(Vote1);
            voteManager.AddVote(Vote2);

            User user;
            Recipe recipe;
            while (true)
            {
                Console.WriteLine("Enter user name: ");
                var username = Console.ReadLine();
                user = userManager.GetUserByUsername(username);
                if (user == null)
                    Console.WriteLine("No such user found.");
                else
                    break;
            }
            while (true)
            {
                Console.WriteLine("Enter recipe name: ");
                var recipeName = Console.ReadLine();
                recipe = userManager.GetRecipeByName(user.Id, recipeName);
                if (recipe == null)
                    Console.WriteLine("No such recipe found.");
                else
                    break;
            }
            Console.WriteLine($"Average grade is {recipeManager.GetAverageVote(recipe.Id)}");

            userManager.DeleteUser(u => true);
            recipeManager.DeleteRecipe(r => true);
            voteManager.DeleteVote(v => true);
        }
    }
}