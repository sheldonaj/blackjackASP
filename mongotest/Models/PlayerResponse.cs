using System.Collections.Generic;
using System.Linq;

namespace mongotest.Models
{
    public class PlayerResponse
    {
        public int score;
        public List<CardResponse> cards;

        public PlayerResponse(PlayerEntity player)
        {
            cards = player.cards
                            .Select(x => new CardResponse(x))
                            .ToList();
        }
    }
}