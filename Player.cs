using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{
    class Player
    {
        private Stack_of_cards cards;
        private int number_of_cards;

        public Player()
        {
            cards = new Stack_of_cards(false);
            number_of_cards = 0;
        }
        public void AddCardTop(Card card)
        {
            cards.AddCard(card);
        }

        public int NumberOfCards { }

        public Card RemoveCard() { }

        public void AddRangeOfCards(LinkedList<Card> cardsToAdd) { }

        public override string ToString()
        {
            return ("Player`s stack: " + cards.ToString());
        }
    }
}