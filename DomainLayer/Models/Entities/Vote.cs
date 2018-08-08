using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models.Entities
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }

        [ForeignKey(nameof(Recipe))]
        public int? RecipeId { get; set; }

        [Required]
        public int Value { get; set; }

        public virtual UserProfile User { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
