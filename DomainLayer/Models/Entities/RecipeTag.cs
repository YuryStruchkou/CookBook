using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models.Entities
{
    public class RecipeTag
    {
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        [ForeignKey(nameof(Tag))]
        public int TagId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
