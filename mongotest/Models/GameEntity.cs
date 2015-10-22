using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongotest.Models
{
    [BsonIgnoreExtraElements]
    public class GameEntity
    {
        [BsonId]
        public ObjectId id { get; set; }

        public string result { get; set; }

        public int deckLocation { get; set; }

        public int[] cards {get; set; }

        public PlayerEntity dealer { get; set; }

        public PlayerEntity player { get; set; }

        public BsonDateTime created { get; set; }

    }
}