using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer.Models.Enums;

namespace DomainLayer.Models.Entities
{
    public class UserProfile
    {
        [Key]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public string Avatar { get; set; }
        
        [Required]
        public bool IsMuted { get; set; }

        [Required]
        public UserStatus UserStatus { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
