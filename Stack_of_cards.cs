using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{
    // Клас, який моделює стопку карт
    class Stack_of_cards
    {
        // Поля класу
        private LinkedList<Card> cards;
        private bool is_opened;


        // Конструктор за замовчуванням, ініціалізує стек карт з відкритим станом і порожнім списком карт
        public Stack_of_cards()
        {
            is_opened = true;
            cards = new LinkedList<Card>();
        }
        
        // Конструктор, що приймає булевий параметр is_op, ініціалізує стек карт зі зазначеним станом і порожнім списком карт
        public Stack_of_cards(bool is_op)
        {
            is_opened = is_op;
            cards = new LinkedList<Card>();

        }

        // Конструктор, що приймає посилання на існуючий зв'язний список карт та булевий параметр is_op,
        // ініціалізує стек карт з вказаним списком карт і станом
        public Stack_of_cards(LinkedList<Card> c, bool is_op) 
        {
            cards = c;
            is_opened = is_op;
        }


        // Методи класу

        // Додає нову карту
        public void AddCard(Card c) 
        {
            cards.AddFirst(c);
        }
        
         // Знаходить позицію карти у стопці. Повертає індекс першої знайденої карти або -1, якщо карта не знайдена
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

        // Видаляє діапазон карт починаючи з позиції pos і повертає видалений діапазон у вигляді нового зв'язаного списку
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
        
        // Перевизначення методу ToString()
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

         // Додає діапазон карт до стеку (під стопку)
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
