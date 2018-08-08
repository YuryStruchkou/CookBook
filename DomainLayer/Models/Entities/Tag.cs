using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models.Entities
{
    public class Tag
    {
        [Key]
        public string Content { get; set; }

        public virtual ICollection<RecipeTag> RecipeTags { get; set; }
    }
}
