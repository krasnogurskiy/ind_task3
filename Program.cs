
using System;

namespace card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Suit b = (Suit)1;
            Card a = new Card(1, b);
            Console.WriteLine(a);
        }
    }
}

