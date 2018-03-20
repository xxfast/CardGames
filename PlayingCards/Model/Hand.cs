using System;
using System.Collections.Generic;
using CardsCore;

namespace PlayingCards
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return cards; }
        }

        public Hand()
        {
        }


    }
}
