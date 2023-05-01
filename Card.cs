using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

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

        // Реалізація IFormattable 
        public override string ToString()
        {
            return this.ToString("Open", CultureInfo.CurrentCulture);
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            string c = string.Empty;
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
                    c = "Ten";
                    break;
                case 11:
                    c = "Jack";
                    break;
                case 12:
                    c = "Queen";
                    break;
                case 13:
                    c = "King";
                    break;
            }
            string s = string.Empty;
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
            string st = "|" + c + s + "|";
            switch (format)
            { 
                case "Open":
                    return st;
                    break;
                case "Close":
                    return "|X|";
                    break;
                default:
                    return "Error: Opened or Closed?";
            }
        }
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);    
        }

        // Конструктор за параметрами (нам іншого і не треба буде, правда?)
        public Card(uint _cost, Suit _suit) 
        {
            if (_cost >= 1 && _cost <= 13)  // Перевірка заданого числа на межі (1, 13)
                cost = _cost;
            else
            {
                throw new ArithmeticException($"Cannot create the card - Cost must be in borders (1, 13), not {_cost}");
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
