using System;
using System.IO;
using System.Xml.Serialization;
using BusinessLogicLayer.RecipeManagement;
using BusinessLogicLayer.UserManagement;
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

        static void Main(string[] args)
        {
            var userManager = new UserManager();
            var recipeManager = new RecipeManager();
            userManager.AddUser(User1);
            userManager.AddUser(User2);
            recipeManager.AddRecipe(Recipe1);
            recipeManager.AddRecipe(Recipe2);
            recipeManager.AddRecipe(Recipe3);

            User1.Email = "user1@gmail.com";
            Recipe2.Description = "Blah-blah-blah";
            userManager.UpdateUser(User1, u => u.Id == 1);
            recipeManager.UpdateRecipe(Recipe2, r => r.Id == 2);

            Console.WriteLine($"Users: {userManager.GetAll().Count} Recipes: {recipeManager.GetAll().Count}");

            foreach (var user in userManager.Get(u => u.Id == 1))
            {
                Console.WriteLine($"Username: {user.Username}");
                foreach (var recipe in recipeManager.Get(r => r.UserId == user.Id))
                {
                    Console.WriteLine($"\tRecipe: {recipe.Name}");
                }
            }

            userManager.DeleteUser(u => u.Id == 2);
            recipeManager.DeleteRecipe(r => r.Id == 3);

            Console.WriteLine($"Users: {userManager.GetUserCount()} Recipes: {recipeManager.GetRecipeCount()}");

            userManager.DeleteUser(u => true);
            recipeManager.DeleteRecipe(r => true);



            //Console.WriteLine(XmlSerializationHelper<User>.Deserialize(XmlConstants.DefaultUsersXml)?.UserProfile?.UserStatus);
            //XmlSerializationHelper<User>.Serialize(XmlConstants.DefaultUsersXml, User1);
            //Console.WriteLine(XmlSerializationHelper<User>.Deserialize(XmlConstants.DefaultUsersXml).UserProfile.UserStatus);
            //XmlSerializationHelper<Recipe>.Serialize(XmlConstants.DefaultRecipesXml, Recipe2);
            //Console.WriteLine(XmlSerializationHelper<Recipe>.Deserialize(XmlConstants.DefaultRecipesXml).RecipeStatus);
        }
    }
}
// XmlConstants.DefaultUsersXml
//XmlConstants.DefaultRecipesXml