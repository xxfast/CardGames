using System;
using System.Collections.Generic;
namespace CardsCore
{
    public abstract class Deck<T>
    {
		public const double MAX_SHUFFLE_TURNS = 2500;
		
        private Random rnd = new Random();
        private Stack<T> cards = new Stack<T>();

        public Stack<T> Cards
        {
            get {
                return cards;
            }
        }

        public T Draw(){
            return Cards.Pop();
        }

        public void Shuffle()
        {
            T[] values = Cards.ToArray();
            for (int i =0; i < MAX_SHUFFLE_TURNS; i++){
				int rindex1 = rnd.Next(cards.Count);
				int rindex2 = rnd.Next(cards.Count);
                T temp = values[rindex1];
                values[rindex1] = values[rindex2];
                values[rindex2] = temp;
            }
            cards.Clear();
            foreach(T card in values){
                cards.Push(card);
            }
        }
    }
}
