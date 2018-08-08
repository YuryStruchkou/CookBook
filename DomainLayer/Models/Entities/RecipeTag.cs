using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models.Entities
{
    public class RecipeTag
    {
        [Key]
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        [Key]
        [ForeignKey(nameof(Tag))]
        public string TagContent { get; set; }

        public virtual Recipe Recipe { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
