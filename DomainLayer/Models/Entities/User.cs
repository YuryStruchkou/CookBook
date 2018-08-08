using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer.Models.Enums;

namespace DomainLayer.Models.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Username { get; set; }

        [Required]
        [MaxLength(128)]
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public Role Role { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
