using System;
using CardsCore;

namespace UnoCards
{
    public class UnoGame : CardGame
    {
        private UnoDeck deck;

        public UnoGame()
        {
            deck = UnoDeck.Generate();
        }

        public override void Start()
        {

        }

		public override void Finish()
		{

		}
    }
}
