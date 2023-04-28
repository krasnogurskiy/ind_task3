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
        public Stack_of_cards()
        {
            is_opened = true;
            cards = new LinkedList<Card>();
        }
        public Stack_of_cards(LinkedList<Card> c, bool is_op) { cards = c; is_opened = is_op; } // Конструктор за параметрами


        // Методи різні
        public void AddCard(Card c) // Додавання нової карти
        {
            cards.AddFirst(c);
        }

        public int FindCard(Card c)
        {
            LinkedListNode<Card> currentNode = cards.First;
            int index = 0;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(c))
                {
                    return index;
                }
                currentNode = currentNode.Next;
                index++;
            }
            return -1;
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
        public override string ToString()
        {
            string st = string.Empty;
            foreach (Card i in cards)
            {
                if (is_opened)
                {
                    st = st + i.ToString("Open") + " ";
                }
                else
                {
                    st = st + i.ToString("Close") + " ";
                }
            }
            return st;
        }

        /*
         метод, який буде додавати діапазон карт під стопку
         */
        public void AddRangeOfCards(LinkedList<Card> cardsToAdd)
        {
            LinkedListNode<Card> lastNode = cards.Last;
            foreach (Card card in cardsToAdd)
            {
                LinkedListNode<Card> newNode = new LinkedListNode<Card>(card);
                cards.AddAfter(lastNode, newNode);
                lastNode = newNode;
            }
        }
    }
}
