using System;
using System.Collections.Generic;
using System.Linq;

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
            int n = 0;
            while(true)
            {
                Console.WriteLine("Enter number of players: ");
                n = Int32.Parse(Console.ReadLine());
                if(n >= 2 && n <= 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Number of players must be no less than 2 and no more than 6. Try again.");
                    n = Int32.Parse(Console.ReadLine());
                }
            }
            Deck deck = new Deck(n);
            Player[] pl_arr = new Player[n];
            for (int i = 0; i < n; i++)
            {
                string name = "player";
                pl_arr[i] = new Player(name + "_" + (i + 1).ToString());
            }
            LinkedList<Card> remainder = new LinkedList<Card>();
            remainder = deck.DealCards(pl_arr);
            Stack_of_cards stack = new Stack_of_cards();
            if(remainder.Count != 0)
            {
                stack.AddRangeOfCards(remainder);
            }
            Console.WriteLine("Start of game");
            Console.WriteLine("Common stack: {0}", stack);
            Console.WriteLine("Players: ");
            foreach( Player x in pl_arr)
            {
                Console.WriteLine(x);
            }
            bool smb_won = false;
            int step = 0;
            while(!smb_won)
            {
                for(int i = 0; i < pl_arr.Length; ++i)
                {
                    Console.WriteLine("-------------------------Step {0}----------------------", step);
                    Card temp = pl_arr[i].RemoveCard();
                    int pos = stack.FindCard(temp);
                    stack.AddCard(temp);
                    Console.WriteLine("{0} added {1} to stack.", pl_arr[i].Name, temp.ToString("Open"));
                    if (pos != -1)
                    {
                        pos += 1;
                        Console.WriteLine(pos);
                        pl_arr[i].AddRangeOfCards(stack.RemoveRangeOfCards(pos));
                        Console.WriteLine("{0} added range of cards to his stack.", pl_arr[i].Name);
                    }
                    if(pl_arr[i].NumberOfCards == deck.NumberOfCard)
                    {
                        Console.WriteLine("{0} won!!!", pl_arr[i].Name);
                        smb_won = true;
                        break;
                    }
                    else if(pl_arr[i].NumberOfCards == 0)
                    {
                        Console.WriteLine("{0} lost!!!", pl_arr[i].Name);
                        pl_arr = pl_arr.Where((_, j) => j != i).ToArray();
                    }
                    Console.WriteLine("Common stack: {0}", stack);
                    Console.WriteLine("Players: ");
                    foreach (Player x in pl_arr)
                    {
                        Console.WriteLine(x);
                    }
                    step += 1;
                }
            }
            Console.WriteLine("End of game");
        }
    }
}

