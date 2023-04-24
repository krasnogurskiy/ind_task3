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
    class Card
    {
        private int cost; // Вартість карти
        public int GetCost() // Геттер
        {
            return cost;
        }
        public Card(int _cost) { cost = _cost; }
    }
}
