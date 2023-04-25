using System.Text;
using System;

namespace card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Player[] players = { new Player(), new Player(), new Player(), new Player() };
            Deck d = new Deck(4);
            d.DealCards(players);
            foreach(var i in players)
            {
                Console.WriteLine(i);
            }

        }

        
    }
}

