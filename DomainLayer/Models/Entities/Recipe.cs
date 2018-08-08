using System;

namespace DomainLayer.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? EditDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public RecipeStatus RecipeStatus { get; set; }

        public int UserId { get; set; } 
    }
}
