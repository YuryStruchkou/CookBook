using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public virtual ICollection<RecipeTag> RecipeTags { get; set; }
    }
}
