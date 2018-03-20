using System;
using CardsCore;

namespace PlayingCards
{
    public class PlayingCard : Card, IComparable<PlayingCard>
	{
		private Suit suit;
		private Rank rank;

		public PlayingCard(Suit s, Rank r)
		{
			suit = s;
			rank = r;
		}

        public void print(ref int i){
            i++;
        }

        public override string ToString()
        {
            String[] suitSymbols= new String[] {"♠️","♥️","♣️","♦️"};
            String[] rankSymbols = new String[] {"1","2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            return string.Format("{0} {1}",rankSymbols[(int)rank],suitSymbols[(int)suit]);
        }

		public int CompareTo(PlayingCard other)
		{
			if (other == null)
				return 1;
            return rank.CompareTo(other.rank);
		}

		public static bool operator <(PlayingCard lhs, PlayingCard rhs)
		{
			return lhs.CompareTo(rhs) < 0;
		}

		public static bool operator >(PlayingCard lhs, PlayingCard rhs)
		{
			return lhs.CompareTo(rhs) > 0;
		}
	}

}
