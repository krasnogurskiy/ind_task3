using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{
    class Stack_of_cards
    {
        // Поля
        private LinkedList<Card> cards;  
        private bool is_opened;


        //Конструктори
        public Stack_of_cards() { is_opened = true; } // Конструктор за замовчуванням (поняття не маю, для чого я його написав взагалі: він нам знадобиться настільки ж сильно, як і матан)
        public Stack_of_cards(LinkedList<Card> c, bool is_op) { cards = c; is_opened = is_op; } // Конструктор за параметрами


        // Методи різні
        public void AddCard(Card c) // Додавання нової карти
        {
            cards.AddFirst(c);
            Console.WriteLine("Card is added to the top of the stack: ", c);
        }

        public int FindCard(Card c)
        {
            return 0;
        }



    }
}
