using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{
    // Я шось так поняв, шо нам масть, напевно, не треба буде, ну але я вже написав, тому най буде)))

    //♠️♣️♥️♦️
    //Масть
    public enum Suit
    {
        Heart = 0, 
        Diamond = 1, 
        Spade = 2,
        Club = 3
    }
    class Card: IFormattable
    {
        private uint cost; // Вартість карти (я подумав, шо і так там майже всьо циферки: туз = 1, валет = 10, дама = 11, король = 12; Тому uint тут мав би добре підійти)
        private Suit suit;
        public uint GetCost() // Геттер
        {
            return cost;
        }

        // Реалізація IFormattable (я тупо зробив ту, яку пропонував компілятор, тому можете дописати)
        public string ToString(string format, IFormatProvider formatProvider)
        {
            string c = " ";
            switch(cost)
            {
                case 1:
                    c = "Ace";
                    break;
                case 2:
                    c = "Two";
                    break;
                case 3:
                    c = "Three";
                    break;
                case 4:
                    c = "Four";
                    break;
                case 5:
                    c = "Five";
                    break;
                case 6:
                    c = "Six";
                    break;
                case 7:
                    c = "Seven";
                    break;
                case 8:
                    c = "Eight";
                    break;
                case 9:
                    c = "Nine";
                    break;
                case 10:
                    c = "Jack";
                    break;
                case 11:
                    c = "Queen";
                    break;
                case 12:
                    c = "King";
                    break;
            }
            string s = " ";
            switch(suit)
            {
                case (Suit)0:
                    s = "♥️";
                    break;
                case (Suit)1:
                    s = "♦️";
                    break;
                case (Suit)2:
                    s = "♠️";
                    break;
                case (Suit)3:
                    s = "♣️";
                    break;
            }
            return ($"The {c} of {suit}s {s}");
        }

        // Конструктор за параметрами (нам іншого і не треба буде, правда?)
        public Card(uint _cost, Suit _suit) 
        {
            if (_cost > 0 && _cost < 12)  // Перевірка заданого числа на межі (1, 12)
                cost = _cost;
            else
            {
                throw new ArithmeticException($"Cannot create the card - Cost must be in borders (1, 12), not {_cost}");
            }   
            suit = _suit;
        } 

        //Перевантаження операторів порівняння
        public static bool operator ==(Card obj1, Card obj2)
        {
            return (obj1.cost == obj2.cost);
        }
        public static bool operator !=(Card obj1, Card obj2)
        {
            return (obj1.cost != obj2.cost);
        }


    }
}
