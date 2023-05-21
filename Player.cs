using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{
    // Гравець
    class Player
    {
        private Stack_of_cards cards; // Стопка карт в гравця
        private int number_of_cards; // Кількість карт
        private string name; // Ім'я гравця

        // Конструктор
        public Player(string _name)
        {
            cards = new Stack_of_cards(false);
            number_of_cards = 0;
            name = _name;
        }
        // Метод для додавання карти в верх стопки
        public void AddCardTop(Card card)
        {
            cards.AddCard(card);
            number_of_cards += 1;
        }
        // Гетер, що повертає ім'я гравця
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
        // Виведення стопки гравця
        public override string ToString()
        {
            return ($"{name} stack: " + cards.ToString());
        }
    }
}