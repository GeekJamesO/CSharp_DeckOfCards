using System;
using System.Text;
using System.Collections.Generic;
namespace DeckOfCards
{
	public class Deck
	{
		public List<Card> cards;
		public Deck(bool createDeck = true)
		{
			cards = new List<Card>();
			if (createDeck)
			{
				reset();
			}
		}
		public void reset()
		{
			var Suits = new List<string>() { "Spades", "Hearts", "Clubs", "Diamonds" };

			foreach (string s in Suits)
			{
				for (int i = 1; i <= 13; i++)
					cards.Add(new Card(i, s));
			}
		}
		public Card deal()
		{
			if (cards.Count == 0)
			{
				return null;
			}
			var result = cards[0];
			cards.RemoveAt(0);
			return result;
		}
		public void shuffle()
		{
			Random r = new Random();
			int maxIndex = cards.Count;
			int first, second;
			Card temp;
			int swapsToMake = cards.Count * 7;
			for (int i = 0; i < swapsToMake; i++)
			{
				first = r.Next(maxIndex);
				second = r.Next(maxIndex);
				if (first == second)
					continue;
				temp = this.cards[first];
				this.cards[first] = this.cards[second];
				this.cards[second] = temp;
			}
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append($"[ {this.cards.Count} Cards: [ ");
			for (int i = 0; i < cards.Count; i++)
			{
				if (i <  cards.Count - 1)
				{
					string result = cards[i].ToString();
					sb.Append($"{result}, ");
				}
				else
				{
					sb.Append(cards[i].ToString());
				}
			}
			sb.Append(" ] ]");
			return sb.ToString();
		}
	}
}