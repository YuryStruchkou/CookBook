namespace DomainLayer.Models
{
    public class Vote
    {
        public int UserId { get; set; }

        public int RecipeId { get; set; }

        public int Value { get; set; }
    }
}
