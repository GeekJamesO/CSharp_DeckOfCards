using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck aDeck = new Deck(true);
            // Console.WriteLine( aDeck.ToString() );
            // Console.WriteLine("Shuffling... ");
            aDeck.shuffle();
			Console.WriteLine(aDeck.ToString());
            Player aPlayer = new Player("bob");
            // Console.WriteLine(aPlayer.ToString());

            // Add two cards. 
            Card returnedCard = aPlayer.draw(aDeck);
            Console.WriteLine(returnedCard);
			returnedCard = aPlayer.draw(aDeck);
			Console.WriteLine(returnedCard);

			Console.WriteLine(aPlayer.ToString());
            //remove second card.
            returnedCard = aPlayer.discard(1);
			Console.WriteLine(returnedCard);

			Console.WriteLine(aPlayer.ToString());
			Console.WriteLine(aDeck.ToString());

		}
    }
}
