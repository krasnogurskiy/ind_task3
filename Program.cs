using System;

namespace card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Card a = new Card(1, Suit.Diamond);
            //Console.WriteLine(a.ToString("Close"));
            Console.Write("Enter number of players: ");
            
            int n = Int32.Parse(Console.ReadLine());
            Deck deck = new Deck(n);
            Player[] pl_arr = new Player[n];
            for (int i = 0; i < n; i++)
            {
                pl_arr[i] = new Player();
            }
            deck.DealCards(pl_arr);
            Stack_of_cards stack = new Stack_of_cards();

            Console.WriteLine(deck);
            Console.WriteLine(stack);
            foreach( Player x in pl_arr)
            {
                Console.WriteLine(x);
            }
                    


            bool smb_won = false;
            while(!smb_won)
            {
                break;
            }


        }

        
    }
}

