using System;
using System.Collections.Generic;
using System.Text;

namespace card_game
{
    // Я шось так поняв, шо нам масть, напевно, не треба буде, ну але я вже написав, тому най буде)))
    

    //Масть
    public enum Suit
    {
        Heart, 
        Diamond, 
        Spade,
        Club
    }
    class Card: IFormattable
    {
        private int cost; // Вартість карти
        public int GetCost() // Геттер
        {
            return cost;
        }

        // Реалізація IFormattable (я тупо зробив ту, яку пропонував компілятор, тому можете дописати)
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return cost.ToString(format, formatProvider);
        }

        public Card(int _cost) { cost = _cost; } // Конструктор за параметрами (нам іншого і не треба буде, правда?)

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
