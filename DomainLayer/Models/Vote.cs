namespace DomainLayer.Models
{
    public class Vote
    {
        public string UserId { get; set; }

        public string RecipeId { get; set; }

        public int Value { get; set; }
    }
}
