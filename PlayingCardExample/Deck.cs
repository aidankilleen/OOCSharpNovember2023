using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardExample
{
    internal class Deck
    {
        // properties
        private Card[] cards = new Card[52];

        // functions

        // constructor(s)
        public Deck() 
        {
            // create one of each card
            int count = 0;
            for (int suit=1; suit <=4; suit++)
            {
                for (int value=1; value<=13; value++)
                {
                    cards[count++] = new Card(suit, value);
                }
            }
        }

        // other functions
        public void Display()
        {
            for (int i=0; i<cards.Length; i++)
            {
                cards[i].Display();

                if (i == 12 || i == 25 || i == 38 || i == 51)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public void Shuffle(int count)
        {
            Random rg = new Random();

            for (int i = 0; i < count; i++)
            {
                int r1 = rg.Next(52);
                int r2 = rg.Next(52);

                // swap cards at r1 & r2
                Card t = cards[r1];
                cards[r1] = cards[r2];
                cards[r2] = t;
            }
        }
    }
}
