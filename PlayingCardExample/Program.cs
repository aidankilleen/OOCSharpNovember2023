using PlayingCardExample;

Console.WriteLine("Playing Card Example");


Deck deck = new Deck();

deck.Display(); // show all 52 cards


deck.Shuffle(1);
deck.Display();

deck.Shuffle(10);
deck.Display();

deck.Shuffle(100);
deck.Display();

deck.Shuffle(1000);
deck.Display();













/*
for (int suit = 1; suit <= 4; suit++)
{

    for (int value=1; value <= 13; value++)
    {
        Card card = new Card(suit, value);
        card.Display();  
    }
    Console.WriteLine();
}


Card invalid = new Card(99, 99);

invalid.Display();

*/

