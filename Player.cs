using System;
using System.Collections.Generic;

namespace DeckOfCards
{
	public class Player
	{
        private string _name;
		public string name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value.Trim().Length == 0)
					throw new ArgumentOutOfRangeException("Player name can not be blank!!!");
				_name = value;
			}
		}
		private Deck _hand;

		public Player(string playerName)
		{
			name = playerName;
			_hand = new Deck(false);  //empty deck to start;            
		}
		public Card draw(Deck incomingDeck)
		{
			Card newCard = incomingDeck.deal();
			if (null != newCard)
			{
				_hand.cards.Add(newCard);
			}
            else
            {
                Console.WriteLine("Player drew a null card");
            }
			return newCard;
		}
        public Card discard(int index) 
        {
            if (index < 0) {
                throw new ArgumentException("Index cannot be a negitive number!");
            }
            if (index >= _hand.cards.Count)
            {
                return null;
            }
            Card thisCard = _hand.cards[index];
            _hand.cards.RemoveAt(index);
            return thisCard;
        }
        
        public override string ToString()
        {
            return $"Player {this.name} {this._hand.ToString()}";
        }
	}
}