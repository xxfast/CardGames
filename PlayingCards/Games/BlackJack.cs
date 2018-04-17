using System;
using System.Collections.Generic;

using CardsCore;

namespace PlayingCards
{
    public class BlackJack : CardGame
    {
        List<StackedHand> players = new List<StackedHand>();
        PlayingCardsDeck deck = new PlayingCardsDeck();

        public override void Start(){
            deck.Shuffle();
            // TODO : Everything else
        }

		public override void Finish()
		{
			deck.Shuffle();
			// TODO : Everything else
		}
    }
}
