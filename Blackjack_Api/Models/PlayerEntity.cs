using MongoDB.Bson;

namespace blackjack.Models
{
    public class PlayerEntity
    {
        public int[] cards;

        public int score;

        public int[] hidden;
    }
}