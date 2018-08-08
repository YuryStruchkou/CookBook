namespace DomainLayer.Models
{
    public class UserProfile
    {
        public int UserId { get; set; }

        public string Avatar { get; set; }

        public bool IsMuted { get; set; }

        public UserStatus UserStatus { get; set; }
    }
}
