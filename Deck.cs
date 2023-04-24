using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{

    class Deck
    {
        private int players; // Кількість гравців
        
        private Stack_of_cards cards;
        public Deck()
        {
            LinkedList<Card> cards_in_deck = new LinkedList<Card>();
            for (uint i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    Card c = new Card(i, (Suit)Enum.Parse(typeof(Suit), j.ToString()));
                    cards_in_deck.AddLast(c);
                }
            }
        }
    }
}

      

