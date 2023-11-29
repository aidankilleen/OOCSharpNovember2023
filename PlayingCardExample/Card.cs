using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardExample
{
    internal class Card
    {
        public int Suit { get; set; } // H=1, S=2, D=3, C=4
        public int Value { get; set; } // A=1, 2=2, ... J=11, Q=12, K=13

        public Card(int suit, int value) {
            Suit = suit;
            Value = value;
        }
        public void Display()
        {
            string card = "";

            // value
            switch(Value)
            {
                case 1:
                    card += " A";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    card += " " + Value;
                    break;
                case 10:
                    card += "" + Value;
                    break;
                case 11:
                    card += " J";
                    break;
                case 12:
                    card += " Q";
                    break;
                case 13:
                    card += " K";
                    break;
                default:
                    card += " ?";
                    break;
            }

            // suit
            if (Suit == 1)
            {
                card += "H ";
            } else if (Suit == 2)
            {
                card += "S ";
            } else if (Suit == 3)
            {
                card += "D ";
            } else if (Suit == 4)
            {
                card += "C ";
            } else
            {
                card += "? ";
            }


            Console.Write(card);
        }

    }
}
