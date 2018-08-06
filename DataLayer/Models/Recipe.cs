using System;

namespace DataLayer.Models
{
    public class Recipe
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? EditDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public RecipeStatus RecipeStatus { get; set; }

        public string UserId { get; set; } 
    }
}
