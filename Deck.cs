using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace card_game
{
    // Клас, який моделює колоду карт
    class Deck
    {
        private int number_of_players; // Кількість гравців
        private Card[] cards; // Колода

        // Конструктор класу Колода. Якщо гравців менше 4-ох, колода містить 36 карт, у іншому випадку - 52  
        public Deck(int _players)
        {
            number_of_players = _players;
            if (_players < 4)
            {
                cards = new[] {new Card(6, Suit.Heart), new Card(7, Suit.Heart), new Card(8, Suit.Heart), new Card(9, Suit.Heart),
                    new Card(10, Suit.Heart), new Card(11, Suit.Heart), new Card(12, Suit.Heart), new Card(13, Suit.Heart), new Card(1, Suit.Heart),
                    new Card(6, Suit.Club), new Card(7, Suit.Club), new Card(8, Suit.Club), new Card(9, Suit.Club), new Card(10, Suit.Club),
                    new Card(11, Suit.Club), new Card(12, Suit.Club), new Card(13, Suit.Club), new Card(1, Suit.Club), new Card(6, Suit.Diamond), new Card(7, Suit.Diamond),
                    new Card(8, Suit.Diamond), new Card(9, Suit.Diamond), new Card(10, Suit.Diamond), new Card(11, Suit.Diamond),
                    new Card(12, Suit.Diamond), new Card(13, Suit.Diamond), new Card(1, Suit.Diamond), new Card(6, Suit.Spade), new Card(7, Suit.Spade),
                    new Card(8, Suit.Spade), new Card(9, Suit.Spade), new Card(10, Suit.Spade), new Card(11, Suit.Spade),
                    new Card(12, Suit.Spade), new Card(13, Suit.Spade), new Card(1, Suit.Spade) };
            }
            else
            {
                cards = new[] {new Card(2, Suit.Heart), new Card(3, Suit.Heart), new Card(4, Suit.Heart), new Card(5, Suit.Heart),
                    new Card(6, Suit.Heart), new Card(7, Suit.Heart), new Card(8, Suit.Heart), new Card(9, Suit.Heart), new Card(10, Suit.Heart),
                    new Card(11, Suit.Heart), new Card(12, Suit.Heart), new Card(13, Suit.Heart), new Card(1, Suit.Heart), new Card(2, Suit.Club), new Card(3, Suit.Club),
                    new Card(4, Suit.Club), new Card(5, Suit.Club), new Card(6, Suit.Club), new Card(7, Suit.Club), new Card(8, Suit.Club),
                    new Card(9, Suit.Club), new Card(10, Suit.Club), new Card(11, Suit.Club), new Card(12, Suit.Club), new Card(13, Suit.Club), new Card(1, Suit.Club),
                    new Card(2, Suit.Diamond), new Card(3, Suit.Diamond), new Card(4, Suit.Diamond), new Card(5, Suit.Diamond), new Card(6, Suit.Diamond),
                    new Card(7, Suit.Diamond), new Card(8, Suit.Diamond), new Card(9, Suit.Diamond), new Card(10, Suit.Diamond), new Card(11, Suit.Diamond),
                    new Card(12, Suit.Diamond), new Card(13, Suit.Diamond), new Card(1, Suit.Diamond), new Card(2, Suit.Spade), new Card(3, Suit.Spade), new Card(4, Suit.Spade),
                    new Card(5, Suit.Spade), new Card(6, Suit.Spade), new Card(7, Suit.Spade), new Card(8, Suit.Spade), new Card(9, Suit.Spade),
                    new Card(10, Suit.Spade), new Card(11, Suit.Spade), new Card(12, Suit.Spade), new Card(13, Suit.Spade), new Card(1, Suit.Spade) };
            }
        }

        // Властивість, що повертає кількість карт у колоді
        public int NumberOfCard
        {
            get { return cards.Length; }
        }

        // Метод, який моделює роздачу карт гравцям. Колода перемішується, після чого кожному гравцю
        // по черзі видається випадкова карта з колоди. Якщо колоду не вдається порівно розподілити між
        // гравцями, метод повертає залишок
        public LinkedList<Card> DealCards(Player[] players)
        {
            LinkedList<Card> remainder = new LinkedList<Card>();
            int number_of_cards = cards.Length;
            var random = new Random(DateTime.Now.Millisecond);
            cards = cards.OrderBy(x => random.Next()).ToArray();
            Stack<Card> shuffle_cards = new Stack<Card>(cards);
            while (number_of_cards >= number_of_players)
            {
                for (int i = 0; i < number_of_players; ++i)
                {
                    players[i].AddCardTop(shuffle_cards.Pop());
                    number_of_cards -= 1;
                }
            }
            int count = shuffle_cards.Count;
            for (int i = 0; i < count; ++i)
            {
                remainder.AddLast(shuffle_cards.Pop());
            }
            Console.WriteLine($"The cards are dealt to the players. Each player received a {players[0].NumberOfCards} card.");
            return remainder;
        }
    }
}

      

