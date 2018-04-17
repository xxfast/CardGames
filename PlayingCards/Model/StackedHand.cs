using System;
using System.Collections.Generic;
using CardsCore;

namespace PlayingCards
{
    public class StackedHand
    {
        private Stack<PlayingCard> cards = new Stack<PlayingCard>();

        public Stack<PlayingCard> Cards
        {
            get { return cards; }
        }

        public void Add(PlayingCard toAdd){
            cards.Push(toAdd);
        }

        public PlayingCard Draw(){
            return cards.Pop();
        }

    }
}
