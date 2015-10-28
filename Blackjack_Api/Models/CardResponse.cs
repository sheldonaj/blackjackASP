namespace blackjack.Models
{
    public class CardResponse
    {
        public int rank;

        public char suit;

        public CardResponse(int cardValue)
        {
            rank = (cardValue % 13) + 1;
            suit = 'H';
        }
    }
}