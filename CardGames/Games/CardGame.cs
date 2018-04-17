using System;

namespace CardsCore
{
    public abstract class CardGame
    {
        public CardGame()
        {
        }

		public abstract void Start();

		public abstract void Finish();
    }
}
