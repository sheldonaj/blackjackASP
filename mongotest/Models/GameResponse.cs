using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mongotest.Models
{
    public class GameResponse
    {
        public string id { get; set; }

        public PlayerResponse dealer { get; set; }

        public PlayerResponse player { get; set; }

        public string result { get; set; }

        public GameResponse(Game game)
        {
            result = game.Result;
            id = game.Id;
            dealer = new PlayerResponse(game.Dealer);
            dealer.score = game.GetDealerScore();
            player = new PlayerResponse(game.Player);
            player.score = game.GetPlayerScore();
        }
    }
}