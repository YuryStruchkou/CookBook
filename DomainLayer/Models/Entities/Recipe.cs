using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer.Models.Enums;

namespace DomainLayer.Models.Entities
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? EditDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        [Required]
        public RecipeStatus RecipeStatus { get; set; }

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        
        public virtual UserProfile User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<RecipeTag> RecipeTags { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

    }
}
