using System;
using System.Collections.Generic;

namespace DeckOfCards
{
	public class Card
	{
		private string _stringVal;
		public string stringVal
		{
			get
			{
				return _stringVal;
			}
		}
		private int _val;
		public int Val
		{
			get { return _val; }
			set
			{
				if ((value < 1) || (value > 13))
					throw new ArgumentOutOfRangeException("The Card value must be between 1 and 13");

				_val = value;
				switch (value)
				{
					case 1:
						_stringVal = "Ace";
						break;
					case 11:
						_stringVal = "Jack";
						break;
					case 12:
						_stringVal = "Queen";
						break;
					case 13:
						_stringVal = "King";
						break;
					default:
						_stringVal = _val.ToString();
						break;
				}
			}
		}
		private string _stringSuit;
		public string stringSuit
		{
			//this is set with suit below.
			get
			{
				return _stringSuit;
			}
		}

		private string _suit;
		public string suit
		{
			get
			{
				return _suit;
			}
			set
			{
				switch (value.ToLower())
				{
					case "spades":
						_suit = "Spades";
						_stringSuit = "♠";
						break;
					case "hearts":
						_suit = "Hearts";
						_stringSuit = "♥";
						break;
					case "clubs":
						_suit = "Clubs";
						_stringSuit = "♣︎";
						break;
					case "diamonds":
						_suit = "Diamonds";
						_stringSuit = "♦︎";
						break;
					default:
						throw new ArgumentOutOfRangeException("Must be one of [spades, hearts, clubs, diamonds]");
				}
			}
		} //public get set suit
		public Card(int rank, string suit)
		{
            this.Val = rank;
            this.suit = suit;
            // Console.WriteLine($"  Card CTOR: {this.stringVal}, {this.stringSuit}");
		}
        public override string ToString() 
        {
            return $"{this.stringVal[0]}{this.stringSuit}";
        }

	}// class card
}