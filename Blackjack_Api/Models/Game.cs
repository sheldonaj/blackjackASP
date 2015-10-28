using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blackjack.Models
{
    public class Game
    {
        private GameEntity gameDocument;

        public string Result
        {
            get
            {
                return gameDocument.result;
            }
            internal set
            {
                gameDocument.result = value;
            }
        }
        public string Id
        {
            get
            {
                return gameDocument.id.ToString();
            }
        }
        public PlayerEntity Dealer
        {
            get
            {
                return gameDocument.dealer;
            }
        }
        public PlayerEntity Player
        {
            get
            {
                return gameDocument.player;
            }
        }

        public Game(GameEntity game)
        {
            gameDocument = game;
        }

        internal int GetPlayerScore()
        {
            return 10;
        }

        internal int GetDealerScore()
        {
            return 20;
        }
    }
}