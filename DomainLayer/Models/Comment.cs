using System;

namespace DomainLayer.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime EditDate { get; set; }

        public string UserId { get; set; }

        public string RecipeId { get; set; }
    }
}
