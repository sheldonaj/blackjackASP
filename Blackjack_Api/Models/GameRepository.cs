using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace blackjack.Models
{
    public class GameRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        protected static IMongoCollection<GameEntity> _collection;

        public GameRepository()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["Mongodb"].ConnectionString;
            _client = new MongoClient(connection);
            _database = _client.GetDatabase(System.Configuration.ConfigurationManager.AppSettings["DataBaseName"]);
            _collection = _database.GetCollection<GameEntity>("games");
        }

        public async Task<GameEntity> GetGame(string id)
        {
            var gameId = new ObjectId(id);
            var filter = Builders<GameEntity>.Filter.Eq("_id", gameId);
            var result = await _collection.Find(filter).ToListAsync();
            return result.FirstOrDefault();
        }

    }
}