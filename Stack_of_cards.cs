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
        }

        public int FindCard(Card c)
        {
            return 0;
        }
        public LinkedList<Card> RemoveRangeOfCards(int pos)
        {
            LinkedList<Card> range = new LinkedList<Card>();
            LinkedListNode<Card> end_node = cards.First;
            while (pos >= 0)
            {
                range.AddLast(end_node.Value);
                end_node = end_node.Next;
                cards.Remove(end_node.Previous.Value);
                pos -= 1;
            }
            return range;
        }
    }
}
