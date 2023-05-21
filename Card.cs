using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace card_game
{
    //Масті карт
    public enum Suit
    {
        Heart = 0,      // Черви
        Diamond = 1,    // Буби
        Spade = 2,      // Піки
        Club = 3        // Хрести
    }
    
    // Клас, який моделює Карту
    class Card: IFormattable
    {
        private uint cost;  // Вартість карти 
        private Suit suit;  // Масть карти
        
        // Гетер, повертає вартість карти
        public uint GetCost() 
        {
            return cost;
        }

        // Перевизначений метод ToString() 
        public override string ToString()
        {
            return this.ToString("Open", CultureInfo.CurrentCulture);
        }
        
        // Перевизначений метод ToString() з використанням інтерфейсу IFormattable для форматованого представлення карти
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
        
        // Перевизначений метод ToString(), який приймає лише формат
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);    
        }

        // Конструктор за параметрами класу Card, який приймає вартість карти та масть карти
        public Card(uint _cost, Suit _suit) 
        {
            if (_cost >= 1 && _cost <= 13)  // Перевірка валідності вартості карти
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
