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
            //string connection = "mongodb://localhost:27017";
            //string connection = "mongodb://testuser:test01@ds051953.mongolab.com:51953/heroku_3lzrg7fx";
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["Mongodb"].ConnectionString;
            _client = new MongoClient(connection);
            // _database = _client.GetDatabase("mean-dev");
            //_database = _client.GetDatabase("heroku_3lzrg7fx");
            _database = _client.GetDatabase(System.Configuration.ConfigurationManager.AppSettings["DataBaseName"]);
            _collection = _database.GetCollection<GameEntity>("games");
        }

        public async Task<GameEntity> GetGame(string id)
        {
            //var filter = Builders<BsonDocument>.Filter.Eq("_id", "5614119ca3a35b704df4a447");
            var filter = new BsonDocument();
            var result = await _collection.Find(filter).ToListAsync();
            return result.FirstOrDefault();
        }

    }
}