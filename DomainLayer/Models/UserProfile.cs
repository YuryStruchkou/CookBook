namespace DomainLayer.Models
{
    public class UserProfile
    {
        public string UserId { get; set; }

        public string Avatar { get; set; }

        public bool IsMuted { get; set; }

        public UserStatus UserStatus { get; set; }
    }
}
