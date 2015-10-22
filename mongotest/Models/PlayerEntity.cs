using MongoDB.Bson;

namespace mongotest.Models
{
    public class PlayerEntity
    {
        public int[] cards;

        public int score;

        public int[] hidden;
    }
}