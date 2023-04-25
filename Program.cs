
using System;

namespace card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Card a = new Card(1, Suit.Diamond);
            Console.WriteLine(a.ToString("Close"));

        }

        
    }
}

