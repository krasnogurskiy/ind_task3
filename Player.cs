using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{
    class Player
    {
        private Stack_of_cards cards;
        private int number_of_cards;
        private string name;

        public Player(string _name)
        {
            cards = new Stack_of_cards(false);
            number_of_cards = 0;
            name = _name;
        }
        public void AddCardTop(Card card)
        {
            cards.AddCard(card);
            number_of_cards += 1;
        }

        public string Name
        {
            get { return name; }
        }

        // Гетер, що повертає кількість карт у гравця
        public int NumberOfCards 
        {
            get { return number_of_cards; }
        }

        // Вилучає карту зверху стопки гравця
        public Card RemoveCard() 
        {
            LinkedList<Card> range = cards.RemoveRangeOfCards(0);
            number_of_cards--;
            return range.First.Value;
        }

        // Додає діапазон карт вниз стопки гравця
        public void AddRangeOfCards(LinkedList<Card> cardsToAdd)
        {
            cards.AddRangeOfCards(cardsToAdd);
            number_of_cards += cardsToAdd.Count;
        }

        public override string ToString()
        {
            return ($"{name} stack: " + cards.ToString());
        }
    }
}