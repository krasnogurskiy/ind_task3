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
        public Stack_of_cards(bool is_op)
        {
            is_opened = is_op;
            cards = new LinkedList<Card>();

        }

        // Конструктор за параметрами
        public Stack_of_cards(LinkedList<Card> c, bool is_op) 
        {
            cards = c;
            is_opened = is_op;
        }


        // Методи різні
        // Додавання нової карти
        public void AddCard(Card c) 
        {
            cards.AddFirst(c);
        }

        /* 
        метод шукає карту в стопці
        обходим вузли за допомогою while, порівнюєм значення вузла з потрібною картою, 
        знаходим: повертаєм індекс поточного числа, не находим:  вертаєм -1
         */
        public int FindCard(Card c)
        {
            LinkedListNode<Card> currentNode = cards.First;
            int index = 0;
            while (currentNode != null)
            {
                if (currentNode.Value == c)
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
            if (pos == 0)
            {
                range.AddLast(end_node.Value);
                cards.RemoveFirst();
            }
            else
            {
                while (pos >= 0)
                {
                    if (pos > 0)
                    {
                        range.AddLast(end_node.Value);
                        end_node = end_node.Next;
                        cards.Remove(end_node.Previous.Value);
                    }
                    else
                    {
                        range.AddLast(end_node.Value);
                        cards.Remove(end_node.Value);
                    }
                    pos -= 1;
                }
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
         метод, що додає діапазон карт під стопку
        приймає список карт, робить для кожної карти в списку - вузол,
        додає під стопку за допомогою AddAfter()
         */
        public void AddRangeOfCards(LinkedList<Card> cardsToAdd)
        {
            foreach (Card card in cardsToAdd)
            {
                LinkedListNode<Card> newNode = new LinkedListNode<Card>(card);
                cards.AddLast(newNode);
            }
        }
    }
}
