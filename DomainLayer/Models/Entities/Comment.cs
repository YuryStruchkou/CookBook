using System;

namespace DomainLayer.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? EditDate { get; set; }

        public int UserId { get; set; }

        public int RecipeId { get; set; }
    }
}
