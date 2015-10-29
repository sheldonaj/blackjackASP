using System;

namespace blackjack.Models
{
    public class CardResponse
    {
        public int rank;

        public char suit;

        private static readonly char[] suits = { 'C', 'D', 'H', 'S' };

        public CardResponse(int cardValue)
        {
            rank = (cardValue % 13) + 1;
            suit = numberToSuit(cardValue);
        }

        private char numberToSuit(int cardValue)
        {
            int index = (int)Math.Floor(cardValue / 13.0);
            return suits[index];
        }
    }
}