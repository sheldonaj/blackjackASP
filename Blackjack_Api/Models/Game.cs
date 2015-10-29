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
            return getScore(Player.cards);
        }

        internal int GetDealerScore()
        {
            return getScore(Dealer.cards);
        }

        private static int getScore(IEnumerable<int> hand)
        {
            var cards = getCardRanks(hand);

            return cards.Sum(card => getCardScore(card));
        }

        private static IEnumerable<int> getCardRanks(IEnumerable<int> cards)
        {
            return from card in cards
                   select (card % 13) + 1;
        }

        private static int getCardScore(int card)
        {
            if (card == 1)
            {
                return 11;
            }
            else if (card >= 11)
            {
                return 10;
            }
            return card;
        }

    }
}